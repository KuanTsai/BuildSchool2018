using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串替換
{
    class Program
    {
        static string[] dataArray = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        //把數字對應的漢字存入數組中,這樣能利用index索引叫出對應字 >> dataArray[0]="零"
        static void Main(string[] args)
        {
            Console.Write("請輸入阿拉伯數字 : ");
            string i = Console.ReadLine();
            for(int o=0;o<i.Length;o++)
            //使用循環把字串裡面數字一一取出來轉換
            {
                int item = 0;//需要一個臨時變數
                if(int.TryParse(i.Substring(o,1),out item))
                //將取出字串轉乘數字       //從i的o位置取長度1的字串
                {
                    Console.Write(dataArray[item]);
                    //輸出對應中文字
                }
            }
            Console.ReadLine();
        }
    }
}
