
namespace intro_project
{
    partial class Form7
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
            this.checkedListBox_worker_list = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_task = new System.Windows.Forms.TextBox();
            this.button_Add_task = new System.Windows.Forms.Button();
            this.remove_task = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_are_you = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(95, 0);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(671, 71);
            this.label_smarthome_name.TabIndex = 5;
            this.label_smarthome_name.Text = "Welcom to Companies’ admin";
            // 
            // checkedListBox_worker_list
            // 
            this.checkedListBox_worker_list.CheckOnClick = true;
            this.checkedListBox_worker_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_worker_list.FormattingEnabled = true;
            this.checkedListBox_worker_list.Items.AddRange(new object[] {
            "paula rezk",
            "omar ahmed",
            "ibrahim nehad",
            "sylvia anter"});
            this.checkedListBox_worker_list.Location = new System.Drawing.Point(12, 83);
            this.checkedListBox_worker_list.Name = "checkedListBox_worker_list";
            this.checkedListBox_worker_list.Size = new System.Drawing.Size(356, 128);
            this.checkedListBox_worker_list.TabIndex = 6;
            this.checkedListBox_worker_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_worker_list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "User";
            // 
            // textBox_task
            // 
            this.textBox_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_task.Location = new System.Drawing.Point(480, 114);
            this.textBox_task.Name = "textBox_task";
            this.textBox_task.Size = new System.Drawing.Size(369, 27);
            this.textBox_task.TabIndex = 26;
            this.textBox_task.TextChanged += new System.EventHandler(this.textBox_task_TextChanged);
            // 
            // button_Add_task
            // 
            this.button_Add_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add_task.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_task.ForeColor = System.Drawing.Color.Black;
            this.button_Add_task.Location = new System.Drawing.Point(394, 171);
            this.button_Add_task.Name = "button_Add_task";
            this.button_Add_task.Size = new System.Drawing.Size(190, 40);
            this.button_Add_task.TabIndex = 27;
            this.button_Add_task.Text = "Add User";
            this.button_Add_task.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Add_task.UseVisualStyleBackColor = false;
            this.button_Add_task.Click += new System.EventHandler(this.button_Add_task_Click);
            // 
            // remove_task
            // 
            this.remove_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.remove_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_task.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_task.ForeColor = System.Drawing.Color.Black;
            this.remove_task.Location = new System.Drawing.Point(641, 171);
            this.remove_task.Name = "remove_task";
            this.remove_task.Size = new System.Drawing.Size(208, 40);
            this.remove_task.TabIndex = 28;
            this.remove_task.Text = "Remove User";
            this.remove_task.UseVisualStyleBackColor = false;
            this.remove_task.Click += new System.EventHandler(this.remove_task_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Delivering work late.",
            "inaccuracy in deadlines.",
            "incomplete projects"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 236);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(356, 128);
            this.checkedListBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "complaint";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(527, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 27);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(394, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add  complaint";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(527, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 77);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "users needed to update system ";
            // 
            // comboBox_are_you
            // 
            this.comboBox_are_you.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_are_you.FormattingEnabled = true;
            this.comboBox_are_you.Items.AddRange(new object[] {
            "paula rezk",
            "omar ahmed",
            "ibrahim nehad",
            "sylvia anter"});
            this.comboBox_are_you.Location = new System.Drawing.Point(17, 448);
            this.comboBox_are_you.Name = "comboBox_are_you";
            this.comboBox_are_you.Size = new System.Drawing.Size(314, 37);
            this.comboBox_are_you.TabIndex = 35;
            this.comboBox_are_you.SelectedIndexChanged += new System.EventHandler(this.comboBox_are_you_SelectedIndexChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 534);
            this.Controls.Add(this.comboBox_are_you);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.remove_task);
            this.Controls.Add(this.button_Add_task);
            this.Controls.Add(this.textBox_task);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox_worker_list);
            this.Controls.Add(this.label_smarthome_name);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
        private System.Windows.Forms.CheckedListBox checkedListBox_worker_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_task;
        private System.Windows.Forms.Button button_Add_task;
        private System.Windows.Forms.Button remove_task;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_are_you;
    }
}