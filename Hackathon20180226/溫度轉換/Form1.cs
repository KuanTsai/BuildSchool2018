using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 溫度轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double F,C;


        private void Check()
        {
            if(radioButton1.Checked==false)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("請輸入數字");
                }
                else
                {
                    C = double.Parse(textBox1.Text);
                    F = C * 9 / 5 + 32;
                    label1.Text = string.Format("結果：" + C + "°C" + "=" + F + "°F");
                }
            }
            else if(radioButton2.Checked==false)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("請輸入數字");
                }
                else
                {
                    F = double.Parse(textBox1.Text);
                    C = (F - 32) * 5 / 9;
                    label1.Text = string.Format("結果：" + F + "°F" + "=" + C + "°C");
                }
            }
        }
        private void button_Click(object sender, EventArgs e)//事件委派
        {
            Button button = (Button)sender;//把sender轉為button,sender是傳出去的值
            textBox1.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = ("結果：");
        }


    }
}
