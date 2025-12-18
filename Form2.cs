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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox_adminHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*     if (comboBox_adminHome.Text == "Temperature Setting")
              {
                  panel_tem.Visible = true;
              }
              else if (comboBox_adminHome.Text == "Light Setting")
              {
                  panel_light.Visible = true;
              }
              else if (comboBox_adminHome.Text == "Door Setting")
              {
                  panel_door.Visible = true;
              }
              else if (comboBox_adminHome.Text == "camera setting")
              {
                  panel_camera.Visible = true;
              }
            */
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_light_Click(object sender, EventArgs e)
        {

        }

        private void button_camera_Click(object sender, EventArgs e)
        {
            if (comboBox_are_you.Text == "bedroom")
            {
                video.URL = "Hidden Camera Bedroom.wmv";
                video.Ctlcontrols.play();
            }
            else if (comboBox_are_you.Text == "childern")
            {
                video.URL = "childern.wmv";
                video.Ctlcontrols.play();
            }
            else if (comboBox_are_you.Text == "kitchen")
            {
                video.URL = "Hidden Camera in Kitchen.wmv";
                video.Ctlcontrols.play();
            }
            else
            {
                video.URL = "sa.wmv";
                video.Ctlcontrols.play();
            }
        }

        private void label_num_Click(object sender, EventArgs e)
        {

        }

        private void panel_tem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // video.URL = "sa.wmv";
            video.Ctlcontrols.pause();
        }

        private void textBox_task_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox_worker_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_task_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < checkedListBox_worker_list.Items.Count; i++)
            {
                checkedListBox_worker_list.Items.Remove(checkedListBox_worker_list.Items[i]);
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox_worker_list.Items.Add(textBox_task.Text);
        }
       // Form5 form5 = new Form5();
        //Form7 form7 = new Form7();
        private void button3_Click(object sender, EventArgs e)
        {

            string data = textBox_task.Text;
            Form5 form5 = new Form5(data);
            form5.Show();
            this.Hide();
        }

        private void comboBox_are_you_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string data = textBox1.Text; 
            Form7 form7 = new Form7(data);
            form7.Show();

        }
    }
}
