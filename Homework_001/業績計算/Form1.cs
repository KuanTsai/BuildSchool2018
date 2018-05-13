using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 業績計算
{
    public partial class Form1 : Form
    {
        private List<Salemen> _list;
        private List<Products> list;
        public Form1()
        {
            InitializeComponent();
            CreateData();
            CreateData2();
            dataGridView1.DataSource = _list;
            dataGridView2.DataSource = list;
            var ONE = _list.Where((y) => y.SUM == _list.Max((x) => x.SUM));
            var Two = list.Where((x) => x.SUM2 == list.Max((y) => y.SUM2));
            foreach(var A in ONE)
            {
                label3.Text = string.Format(A.Saleman);
            }
            foreach (var B in Two)
            {
                label4.Text = string.Format(B.Product);
            }
        }
        private void CreateData()
        {
            _list = new List<Salemen>();
            _list.Add(new Salemen { Saleman = "Bill", P = 33, PS = 32, ER = 56, RU = 45, LIC = 33 });
            _list.Add(new Salemen { Saleman = "John", P = 77, PS = 33, ER = 68, RU = 45, LIC = 23 });
            _list.Add(new Salemen { Saleman = "David", P = 43, PS = 55, ER = 43, RU = 67, LIC = 65 });

        }
        private void CreateData2()
        {
            list = new List<Products>();
            list.Add(new Products { Product = "原子筆", Price = 12, Quantity = 153 });
            list.Add(new Products { Product = "鉛筆", Price = 16, Quantity = 120 });
            list.Add(new Products { Product = "橡皮擦", Price = 10, Quantity = 167 });
            list.Add(new Products { Product = "直尺", Price = 14, Quantity = 157 });
            list.Add(new Products { Product = "立可白", Price = 15, Quantity = 121 });
        }
        
    }
}
