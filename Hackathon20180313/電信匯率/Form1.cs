using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電信匯率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"通話時間 : {dateTimePicker1.Text}";
            
            TimeSpan i = dateTimePicker4.Value - dateTimePicker1.Value;
            int min = (int)(i.TotalMinutes);
            decimal  A= 0,B=0,C=0;
            A = min * 4 + 350;
            B = min * 3 + 400;
            C = min * 2 + 500;
            if(A<B&&A<C)
            {
                label2.Text = $"電信 : 中華電信   為最省";
                label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {A} 元";
            }
            else if(B<A&&B<C)
            {
                label2.Text = $"電信 : 遠傳電信   為最省";
                label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {B} 元";
            }
            else if(C<A&&C<B)
            {
                label2.Text = $"電信 : 台灣大哥大   為最省";
                label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {C} 元";
            }
            else
            {
                if(A==B)
                {
                    label2.Text = $"電信 : 中華電信與遠傳電信   同為最省";
                    label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {A} 元";
                }
                else if(A==C)
                {
                    label2.Text = $"電信 : 中華電信與台灣大哥大   同為最省";
                    label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {A} 元";
                }
                else if(B==C)
                {
                    label2.Text = $"電信 : 遠傳電信與台灣大哥大   同為最省";
                    label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {C} 元";
                }
                else
                {
                    label2.Text = $"電信 : 全部一樣省";
                    label3.Text = $"{i.Days}天{i.Hours}小時{i.Minutes}分鐘  總金額 : {C} 元";
                }
            }
            
        }

    }
}
