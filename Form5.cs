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
    public partial class Form5 : Form
    {
        public Form5(string data)
        {
            InitializeComponent();
            checkedListBox_worker_list.Items.Add(data);
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox_child_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox_child.Text == "Time Table")
            {
                checkedListBox_worker_list.Visible = true;
                label3.Visible = true;
                textBox_task.Visible = true;
                button_Add_task.Visible = true;
                remove_task.Visible = true;
            }
            else
            {
                panel_light.Visible = true;
                panel_tem.Visible = true;
                panel_door.Visible = true;
            }*/
        }

        private void trackBar_temp_Scroll(object sender, EventArgs e)
        {
            int val = trackBar_temp.Value;
            label_num.Text = val.ToString();
        }

        private void checkBox_for_light_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_for_light.Checked == true)
            {
                label_light.Text = "ON";
            }
            else
            {
                label_light.Text = "Off";
            }
        }

        private void checkBox_door_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_door.Checked == true)
            {
                label1.Text = "Open";
            }
            else
            {
                label1.Text = "Close";
            }
        }

        private void label_light_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_task_Click(object sender, EventArgs e)
        {
           // checkedListBox_worker_list.Items.Add(textBox_task.Text);
        }

        private void remove_task_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < checkedListBox_worker_list.Items.Count; i++)
            {
                checkedListBox_worker_list.Items.Remove(checkedListBox_worker_list.Items[i]);
            }
        }

        private void textBox_task_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_worker_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
