using System;
using System.Windows.Forms;

namespace task2
{
    public partial class frmDaig : Form
    {
        public frmDaig()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenEmptyYears_Click(object sender, System.EventArgs e)
        {
            if (!Int32.TryParse(txtStartYear.Text, out int minYear))
            {
                MessageBox.Show("Помилка введення початкового року!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minYear < 2000)
            {
                MessageBox.Show("Рік початку курсів - 2000", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int32.TryParse(txtCountYear.Text, out int mGist) || mGist < 1)
            {
                MessageBox.Show("Помилка введення кількості років!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvYears.Rows.Clear();
            dgvYears.Columns.Clear();

            dgvYears.ColumnCount = mGist;
            for (int i = 0; i < mGist; i++)
            {
                dgvYears.Columns[i].Width = 100;

                dgvYears.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvYears.Columns[i].HeaderText = (minYear + i).ToString() + " рік";
            }

            dgvYears.Rows.Add();
            foreach (DataGridViewCell cell in dgvYears.Rows[0].Cells)
                cell.Value = "0";
        }
        private void btnGenGisto_Click(object sender, EventArgs e)
        {
            int count = dgvYears.Columns.Count;
            int minYear = Int32.Parse(dgvYears.Columns[0].HeaderText.Replace("рік", ""));

            int[] X = new int[count];
            int[] Y = new int[count];

            for (int i = 0; i < count;i++)
            {
                if (!Int32.TryParse(dgvYears.Rows[0].Cells[i].Value as string, out int y) || y < 0)
                {
                    MessageBox.Show("У стовпці \"" + dgvYears.Columns[i].HeaderText + "\" виявлене неправильне значення!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    y = 0;
                }
                X[i] = minYear + i;
                Y[i] = y;
            }

            chart.Series[0].Points.DataBindXY(X, Y);
        }

        private void btnGenEmptyRound_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtMinRound.Text, out int minAge))
            {
                MessageBox.Show("Помилка введення мінімального віку", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minAge < 10)
            {
                MessageBox.Show("Мінімальний вік учня - 10 років!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int32.TryParse(txtCountRound.Text, out int mAge) || mAge < 1)
            {
                MessageBox.Show("Помилка введення кількості вікових груп!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvRound.Rows.Clear();
            dgvRound.Columns.Clear();

            dgvRound.ColumnCount = mAge;
            for (int i = 0; i < mAge; i++)
            {
                dgvRound.Columns[i].Width = 100;

                dgvRound.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgvRound.Columns[i].HeaderText = (minAge + i).ToString() + " років";
            }

            dgvRound.Rows.Add();
            foreach (DataGridViewCell cell in dgvRound.Rows[0].Cells)
                cell.Value = "0";
        }

        private void btnGenRound_Click(object sender, EventArgs e)
        {
            int count = dgvRound.Columns.Count;
            int minAge = Int32.Parse(dgvRound.Columns[0].HeaderText.Replace("років", ""));

            double sum = 0;

            string[] X = new string[count];
            int[] Y = new int[count];

            for (int i = 0; i < count; i++)
            {
                if (!Int32.TryParse(dgvRound.Rows[0].Cells[i].Value as string, out int y) || y < 0)
                {
                    MessageBox.Show("У стовпці \"" + dgvRound.Columns[i].HeaderText + "\" виявлене неправильне значення!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    y = 0;
                }
                X[i] = (minAge + i).ToString() + " років";
                Y[i] = y;
                sum += y;
            }

            if (sum != 100)
                MessageBox.Show("Сума відсоткових часток по віковим групам має становити 100%. Перевірте дані", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                chart.Series[1].Points.DataBindXY(X, Y);
        }
        
    }
}
