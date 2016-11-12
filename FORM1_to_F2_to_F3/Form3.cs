using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void TextChangedDelegate(string str);
namespace FORM1_to_F2_to_F3
{
    public delegate void TextChangedDelegate(string str);
    public partial class Form3 : Form
    {
        public TextChangedDelegate TextChandegEvent2;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextChandegEvent2(textBox1.Text);
        }

        public string TextBoxText
        { 
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;    
            }
        }
    }
}
