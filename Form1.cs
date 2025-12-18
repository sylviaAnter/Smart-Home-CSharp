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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_are_you_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_ofLogin.Visible = true;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            Form7 form7 = new Form7();
          //  Form6 form6 = new Form6();
            if (comboBox_are_you.Text == "Home Admin")
            {
                //this.Hide();
                form2.Show();
            }
            else if (comboBox_are_you.Text == "Installation Worker")
            {
               // this.Hide();
                form3.Show();
            }
            else if (comboBox_are_you.Text == "Child")
            {
                //this.Hide();
                form4.Show();
            }
            else if(comboBox_are_you.Text== "Companies’ admin")
            {
                form7.Show();
            }
            else 
            {
               // this.Hide();
                form5.Show();
            }
          
        }

        private void button_createaccount_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
           // this.Hide();
            form6.Show();
        }

        private void panel_ofLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
