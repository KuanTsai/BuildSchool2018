using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 油耗紀錄.Models;

namespace 油耗紀錄
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData(); 
        }

        private void BindData()
        {
            var contacts = new ContactsModel();
            var list = contacts.RefuleTable.ToList();
            DateTime A = dateTimePicker1.Value;
            DateTime B = dateTimePicker2.Value;
            List<RefuleTable> findlist = new List<RefuleTable>();
            foreach (var i in list)
            {
                if (A <= i.RefuelingDate && B >= i.RefuelingDate)
                {
                    findlist.Add(i);
                }
            }
            dataGridView1.DataSource = findlist.ToList();
            label4.Text = $"{findlist.Max((x) => x.Kilometer) / findlist.Max((x) => x.Liter) - findlist.Min((x) => x.Liter)}";
        }
    }
}
