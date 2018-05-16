using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生命靈數
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Ans = 0;
        int Anss = 0;

        private void Brithday()
        {
            int year = dateTimePicker1.Value.Year;
            int birmounth = dateTimePicker1.Value.Month;
            int birday = dateTimePicker1.Value.Day;
            int[] mouth = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string[] constellation = { "水瓶座", "雙魚座", "牡羊座", "金牛座", "雙子座", "巨蟹座", "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "摩羯座" };
            foreach (var i in mouth)
            {
                if (birmounth - i == 0)
                {
                    if (birmounth == 1)
                    {
                        if (birday >= 21)
                        {
                            label3.Text = "你的星座為：" + constellation[0];
                        }
                        else if (birday < 21)
                        {
                            label3.Text = "你的星座為：" + constellation[11];
                        }
                    }
                    else
                    {
                        if (birday >= 21)
                        {
                            label3.Text = "你的星座為：" + constellation[i - 1];
                        }
                        else if (birday < 21)
                        {
                            label3.Text = "你的星座為：" + constellation[i - 2];
                        }
                    }
                }
            }
        }
        private void Lifesoul()
        {

            string soul = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
            foreach (var i in soul)
            {
                Ans += int.Parse(i.ToString());
            }
            while (Ans > 9)
            {
                foreach (var o in Ans.ToString())
                {
                    Anss += int.Parse(o.ToString());
      
                }
                Ans = Anss;
            }
        }
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        private void Soul()
        {
            switch(label3.Text)
            {
                case "你的星座為：水瓶座":
                    dictionary = Dic.CreateAquarius();                    
                    break;
                case "你的星座為：雙魚座":
                    dictionary = Dic.CreatePieces();                   
                    break;
                case "你的星座為：牡羊座":
                    dictionary = Dic.CreateAries();                   
                    break;
                case "你的星座為：金牛座":
                    dictionary = Dic.CreateTaurus();                    
                    break;
                case "你的星座為：雙子座":
                    dictionary = Dic.CreateGemini();                    
                    break;
                case "你的星座為：巨蟹座":
                    dictionary = Dic.CreateCancer();                   
                    break;
                case "你的星座為：獅子座":
                    dictionary = Dic.CreateLeo();                    
                    break;
                case "你的星座為：處女座":
                    dictionary = Dic.CreateVirgo();                    
                    break;
                case "你的星座為：天秤座":
                    dictionary = Dic.CreateLibra();                    
                    break;
                case "你的星座為：天蠍座":
                    dictionary = Dic.CreateScorpio();                    
                    break;
                case "你的星座為：射手座":
                    dictionary = Dic.CreateSagittarius();                  
                    break;
                case "你的星座為：魔羯座":
                    dictionary = Dic.CreateCapricorn();
                    break;
            }
            label4.Text = "你的生命靈數："+Anss+ "\r\n" + dictionary[Anss];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ans = 0;
            Anss = 0;
            Brithday();
            Lifesoul();
            Soul();
           
        }
    }
}
