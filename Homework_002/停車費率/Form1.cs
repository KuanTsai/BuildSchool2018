using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 停車費率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"進場時間 : {dateTimePicker1.Text}";
            label2.Text = $"離開時間 : {dateTimePicker4.Text}";
            TimeSpan i = dateTimePicker4.Value - dateTimePicker1.Value;
            int min = (int)(i.TotalMinutes);
            decimal K = 0;
            if(min < 120)
            {
                K =decimal.Floor(min / 30) * 30;
            }
            else if(min >= 240)
            {
                K = decimal.Floor(min / 30) * 60;
            }
            else
            {
                K = decimal.Floor(min / 30) * 40;
            }
            label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {K} 元";
        }
    }
}
