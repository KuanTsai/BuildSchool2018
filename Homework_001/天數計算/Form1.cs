using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天數計算
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
            int Saturday = 0;
            int Sunday = 0;
            for(int month=1;month<=12;month++)
            {
                DateTime date = new DateTime(year, month, 1);
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
            MessageBox.Show("星期六 "+Saturday+" 天 , 星期天 "+Sunday+" 天");
        }
    }
}
