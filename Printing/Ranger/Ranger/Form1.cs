using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ranger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true && radioButton2.Checked == false)
            {

               
                for (int i = Convert.ToInt32(textBox1.Text); i < j; i++)
                {
                    richTextBox1.Text = richTextBox1.Text + i + ",";
                    i++;
                }
            }   else
                {
                for (int i = Convert.ToInt32(textBox1.Text); i < j; i++)
                {
                    richTextBox1.Text = richTextBox1.Text + i + ",";
                    i++;
                    i++;
                }
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
