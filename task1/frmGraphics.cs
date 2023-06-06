using System;
using System.Windows.Forms;

namespace task1
{
    public partial class frmGraphics : Form
    {
        public frmGraphics()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(var s in chart.Series)
                s.Points.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            double Xmin, Xmax, step;

            if (!ToDouble(txtXmin, out Xmin) ||
                    !ToDouble(txtXmax, out Xmax) ||
                    !ToDouble(txtStep, out step))
                return;

            if (Xmax <= Xmin)
            {
                MessageBox.Show("Значення Xmin має бути менше значення Xmax", "Помилка введення!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (step <= 0)
            {
                MessageBox.Show("Крок не бути меншим за нуль", "Помилка введення!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = (int)Math.Ceiling((Xmax - Xmin) / step + 1);
            double[] x = new double[count];
            double[][] y = new double[5][];
            for (int i = 0; i < 5; i++)
                y[i] = new double[count];

            if (cbFunc.SelectedIndex == -1)
                txtData.Text = "Графік не обрано";

            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + step * i;
                y[0][i] = Math.Sin(x[i]);
                y[1][i] = Math.Cos(x[i]);
                y[2][i] = Math.Cos(x[i]) + 2 * x[i];
                y[3][i] = Math.Sqrt(x[i]);
                y[4][i] = Math.Pow(x[i], 2) + x[i] + 4;

                if (cbFunc.SelectedIndex != -1)
                    txtData.Text += "x[" + i.ToString() + "] = " + Math.Round(x[i], 3).ToString() + ",   " +
                        "y[" + i.ToString() + "] = " + Math.Round(y[cbFunc.SelectedIndex][i], 3).ToString() +
                        Environment.NewLine;
            }

            chart.ChartAreas[0].AxisX.Minimum = Xmin;
            chart.ChartAreas[0].AxisX.Maximum = Xmax;
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            
            for (int i = 0;i < 5;i++)
            {
                if ( ((CheckBox)groupBox2.Controls["chkFunc" + i.ToString()]).Checked )
                    chart.Series[i].Points.DataBindXY(x, y[i]);
            }
        }

        private bool ToDouble(TextBox txt, out double x)
        {
            x = 0;

            if (txt.Text == "")
            {
                MessageBox.Show("Не заповнено поле " + groupBox1.Controls["lbl_" + txt.Name].Text, "Помилка введення!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txt.Text, out x))
            {
                MessageBox.Show("В полі " + groupBox1.Controls["lbl_" + txt.Name].Text + " введено некоректі дані", "Помилка введення!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
