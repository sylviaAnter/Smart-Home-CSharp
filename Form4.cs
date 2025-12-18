using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace intro_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label_smarthome_name_Click(object sender, EventArgs e)
        {

        }

        private void panel_child_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void setcolor()
        {
            int a = ta.Value;
            int r = tr.Value;
            int g = tg.Value;
            int b = tb.Value;
            panel_child.BackColor = Color.FromArgb(a, r, g, b);
           // panel_music.BackColor= Color.FromArgb(a, r, g, b);
           // panel_stories.BackColor= Color.FromArgb(a, r, g, b);
           // panel_light.BackColor= Color.FromArgb(a, r, g, b);
        }
        private void trackBar_ta_Scroll(object sender, EventArgs e)
        {
            setcolor();
        }

        private void tr_Scroll(object sender, EventArgs e)
        {
            setcolor();
        }

        private void tg_Scroll(object sender, EventArgs e)
        {
            setcolor();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            setcolor();
        }

        private void comboBox_child_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if (comboBox_child.Text == "Play music")
             {
                 button1.Visible = true;
                 button_Add_task.Visible = true;
             }
             else if (comboBox_child.Text == "Play stories")
             {
                 button2.Visible = true;
                 button3.Visible = true;
             }
             else if (comboBox_child.Text == "Lights change")
             {
                 panel_light.Visible = true;
             }*/
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("mm.wav");
            sp.Play();
        }*/

        /* private void button2_Click(object sender, EventArgs e)
         {
             SoundPlayer sp = new SoundPlayer("h.wav");
             sp.Play();
         }*/

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("h.wav");
            sp.Stop();
        }

        private void button_Add_task_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stop();
        }
        private void comboBox_are_you_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_are_you.Text== "a-small-miracle-132333")
            {
                SoundPlayer sp1 = new SoundPlayer("a-small-miracle-132333.wav");
                sp1.Play();
            }
            else if (comboBox_are_you.Text == "pp")
            {
                SoundPlayer sp3 = new SoundPlayer("pp.wav");
                sp3.Play();
            }
            else
            {
                SoundPlayer sp4 = new SoundPlayer("whip-110235.wav");
                sp4.Play();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "3-011")
            {
                SoundPlayer sp1 = new SoundPlayer("3-011.wav");
                sp1.Play();
            }
            else if (comboBox1.Text == "3-001(1)")
            {
                SoundPlayer sp3 = new SoundPlayer("3-001(1).wav");
                sp3.Play();
            }
            else if (comboBox1.Text == "3-004")
            {
                SoundPlayer sp3 = new SoundPlayer("3-004.wav");
                sp3.Play();
            }
            else
            {
                SoundPlayer sp4 = new SoundPlayer("h.wav");
                sp4.Play();
            }
        }
    }
}
/*
 a-small-miracle-132333
h
intro-the-night-20928
pp
mm
whip-110235
 
 */

/*
 3-011
3-001(1)
3-004
 */