
// 1. Дана строка, состоящая из групп нулей и единиц.
// Посчитать количество нулей и единиц. 

using System;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string s = (string)listBox1.Items[index];
            int zero = 0,
                one = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]) && s[i] == '0')
                {
                    zero++;
                }
                else if (char.IsNumber(s[i]) && s[i] == '1')
                {
                    one++;
                }
            }
            label1.Text = "Количество нулей = " + zero.ToString();
            label2.Text = "Количество единиц = " + one.ToString();
            label4.Text = "Всего нулей и единиц = " + (zero + one);
        }
    }
}
