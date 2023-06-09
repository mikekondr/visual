using System;
using System.Linq;
using System.Windows.Forms;

namespace task3
{
    public partial class frmCosts : Form
    {
        readonly string[] strCosts =
        {
            "Комунальні платежі",
            "Зарплата",
            "Оренда",
            "Потадки",
            "Витратні матеріали",
            "Транспорт",
            "Зв'язок",
            "Цифрові ліцензії",
            "Технічна підтримка",
            "Канцелярія",
        };

        public frmCosts()
        {
            InitializeComponent();
        }

        private void btnCreateMas_Click(object sender, EventArgs e)
        {
            int CostsCount = (int)numCostsCount.Value;

            dgvCosts.Rows.Clear();
            dgvCosts.Columns.Clear();

            dgvCosts.ColumnCount = CostsCount;
            foreach (DataGridViewColumn col in dgvCosts.Columns)
            {
                col.HeaderText = (col.Index + 1).ToString();
                col.Width = 100;
            }

            dgvCosts.Rows.Add();
            dgvCosts.Rows.Add();

            int[] rnd = RandomCosts(CostsCount);

            for(int i = 0; i < CostsCount; i++)
            {
                dgvCosts.Rows[0].Cells[i].Value = strCosts[rnd[i]];
                dgvCosts.Rows[1].Cells[i].Value = "0";
            }
        }

        private int[] RandomCosts(int count)
        {
            int[] result = Enumerable.Repeat(-1, count).ToArray();

            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int j;
                do j = rnd.Next(0, 10);
                while (result.Contains(j));
                result[i] = j;
            }

            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string[] X = new string[dgvCosts.ColumnCount];
            int[] Y = new int[dgvCosts.ColumnCount];
            int Sum = 0;

            for (int i = 0; i < dgvCosts.ColumnCount; i++)
            {
                X[i] = dgvCosts.Rows[0].Cells[i].Value.ToString();
                if (!Int32.TryParse(dgvCosts.Rows[1].Cells[i].Value.ToString(), out Y[i]))
                {
                    MessageBox.Show("У стовпці \"" + X[i] + "\" (" + (i+1) + ") виявлене неправильне значення!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Y[i] = 0;
                }
                Sum += Y[i];
            }

            if (Sum != 100)
            {
                MessageBox.Show("Некоретно введені дані!\nСума по всім статтям витрат становить \"" + Sum + "\", що не дорівнює 100 (%)",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chart1.Series[0].Points.DataBindXY(X, Y);
        }
    }
}
