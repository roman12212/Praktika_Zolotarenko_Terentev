using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try { 
            double EP = Convert.ToDouble(txtProcent.Text) /100/ 12;
            double SumCredita = Convert.ToDouble(txtStoimostN.Text) - Convert.ToDouble(txtVznos.Text);
            double Stavka = Convert.ToDouble(txtProcent.Text);
            int Srok = Convert.ToInt32(txtSrok.Text);
            double tmp = Math.Pow((1 + EP),Srok);
            double X = Math.Round(SumCredita * EP * tmp/(tmp-1),2);
            txtEzPl.Text = Convert.ToString(X);
            }
            catch
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void txtStoimostN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| char.IsControl(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtVznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSrok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtProcent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEzPl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
