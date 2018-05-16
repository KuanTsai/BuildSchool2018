using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 運輸票價.Models;

namespace 運輸票價
{
    public partial class Form1 : Form
    {
        List<ContactsTable> list = new List<ContactsTable>();

        public Form1()
        {
            StartStation startStation = new StartStation();
            EndStation endStation = new EndStation();
            InitializeComponent();
            TicketFare();
            toSouthRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            startComboBox.SelectedIndexChanged += StartComboBox_SelectedIndexChanged;            
        }

        public void TicketFare()
        {
            try
            {
                ContactsModel contacts = new ContactsModel();
                contacts.Database.ExecuteSqlCommand("truncate table [ContactsTable]");
                contacts.SaveChanges();
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台北", EndStation = "新竹", Fare = 177 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台北", EndStation = "台中", Fare = 375 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台北", EndStation = "嘉義", Fare = 598 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台北", EndStation = "台南", Fare = 738 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台北", EndStation = "高雄", Fare = 842 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "新竹", EndStation = "台中", Fare = 197 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "新竹", EndStation = "嘉義", Fare = 421 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "新竹", EndStation = "台南", Fare = 560 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "新竹", EndStation = "高雄", Fare = 755 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台中", EndStation = "嘉義", Fare = 224 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台中", EndStation = "台南", Fare = 363 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台中", EndStation = "高雄", Fare = 469 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "嘉義", EndStation = "台南", Fare = 139 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "嘉義", EndStation = "高雄", Fare = 245 });
                contacts.ContactsTable.Add(new ContactsTable() { StartStation = "台南", EndStation = "高雄", Fare = 106 });
                contacts.SaveChanges();
                list = contacts.ContactsTable.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public class StartStation : IEqualityComparer<ContactsTable>//Distinct實作
        {
            public bool Equals(ContactsTable x, ContactsTable y)
            {
                return x.StartStation == y.StartStation;
            }

            public int GetHashCode(ContactsTable obj)
            {
                return obj.StartStation.GetHashCode();
            }
        }

        public class EndStation : IEqualityComparer<ContactsTable>
        {
            public bool Equals(ContactsTable x, ContactsTable y)
            {
                return x.EndStation == y.EndStation;
            }

            public int GetHashCode(ContactsTable obj)
            {
                return obj.EndStation.GetHashCode();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartStation startStation = new StartStation();
            EndStation endStation = new EndStation();
            if (toSouthRadioButton.Checked)
            {
                startComboBox.DataSource = list.Distinct(startStation).Select(x => x.StartStation).ToList();
            }
            else
            {
                startComboBox.DataSource = list.Distinct(endStation).Select(x => x.EndStation).ToList();
            }
        }

        private void StartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toSouthRadioButton.Checked)
            {
                string start = startComboBox.SelectedItem.ToString();
                endComboBox.DataSource = list.Where((x) => x.StartStation == start).Select((x) => x.EndStation).ToList();
            }
            else
            {
                string start = startComboBox.SelectedItem.ToString();
                endComboBox.DataSource = list.Where((x) => x.EndStation == start).Select((x) => x.StartStation).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)//計算價錢
        {
            string start, end;
            var ticketFare = new ContactsTable();
            start = startComboBox.SelectedItem.ToString();
            end = endComboBox.SelectedItem.ToString();
            if(toSouthRadioButton.Checked)
            {
                ticketFare = list.FirstOrDefault((x) => x.StartStation == start && x.EndStation == end);
            }
            else
            {
                ticketFare = list.FirstOrDefault((x) => x.StartStation == end && x.EndStation == start);
            }
            
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {

                label4.Text = Math.Ceiling(ticketFare.Fare * 2 * 0.81).ToString();
            }
            else if (checkBox1.Checked == true)
            {
                label4.Text = Math.Ceiling(ticketFare.Fare * 2 * 0.9).ToString();
            }
            else if (checkBox2.Checked == true)
            {
                label4.Text = Math.Ceiling(ticketFare.Fare * 0.9).ToString();
            }
            else
            {
                label4.Text = ticketFare.Fare.ToString();
            }
        }
    }
}
