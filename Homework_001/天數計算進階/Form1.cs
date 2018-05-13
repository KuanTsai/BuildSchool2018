using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天數計算進階
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text.ToString());
            int nyear = year + 1911;
            int Saturday = 0;
            int Sunday = 0;
            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(nyear, month, 1);
                do
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        Saturday++;
                    }
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Sunday++;
                    }
                    date = date.AddDays(1);
                } while (date.Month == month);
            }
            label1.Text = string.Format("民國{0}年,西元{1}年", year, nyear);
            label2.Text = string.Format("星期六有{0}天,星期日{1}天", Saturday, Sunday);
        }
    }
}
