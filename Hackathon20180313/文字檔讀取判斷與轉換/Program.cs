using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 文字檔讀取判斷與轉換.Models;

namespace 文字檔讀取判斷與轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactsModel contacts = new ContactsModel();
            string Filename = @"C:\Users\TSAI\Desktop\test03.txt";
            string[] Fileline = new string[] { };
            if (File.Exists(Filename))
            {
                Fileline = File.ReadAllLines(Filename);
            }
            else
            {Console.WriteLine("File does not exist.");}
            DateTime FileFlyingDay;
            DateTime FileBirthday;
            foreach(var i in Fileline)
            {
                if(i.Substring(0, 3)=="695"||i.Substring(0,3)=="525")
                {
                    DateTime.TryParse(i.Substring(13, 4) + "/" + i.Substring(17, 2) + "/" + i.Substring(19, 2), out FileFlyingDay);
                    DateTime.TryParse(i.Substring(21, 4) + "/" + i.Substring(25, 2) + "/" + i.Substring(27, 2), out FileBirthday);
                    var FileTickNumber = i.Substring(0, 13);
                    contacts.TextTable.Add(new TextTable { TickNumber = FileTickNumber, FlyingDay = FileFlyingDay, Birthday = FileBirthday });
                }
            }
            contacts.SaveChanges();
            Console.ReadLine();
        }
    }
}
