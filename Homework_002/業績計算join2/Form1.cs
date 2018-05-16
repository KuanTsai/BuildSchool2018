using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 業績計算join2.Models;

namespace 業績計算join2
{
    public partial class Form1 : Form
    {
        List<SalesTable> list1 = new List<SalesTable>();
        List<ProductTable> list2 = new List<ProductTable>();

        public Form1()
        {
            InitializeComponent();
            InitialData();
            var summary = GetSummary();
            GetSalesAmount(summary);
            GetProductAmount(summary);
        }

        private void InitialData()
        {
            try
            {
                ContactsModel data = new ContactsModel();
                data.Database.ExecuteSqlCommand("truncate table [SalesTable]");
                data.Database.ExecuteSqlCommand("truncate table [ProductTable]");

                data.SaveChanges();
                data.SalesTable.Add(new SalesTable() { Salesman = "Bill", ProductItem = "原子筆", Quantity = 33 });
                data.SalesTable.Add(new SalesTable() { Salesman = "Bill", ProductItem = "鉛筆", Quantity = 32 });
                data.SalesTable.Add(new SalesTable() { Salesman = "Bill", ProductItem = "橡皮擦", Quantity = 56 });
                data.SalesTable.Add(new SalesTable() { Salesman = "Bill", ProductItem = "直尺", Quantity = 45 });
                data.SalesTable.Add(new SalesTable() { Salesman = "Bill", ProductItem = "立可白", Quantity = 33 });

                data.SalesTable.Add(new SalesTable() { Salesman = "John", ProductItem = "原子筆", Quantity = 77 });
                data.SalesTable.Add(new SalesTable() { Salesman = "John", ProductItem = "鉛筆", Quantity = 33 });
                data.SalesTable.Add(new SalesTable() { Salesman = "John", ProductItem = "橡皮擦", Quantity = 68 });
                data.SalesTable.Add(new SalesTable() { Salesman = "John", ProductItem = "直尺", Quantity = 45 });
                data.SalesTable.Add(new SalesTable() { Salesman = "John", ProductItem = "立可白", Quantity = 23 });

                data.SalesTable.Add(new SalesTable() { Salesman = "David", ProductItem = "原子筆", Quantity = 43 });
                data.SalesTable.Add(new SalesTable() { Salesman = "David", ProductItem = "鉛筆", Quantity = 55 });
                data.SalesTable.Add(new SalesTable() { Salesman = "David", ProductItem = "橡皮擦", Quantity = 43 });
                data.SalesTable.Add(new SalesTable() { Salesman = "David", ProductItem = "直尺", Quantity = 67 });
                data.SalesTable.Add(new SalesTable() { Salesman = "David", ProductItem = "立可白", Quantity = 65 });

                data.ProductTable.Add(new ProductTable() { Item = "原子筆", Price = 12 });
                data.ProductTable.Add(new ProductTable() { Item = "鉛筆", Price = 16 });
                data.ProductTable.Add(new ProductTable() { Item = "橡皮擦", Price = 10 });
                data.ProductTable.Add(new ProductTable() { Item = "直尺", Price = 14 });
                data.ProductTable.Add(new ProductTable() { Item = "立可白", Price = 15 });

                data.SaveChanges();

                list1 = data.SalesTable.ToList();
                list2 = data.ProductTable.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }

        private void GetProductAmount(List<Summary> summary)
        {
            var result = summary.GroupBy((x) => x.Item).Select((x) =>
            {
                return new { Item = x.Key, Amount = x.Sum((y) => y.Amount) };
            });

            dataGridView2.DataSource = result.ToList();
            var best = result.FirstOrDefault((x) => x.Amount == result.Max((y) => y.Amount));
            label6.Text = best.Item;
        }

        private void GetSalesAmount(List<Summary> summary)
        {
            var result = summary.GroupBy((x) => x.Salesman).Select((x) =>
            {
                return new { Salesman = x.Key, Amount = x.Sum((y) => y.Amount) };
            }
            );
            dataGridView1.DataSource = result.ToList();
            var best = result.FirstOrDefault((x) => x.Amount == result.Max((y) => y.Amount));
            label4.Text = best.Salesman;
        }

        private List<Summary> GetSummary()
        {
            var joinlist = from s in list1
                           join p in list2
                           on s.ProductItem equals p.Item
                           select new Summary
                           {
                               Item = p.Item,
                               Salesman = s.Salesman,
                               Amount = p.Price * s.Quantity
                           };

            return joinlist.ToList();
        }
    }

   
}
