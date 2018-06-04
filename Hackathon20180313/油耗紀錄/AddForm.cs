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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefuleTable refule = new RefuleTable()
            {
                Kilometer = (double)(numericUpDown2.Value),
                Liter = (double)(numericUpDown1.Value),
                RefuelingDate = dateTimePicker1.Value
            };
            try
            {
                ContactsModel contacts = new ContactsModel();
                contacts.RefuleTable.Add(refule);
                contacts.SaveChanges();
                Cleardata();
            }
            catch (Exception ex)
            { MessageBox.Show($"{ex}"); }
        }
        private void Cleardata()
        {
            numericUpDown1.Value=0.00m;
            numericUpDown2.Value = 0.00m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cleardata();
        }
    }
}
