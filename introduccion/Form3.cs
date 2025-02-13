using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduccion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "")
            {
                label1.Text = "Ingrese algum valor";
            }
            else if(textBox1.Text.Trim() =="")
            {
                label1.Text = "ingrese un valor";

            }
        }
    }
}
