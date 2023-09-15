using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsHwEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Single val1, val2, val3;
            Single result1, result2,result3 , result4;
            string name = txtName.Text;
            val1 = Convert.ToSingle(txtHourRate.Text);
            val2 = Convert.ToSingle(txtTimeWorked.Text);
            val3 = Convert.ToSingle(txtOvertime.Text);
            result1 = Convert.ToSingle(val1*val2);
            result2 = val3 * val2;
            result3 = Convert.ToSingle(1.5)*result2;
            result4 = result1 + result3;
            lblResult.Text = "Sir or Miss " + name + "\n" + 
                    "Your weekly salary is " + result1 + " $ " + "\n" + 
                    "Your overtime salary is " + result3 + " $ " + "\n"+ 
                    "------------------------------------------" + "\n" + 
                    "Your total income will be " + result4+ "$";
             

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtHourRate.Text = "";
            txtName.Text = "";
            txtOvertime.Text = "";
            txtTimeWorked.Text = "";
            lblResult.Text = "";




        }
    }
}
