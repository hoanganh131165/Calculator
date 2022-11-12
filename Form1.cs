using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKTPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int kq = 0;
            Calculation c = new Calculation();
            c.Calculaion(a, b);
            kq = c.Execute("+");
            lbKq.Text = kq.ToString();
            
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int kq = 0;
            Calculation c = new Calculation();
            c.Calculaion(a, b);
            kq = c.Execute("-");
            lbKq.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int kq = 0;
            Calculation c = new Calculation();
            c.Calculaion(a, b);
            kq = c.Execute("*");
            lbKq.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int kq = 0;
            Calculation c = new Calculation();
            c.Calculaion(a, b);
            kq = c.Execute("/");
            lbKq.Text = kq.ToString();
        }
    }
}
