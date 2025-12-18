
namespace intro_project
{
    partial class Form3
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
            this.button_Add_task = new System.Windows.Forms.Button();
            this.remove_task = new System.Windows.Forms.Button();
            this.label_are_you = new System.Windows.Forms.Label();
            this.textBox_task = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(41, 19);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(715, 71);
            this.label_smarthome_name.TabIndex = 3;
            this.label_smarthome_name.Text = "Welcom to Installation Worker";
            // 
            // checkedListBox_worker_list
            // 
            this.checkedListBox_worker_list.CheckOnClick = true;
            this.checkedListBox_worker_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_worker_list.FormattingEnabled = true;
            this.checkedListBox_worker_list.Items.AddRange(new object[] {
            "Test Installation of motion sensors for automated lighting",
            "Test Installation of temperature control systems",
            "Test Installation of security cameras and motion sensors",
            "Test Installation of  light monitoring systems",
            "Test Installation of user profile systems",
            "Verify the correct functioning of all installed systems"});
            this.checkedListBox_worker_list.Location = new System.Drawing.Point(12, 117);
            this.checkedListBox_worker_list.Name = "checkedListBox_worker_list";
            this.checkedListBox_worker_list.Size = new System.Drawing.Size(788, 190);
            this.checkedListBox_worker_list.TabIndex = 4;
            // 
            // button_Add_task
            // 
            this.button_Add_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add_task.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_task.ForeColor = System.Drawing.Color.Black;
            this.button_Add_task.Location = new System.Drawing.Point(37, 396);
            this.button_Add_task.Name = "button_Add_task";
            this.button_Add_task.Size = new System.Drawing.Size(348, 55);
            this.button_Add_task.TabIndex = 5;
            this.button_Add_task.Text = "Add task ";
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
            this.remove_task.Location = new System.Drawing.Point(473, 396);
            this.remove_task.Name = "remove_task";
            this.remove_task.Size = new System.Drawing.Size(327, 55);
            this.remove_task.TabIndex = 6;
            this.remove_task.Text = "Test task";
            this.remove_task.UseVisualStyleBackColor = false;
            this.remove_task.Click += new System.EventHandler(this.remove_task_Click);
            // 
            // label_are_you
            // 
            this.label_are_you.AutoSize = true;
            this.label_are_you.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_are_you.Location = new System.Drawing.Point(23, 340);
            this.label_are_you.Name = "label_are_you";
            this.label_are_you.Size = new System.Drawing.Size(60, 25);
            this.label_are_you.TabIndex = 12;
            this.label_are_you.Text = "Task";
            this.label_are_you.Click += new System.EventHandler(this.label_are_you_Click);
            // 
            // textBox_task
            // 
            this.textBox_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_task.Location = new System.Drawing.Point(101, 340);
            this.textBox_task.Name = "textBox_task";
            this.textBox_task.Size = new System.Drawing.Size(284, 27);
            this.textBox_task.TabIndex = 13;
            this.textBox_task.TextChanged += new System.EventHandler(this.textBox_task_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 473);
            this.Controls.Add(this.textBox_task);
            this.Controls.Add(this.label_are_you);
            this.Controls.Add(this.remove_task);
            this.Controls.Add(this.button_Add_task);
            this.Controls.Add(this.checkedListBox_worker_list);
            this.Controls.Add(this.label_smarthome_name);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
        private System.Windows.Forms.CheckedListBox checkedListBox_worker_list;
        private System.Windows.Forms.Button button_Add_task;
        private System.Windows.Forms.Button remove_task;
        private System.Windows.Forms.Label label_are_you;
        private System.Windows.Forms.TextBox textBox_task;
    }
}