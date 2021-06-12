using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        delegate void delegado(double valor);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread H1 = new Thread(new ThreadStart(pro1));
            H1.Start();
  
        }
        public void pro1() {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double rpta;
            rpta = a + b;
            delegado md = new delegado(mostrar);
            this.Invoke(md, new object[] { rpta });
            mostrar(rpta);
        }
        private void btresta_Click(object sender, EventArgs e)
        {
            Thread H2 = new Thread(new ThreadStart(pro2));
            H2.Start();
        }
        public void pro2()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double rpta;
            if (b > a)
            {
                rpta=b - a;
            }
            else
            {
                rpta = a - b;
            }
            delegado md = new delegado(mostrar);
            this.Invoke(md, new object[] { rpta });
            mostrar(rpta);
        }
        private void btmulti_Click(object sender, EventArgs e)
        {
            Thread H3 = new Thread(new ThreadStart(pro3));
            H3.Start();
        }
        public void pro3()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double rpta;
            rpta = a * b;
            delegado md = new delegado(mostrar);
            this.Invoke(md, new object[] { rpta });
            mostrar(rpta);
        }
        private void btdiv_Click(object sender, EventArgs e)
        {
            Thread H4 = new Thread(new ThreadStart(pro4));
            H4.Start();
        }
        public void pro4()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double rpta;
            rpta = a / b;
            delegado md = new delegado(mostrar);
            this.Invoke(md, new object[] { rpta });
            mostrar(rpta);
        }
        public void mostrar(double rpta)
        {            
            label1.Text = "" + rpta;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
