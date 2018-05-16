using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字遊戲
{
    public partial class Form1 : Form
    {
        private List<string> _list;
        private List<string> anslist = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateList()
        {
            _list = new List<string>();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                _list.Add(random.Next(0, 9).ToString());
                for (int j = 0; j < i; j++)
                {
                    while (_list[i] == _list[j])
                    {
                        j = 0;
                        _list.Add(random.Next(0, 9).ToString());
                    }
                }
            }
        }
        private void Data()
        {
            string Ans = textBox1.Text;
            int list_index;
            int Input_index;
            int A = 0;
            int B = 0;
            foreach (var i in Ans)
            {
                Input_index = Ans.IndexOf(i.ToString());
                foreach (var o in _list)
                {
                    if(o==i.ToString())
                    {
                        list_index=_list.IndexOf(o);
                        if(Input_index==list_index)
                        {
                            A = A + 1;
                        }
                        else
                        {
                            B = B + 1;
                        }
                    }
                }
            }
            anslist.Add(Ans+"A=" + A + ",B=" + B);
            listBox1.DataSource = null;
            listBox1.DataSource = anslist;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Ans = textBox1.Text;
            if(textBox1.TextLength != 4)
            {
                MessageBox.Show("請輸入四個不重複的數字");
            }
            else
            { Data(); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_list==null)
            {
                MessageBox.Show("請按開始遊戲");
            }
            else
            {
                MessageBox.Show(_list[0] + _list[1] + _list[2] + _list[3]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateList();
        }
    }
}
