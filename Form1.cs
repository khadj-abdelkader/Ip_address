using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ip_address
{
    public partial class Form1 : Form
     
    {
        public Form1()
        
        {
            InitializeComponent();
        }

        public object When { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {       
                var ip1 = Convert.ToString(Decimal.ToInt32(numericUpDown1.Value), 2);
                var ip2 = Convert.ToString(Decimal.ToInt32(numericUpDown2.Value), 2);
                var ip3 = Convert.ToString(Decimal.ToInt32(numericUpDown3.Value), 2);
                var ip4 = Convert.ToString(Decimal.ToInt32(numericUpDown4.Value), 2);
                for (var i1 = ip1.Length; i1 < 8; i1++)
                {
                    ip1 = "0" + ip1;
                }
                for (var i2 = ip2.Length; i2 < 8; i2++)
                {
                    ip2 = "0" + ip2;
                }
                for (var i3 = ip3.Length; i3 < 8; i3++)
                {
                    ip3 = "0" + ip3;
                }
                for (var i4 = ip4.Length; i4 < 8; i4++)
                {
                    ip4 = "0" + ip4;
                }
            textBox1.Text = ip1 + " " + ip2 + " " + ip3 + " " + ip4;

            var ip5= Convert.ToString(Decimal.ToInt32(numericUpDown5.Value), 2);
            var ip6= Convert.ToString(Decimal.ToInt32(numericUpDown6.Value), 2);
            var ip7= Convert.ToString(Decimal.ToInt32(numericUpDown7.Value), 2);
            var ip8= Convert.ToString(Decimal.ToInt32(numericUpDown8.Value), 2);
            for (var i5 = ip5.Length; i5 < 8; i5++)
            {
                ip5 = "0" + ip5;
            }
            for (var i6 = ip6.Length; i6 < 8; i6++)
            {
                ip6 = "0" + ip6;
            }
            for (var i7 = ip7.Length; i7 < 8; i7++)
            {
                ip7 = "0" + ip7;
            }
            for (var i8 = ip8.Length; i8 < 8; i8++)
            {
                ip8 = "0" + ip8;
            }
            textBox2.Text = ip5 + " " + ip6 + " " + ip7 + " " + ip8;

            numericUpDown9.Value = Decimal.ToInt32(numericUpDown1.Value) & Decimal.ToInt32(numericUpDown5.Value);
            numericUpDown10.Value = Decimal.ToInt32(numericUpDown2.Value) & Decimal.ToInt32(numericUpDown6.Value);
            numericUpDown11.Value = Decimal.ToInt32(numericUpDown3.Value) & Decimal.ToInt32(numericUpDown7.Value);
            numericUpDown12.Value = Decimal.ToInt32(numericUpDown4.Value) & Decimal.ToInt32(numericUpDown8.Value);
        }
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
