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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_are_you_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_ofLogin.Visible = true;
        }

        private void button_createaccount_Click(object sender, EventArgs e)
        {
            string fname = textBox_email.Text;
            MessageBox.Show("done");
        }
    }
}
