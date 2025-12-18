
namespace intro_project
{
    partial class Form5
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
            this.panel_tem = new System.Windows.Forms.Panel();
            this.trackBar_temp = new System.Windows.Forms.TrackBar();
            this.label_Current_Temperature = new System.Windows.Forms.Label();
            this.label_change_temp = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.panel_light = new System.Windows.Forms.Panel();
            this.label_light = new System.Windows.Forms.Label();
            this.checkBox_for_light = new System.Windows.Forms.CheckBox();
            this.label_change_light = new System.Windows.Forms.Label();
            this.label_state_light = new System.Windows.Forms.Label();
            this.panel_door = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_door = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_door = new System.Windows.Forms.Label();
            this.panel_tem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temp)).BeginInit();
            this.panel_light.SuspendLayout();
            this.panel_door.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(82, 6);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(642, 71);
            this.label_smarthome_name.TabIndex = 4;
            this.label_smarthome_name.Text = "Welcom to Service Provider ";
            // 
            // checkedListBox_worker_list
            // 
            this.checkedListBox_worker_list.CheckOnClick = true;
            this.checkedListBox_worker_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_worker_list.FormattingEnabled = true;
            this.checkedListBox_worker_list.Items.AddRange(new object[] {
            "Watering the plants",
            "clothes washing",
            "food preparation",
            "House cleaning"});
            this.checkedListBox_worker_list.Location = new System.Drawing.Point(0, 103);
            this.checkedListBox_worker_list.Name = "checkedListBox_worker_list";
            this.checkedListBox_worker_list.Size = new System.Drawing.Size(793, 128);
            this.checkedListBox_worker_list.TabIndex = 5;
            this.checkedListBox_worker_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_worker_list_SelectedIndexChanged);
            // 
            // panel_tem
            // 
            this.panel_tem.Controls.Add(this.trackBar_temp);
            this.panel_tem.Controls.Add(this.label_Current_Temperature);
            this.panel_tem.Controls.Add(this.label_change_temp);
            this.panel_tem.Controls.Add(this.label_num);
            this.panel_tem.Location = new System.Drawing.Point(0, 268);
            this.panel_tem.Name = "panel_tem";
            this.panel_tem.Size = new System.Drawing.Size(793, 128);
            this.panel_tem.TabIndex = 19;
            // 
            // trackBar_temp
            // 
            this.trackBar_temp.Location = new System.Drawing.Point(262, 59);
            this.trackBar_temp.Maximum = 50;
            this.trackBar_temp.Minimum = -10;
            this.trackBar_temp.Name = "trackBar_temp";
            this.trackBar_temp.Size = new System.Drawing.Size(515, 56);
            this.trackBar_temp.TabIndex = 12;
            this.trackBar_temp.Scroll += new System.EventHandler(this.trackBar_temp_Scroll);
            // 
            // label_Current_Temperature
            // 
            this.label_Current_Temperature.AutoSize = true;
            this.label_Current_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Current_Temperature.Location = new System.Drawing.Point(3, 12);
            this.label_Current_Temperature.Name = "label_Current_Temperature";
            this.label_Current_Temperature.Size = new System.Drawing.Size(213, 25);
            this.label_Current_Temperature.TabIndex = 9;
            this.label_Current_Temperature.Text = "Current Temperature";
            // 
            // label_change_temp
            // 
            this.label_change_temp.AutoSize = true;
            this.label_change_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_change_temp.Location = new System.Drawing.Point(8, 73);
            this.label_change_temp.Name = "label_change_temp";
            this.label_change_temp.Size = new System.Drawing.Size(217, 25);
            this.label_change_temp.TabIndex = 11;
            this.label_change_temp.Text = "Change Temperature";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num.Location = new System.Drawing.Point(270, 12);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(44, 25);
            this.label_num.TabIndex = 10;
            this.label_num.Text = "15`";
            // 
            // panel_light
            // 
            this.panel_light.Controls.Add(this.label_light);
            this.panel_light.Controls.Add(this.checkBox_for_light);
            this.panel_light.Controls.Add(this.label_change_light);
            this.panel_light.Controls.Add(this.label_state_light);
            this.panel_light.Location = new System.Drawing.Point(0, 402);
            this.panel_light.Name = "panel_light";
            this.panel_light.Size = new System.Drawing.Size(382, 199);
            this.panel_light.TabIndex = 20;
            // 
            // label_light
            // 
            this.label_light.AutoSize = true;
            this.label_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_light.Location = new System.Drawing.Point(315, 21);
            this.label_light.Name = "label_light";
            this.label_light.Size = new System.Drawing.Size(41, 25);
            this.label_light.TabIndex = 12;
            this.label_light.Text = "Off";
            this.label_light.Click += new System.EventHandler(this.label_light_Click);
            // 
            // checkBox_for_light
            // 
            this.checkBox_for_light.AutoSize = true;
            this.checkBox_for_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_for_light.Location = new System.Drawing.Point(338, 117);
            this.checkBox_for_light.Name = "checkBox_for_light";
            this.checkBox_for_light.Size = new System.Drawing.Size(18, 17);
            this.checkBox_for_light.TabIndex = 11;
            this.checkBox_for_light.UseVisualStyleBackColor = true;
            this.checkBox_for_light.CheckedChanged += new System.EventHandler(this.checkBox_for_light_CheckedChanged);
            // 
            // label_change_light
            // 
            this.label_change_light.AutoSize = true;
            this.label_change_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_change_light.Location = new System.Drawing.Point(3, 109);
            this.label_change_light.Name = "label_change_light";
            this.label_change_light.Size = new System.Drawing.Size(231, 25);
            this.label_change_light.TabIndex = 10;
            this.label_change_light.Text = "washing machine state";
            // 
            // label_state_light
            // 
            this.label_state_light.AutoSize = true;
            this.label_state_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state_light.Location = new System.Drawing.Point(7, 21);
            this.label_state_light.Name = "label_state_light";
            this.label_state_light.Size = new System.Drawing.Size(231, 25);
            this.label_state_light.TabIndex = 9;
            this.label_state_light.Text = "washing machine state";
            // 
            // panel_door
            // 
            this.panel_door.Controls.Add(this.label1);
            this.panel_door.Controls.Add(this.checkBox_door);
            this.panel_door.Controls.Add(this.label2);
            this.panel_door.Controls.Add(this.label_door);
            this.panel_door.Location = new System.Drawing.Point(388, 402);
            this.panel_door.Name = "panel_door";
            this.panel_door.Size = new System.Drawing.Size(412, 199);
            this.panel_door.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Close";
            // 
            // checkBox_door
            // 
            this.checkBox_door.AutoSize = true;
            this.checkBox_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_door.Location = new System.Drawing.Point(371, 109);
            this.checkBox_door.Name = "checkBox_door";
            this.checkBox_door.Size = new System.Drawing.Size(18, 17);
            this.checkBox_door.TabIndex = 11;
            this.checkBox_door.UseVisualStyleBackColor = true;
            this.checkBox_door.CheckedChanged += new System.EventHandler(this.checkBox_door_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Smart vacuum state";
            // 
            // label_door
            // 
            this.label_door.AutoSize = true;
            this.label_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_door.Location = new System.Drawing.Point(7, 21);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(203, 25);
            this.label_door.TabIndex = 9;
            this.label_door.Text = "Smart vacuum state";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 613);
            this.Controls.Add(this.panel_door);
            this.Controls.Add(this.panel_light);
            this.Controls.Add(this.panel_tem);
            this.Controls.Add(this.checkedListBox_worker_list);
            this.Controls.Add(this.label_smarthome_name);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel_tem.ResumeLayout(false);
            this.panel_tem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temp)).EndInit();
            this.panel_light.ResumeLayout(false);
            this.panel_light.PerformLayout();
            this.panel_door.ResumeLayout(false);
            this.panel_door.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
        private System.Windows.Forms.CheckedListBox checkedListBox_worker_list;
        private System.Windows.Forms.Panel panel_tem;
        private System.Windows.Forms.TrackBar trackBar_temp;
        private System.Windows.Forms.Label label_Current_Temperature;
        private System.Windows.Forms.Label label_change_temp;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Panel panel_light;
        private System.Windows.Forms.Label label_light;
        private System.Windows.Forms.CheckBox checkBox_for_light;
        private System.Windows.Forms.Label label_change_light;
        private System.Windows.Forms.Label label_state_light;
        private System.Windows.Forms.Panel panel_door;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_door;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_door;
    }
}