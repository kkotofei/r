using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsЗCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      //  public static int[] array;
      //  public static int n;
      //  public static int k;
        Class1 class1;
        Class2 class2;

        private void button1_Click(object sender, EventArgs e)
        {
            //k = Int32.Parse(textBox1.Text);
            class1 = new Class1(Convert.ToInt32(textBox1.Text));
            class2= new Class2(Convert.ToInt32(textBox1.Text));
            textBox2.Text = class1.Method1();
            textBox2.Text = class2.Methodf();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // n = Int32.Parse(textBox1.Text);
            class1 = new Class1(Convert.ToInt32(textBox1.Text));
            class2= new Class2(Convert.ToInt32(textBox1.Text));
            textBox4.Text = class1.Method1(Convert.ToInt32(textBox3.Text));
            textBox4.Text = class2.Method1(Convert.ToInt32(textBox3.Text));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = class2[Convert.ToInt32(textBox5.Text)].ToString();
        }
    }
}
