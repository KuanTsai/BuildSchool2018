using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 滷味
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Money = numericUpDown1.Value * 30 + numericUpDown2.Value * 15 + numericUpDown3.Value * 15 + numericUpDown4.Value * 40;
            decimal K= Math.Floor(Money / 1000);
            decimal Ks=Money % 1000;
            decimal FH = Math.Floor(Ks / 500);
            decimal FHs = Ks % 500;
            decimal H= Math.Floor(FHs / 100);
            decimal Hs = FHs % 100;
            decimal FTen= Math.Floor(Hs / 50);
            decimal FTens = Hs % 50;
            decimal Ten= Math.Floor(FTens / 10);
            decimal Tens = FTens % 10;
            decimal F= Math.Floor(Tens / 5);
            decimal Fs = Tens % 5;
            label11.Text = $"$ 1000   {K}{Environment.NewLine}$ 500     {FH}" +
                $"{Environment.NewLine}$ 100     {H}{Environment.NewLine}$ 50       {FTen}" +
                $"{Environment.NewLine}$ 10       {Ten}{Environment.NewLine}$ 5         {F}" +
                $"{Environment.NewLine}$ 1         {Fs}";
        }

        private void nuValueChanged(object sender, EventArgs e)
        {
                textBox1.Text = $"高麗菜 {numericUpDown1.Value}份   {numericUpDown1.Value*30}元" +
                $"{Environment.NewLine}豆乾     {numericUpDown2.Value}份   {numericUpDown2.Value * 15}元" +
                $"{Environment.NewLine}海帶     {numericUpDown3.Value}份   {numericUpDown3.Value * 15}元" +
                $"{Environment.NewLine}肉片     {numericUpDown4.Value}份   {numericUpDown4.Value * 40}元" +
                $"{Environment.NewLine}總金額：{numericUpDown1.Value * 30 + numericUpDown2.Value * 15 + numericUpDown3.Value * 15 + numericUpDown4.Value * 40}元";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            decimal[] moneyclick = new decimal[] { 1000, 500, 100, 50, 10, 5, 1 };
            decimal[] pay = new decimal[7];
            decimal K = 0;
            decimal Money = numericUpDown1.Value * 30 + numericUpDown2.Value * 15 + numericUpDown3.Value * 15 + numericUpDown4.Value * 40;
            for (int i=0;i<moneyclick.Length;i++)
            {
                K = Math.Floor(Money / moneyclick[i]);
                Money = Money % moneyclick[i];
                pay[i]= K;
            }
            foreach(decimal i in pay)
            {
                    label11.Text += $"{i} {Environment.NewLine}"; 
            }
        }
    }
}
