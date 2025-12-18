using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro_project
{
    public partial class Form7 : Form
    {
        public Form7(string data)
        {
            InitializeComponent();
            checkedListBox1.Items.Add(data);
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox_are_you_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name_user = comboBox_are_you.Text;
            MessageBox.Show("update the system of " + name_user);
        }

        private void button_Add_task_Click(object sender, EventArgs e)
        {
            checkedListBox_worker_list.Items.Add(textBox_task.Text);
        }

        private void remove_task_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < checkedListBox_worker_list.Items.Count; i++)
            {
                checkedListBox_worker_list.Items.Remove(checkedListBox_worker_list.Items[i]);
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }

        private void textBox_task_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_worker_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
