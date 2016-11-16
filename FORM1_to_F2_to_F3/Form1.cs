using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM1_to_F2_to_F3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.TextBoxText = textBox1.Text;
            frm2.TextChangedEvent1 += new TextChangedDelegate(txtchanged);
            frm2.Show();
        }

        public void txtchanged(string str)
        {
			
			
			
			
			
            textBox1.Text = str;
        }
    }
}
