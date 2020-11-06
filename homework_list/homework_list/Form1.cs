using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
                {
                String count = listBox1.Items.Count.ToString();
                int c = Int32.Parse(count);
                c++;
                String count1 = Convert.ToString(c);
                listBox1.Items.Add(count1 + ". " + textBox1.Text);
                textBox1.Text = "";
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Write a task on the blanked bar");
            }
        }

        private void textBox1_click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void startNewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mark the line that you want to change then press Change");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mark the line that you want to delete then press Clear");
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Whrite a task in the in the box then press Edit");
        }
    }
}
