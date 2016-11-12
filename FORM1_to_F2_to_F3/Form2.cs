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
    public partial class Form2 : Form
    {
        public TextChangedDelegate TextChangedEvent1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.TextBoxText = textBox1.Text;
            frm3.TextChandegEvent2 += new TextChangedDelegate(txtchanged);
            frm3.Show();
        }

        public string TextBoxText
        {
            get
            {
                return textBox1.Text;
            }
            set 
            {
                textBox1.Text=value;
            }
        }

        public void txtchanged(string val)
        {
            textBox1.Text = val;
            TextChangedEvent1(textBox1.Text);
        }

    }
}
