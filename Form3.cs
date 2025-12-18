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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_Add_task_Click(object sender, EventArgs e)
        {
            checkedListBox_worker_list.Items.Add(textBox_task.Text);
        }

        private void remove_task_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox_worker_list.Items.Count; i++)
            {
                //checkedListBox_worker_list.Items.Remove(checkedListBox_worker_list.Items[i]);
                string task = checkedListBox_worker_list.Items[i].ToString();
                MessageBox.Show("the task of  " + task + " ::  is done");
                checkedListBox_worker_list.Items.Remove(checkedListBox_worker_list.Items[i]);
                break;
            }
        }

        private void textBox_task_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_are_you_Click(object sender, EventArgs e)
        {

        }
    }
}
