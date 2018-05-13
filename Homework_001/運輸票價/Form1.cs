using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 運輸票價
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SouthDownList();

        }
        string[] Array1 = new string[] { "台北", "新竹", "台中", "嘉義", "台南", "高雄" };
        int[,] price =
                { { 0, 177, 375, 598, 738, 842 },
                { 177, 0, 197, 421, 560, 755 },
                { 375, 197, 0, 224, 363, 469 },
                { 598, 421, 224, 0, 139, 245 },
                { 738, 560, 363, 139, 0, 106 },
                { 842, 755, 469, 245, 106, 0 } };

        private void button1_Click(object sender, EventArgs e)
        {
            int start, end;
            start = comboBox1.SelectedIndex;
            end = comboBox2.SelectedIndex;
            label4.Text = (price[start, end]).ToString();
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                label4.Text = Math.Ceiling(price[start, end] * 2 * 0.81).ToString();
            }
            else if (checkBox1.Checked == true)
            {
                label4.Text = Math.Ceiling(price[start, end] * 2 * 0.9).ToString();
            }
            else if (checkBox2.Checked == true)
            {
                label4.Text = Math.Ceiling(price[start, end] * 0.9).ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Refresh();
            if (radioButton1.Checked)
            {
                for (int i = comboBox1.SelectedIndex + 1; i < comboBox1.Items.Count; i++)
                { comboBox2.Items.Add(comboBox1.Items[i]); }
                comboBox2.SelectedIndex = 0;
            }
            else if (radioButton2.Checked)
            {
                for (int i = comboBox1.SelectedIndex + 1; i < comboBox1.Items.Count; i++)
                { comboBox2.Items.Add(comboBox1.Items[i]); }
                comboBox2.SelectedIndex = 0;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            comboBox2.Items.Clear();
            comboBox2.Refresh();
            if (radioButton1.Checked)
            {
                SouthDownList();
            }
            else if (radioButton2.Checked)
            {
                NorthUPList();
            }
        }

        private void SouthDownList()
        {
            for (int i = 0; i <= Array1.GetUpperBound(0); i++)
            {
                comboBox1.Items.Add(Array1[i]);
            }
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i <= Array1.GetUpperBound(0); i++)
            {
                comboBox2.Items.Add(Array1[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void NorthUPList()
        {
            for (int i = Array1.Count(); i > 0; i--)
            {
                comboBox1.Items.Add(Array1[i - 1]);
            }
            comboBox1.SelectedIndex = 0;
            for (int i = Array1.Count(); i > 0; i--)
            {
                comboBox2.Items.Add(Array1[i - 1]);
            }
            comboBox2.SelectedIndex = 0;
        }
    }
}
