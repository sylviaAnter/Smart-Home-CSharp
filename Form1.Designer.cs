
namespace intro_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_smarthome_name = new System.Windows.Forms.Label();
            this.comboBox_are_you = new System.Windows.Forms.ComboBox();
            this.label_are_you = new System.Windows.Forms.Label();
            this.panel_ofLogin = new System.Windows.Forms.Panel();
            this.button_createaccount = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_forget = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.panel_ofLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(138, 24);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(578, 71);
            this.label_smarthome_name.TabIndex = 1;
            this.label_smarthome_name.Text = "Welcome To Smart Home";
            // 
            // comboBox_are_you
            // 
            this.comboBox_are_you.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_are_you.FormattingEnabled = true;
            this.comboBox_are_you.Items.AddRange(new object[] {
            "Home Admin",
            "Installation Worker",
            "Child",
            "Service Provider ",
            "Companies’ admin"});
            this.comboBox_are_you.Location = new System.Drawing.Point(315, 126);
            this.comboBox_are_you.Name = "comboBox_are_you";
            this.comboBox_are_you.Size = new System.Drawing.Size(378, 37);
            this.comboBox_are_you.TabIndex = 10;
            this.comboBox_are_you.SelectedIndexChanged += new System.EventHandler(this.comboBox_are_you_SelectedIndexChanged);
            // 
            // label_are_you
            // 
            this.label_are_you.AutoSize = true;
            this.label_are_you.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_are_you.Location = new System.Drawing.Point(125, 126);
            this.label_are_you.Name = "label_are_you";
            this.label_are_you.Size = new System.Drawing.Size(102, 25);
            this.label_are_you.TabIndex = 11;
            this.label_are_you.Text = "are you ?";
            // 
            // panel_ofLogin
            // 
            this.panel_ofLogin.Controls.Add(this.button_createaccount);
            this.panel_ofLogin.Controls.Add(this.textBox_email);
            this.panel_ofLogin.Controls.Add(this.label_name);
            this.panel_ofLogin.Controls.Add(this.textBox_pass);
            this.panel_ofLogin.Controls.Add(this.label_forget);
            this.panel_ofLogin.Controls.Add(this.label_pass);
            this.panel_ofLogin.Controls.Add(this.button_login);
            this.panel_ofLogin.Location = new System.Drawing.Point(37, 258);
            this.panel_ofLogin.Name = "panel_ofLogin";
            this.panel_ofLogin.Size = new System.Drawing.Size(780, 220);
            this.panel_ofLogin.TabIndex = 12;
            this.panel_ofLogin.Visible = false;
            this.panel_ofLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ofLogin_Paint);
            // 
            // button_createaccount
            // 
            this.button_createaccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_createaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_createaccount.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createaccount.ForeColor = System.Drawing.Color.Black;
            this.button_createaccount.Location = new System.Drawing.Point(457, 86);
            this.button_createaccount.Margin = new System.Windows.Forms.Padding(1);
            this.button_createaccount.Name = "button_createaccount";
            this.button_createaccount.Size = new System.Drawing.Size(306, 62);
            this.button_createaccount.TabIndex = 9;
            this.button_createaccount.Text = "Create New Account";
            this.button_createaccount.UseVisualStyleBackColor = false;
            this.button_createaccount.UseWaitCursor = true;
            this.button_createaccount.Click += new System.EventHandler(this.button_createaccount_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(133, 24);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(284, 27);
            this.textBox_email.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(20, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(68, 25);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Name";
            // 
            // textBox_pass
            // 
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(133, 69);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(284, 27);
            this.textBox_pass.TabIndex = 6;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // label_forget
            // 
            this.label_forget.AutoSize = true;
            this.label_forget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forget.ForeColor = System.Drawing.Color.Blue;
            this.label_forget.Location = new System.Drawing.Point(147, 187);
            this.label_forget.Name = "label_forget";
            this.label_forget.Size = new System.Drawing.Size(149, 18);
            this.label_forget.TabIndex = 4;
            this.label_forget.Text = "Forgotten password?";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(11, 71);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(104, 25);
            this.label_pass.TabIndex = 8;
            this.label_pass.Text = "password";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(16, 137);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(401, 35);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 490);
            this.Controls.Add(this.panel_ofLogin);
            this.Controls.Add(this.label_are_you);
            this.Controls.Add(this.comboBox_are_you);
            this.Controls.Add(this.label_smarthome_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_ofLogin.ResumeLayout(false);
            this.panel_ofLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
        private System.Windows.Forms.ComboBox comboBox_are_you;
        private System.Windows.Forms.Label label_are_you;
        private System.Windows.Forms.Panel panel_ofLogin;
        private System.Windows.Forms.Button button_createaccount;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_forget;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button button_login;
    }
}

