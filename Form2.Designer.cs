
namespace intro_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_smarthome_name = new System.Windows.Forms.Label();
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
            this.panel_camera = new System.Windows.Forms.Panel();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_camera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox_worker_list = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_task = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.remove_task = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_are_you = new System.Windows.Forms.Label();
            this.comboBox_are_you = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_tem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temp)).BeginInit();
            this.panel_light.SuspendLayout();
            this.panel_door.SuspendLayout();
            this.panel_camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(5, 27);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(561, 71);
            this.label_smarthome_name.TabIndex = 2;
            this.label_smarthome_name.Text = "Welcom to Home Admin";
            // 
            // panel_tem
            // 
            this.panel_tem.Controls.Add(this.trackBar_temp);
            this.panel_tem.Controls.Add(this.label_Current_Temperature);
            this.panel_tem.Controls.Add(this.label_change_temp);
            this.panel_tem.Controls.Add(this.label_num);
            this.panel_tem.Location = new System.Drawing.Point(7, 91);
            this.panel_tem.Name = "panel_tem";
            this.panel_tem.Size = new System.Drawing.Size(764, 113);
            this.panel_tem.TabIndex = 17;
            this.panel_tem.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_tem_Paint);
            // 
            // trackBar_temp
            // 
            this.trackBar_temp.Location = new System.Drawing.Point(259, 54);
            this.trackBar_temp.Maximum = 50;
            this.trackBar_temp.Minimum = -10;
            this.trackBar_temp.Name = "trackBar_temp";
            this.trackBar_temp.Size = new System.Drawing.Size(502, 56);
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
            this.label_num.Click += new System.EventHandler(this.label_num_Click);
            // 
            // panel_light
            // 
            this.panel_light.Controls.Add(this.label_light);
            this.panel_light.Controls.Add(this.checkBox_for_light);
            this.panel_light.Controls.Add(this.label_change_light);
            this.panel_light.Controls.Add(this.label_state_light);
            this.panel_light.Location = new System.Drawing.Point(388, 210);
            this.panel_light.Name = "panel_light";
            this.panel_light.Size = new System.Drawing.Size(380, 99);
            this.panel_light.TabIndex = 18;
            // 
            // label_light
            // 
            this.label_light.AutoSize = true;
            this.label_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_light.Location = new System.Drawing.Point(242, 12);
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
            this.checkBox_for_light.Location = new System.Drawing.Point(247, 72);
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
            this.label_change_light.Location = new System.Drawing.Point(11, 64);
            this.label_change_light.Name = "label_change_light";
            this.label_change_light.Size = new System.Drawing.Size(182, 25);
            this.label_change_light.TabIndex = 10;
            this.label_change_light.Text = "change light state";
            // 
            // label_state_light
            // 
            this.label_state_light.AutoSize = true;
            this.label_state_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state_light.Location = new System.Drawing.Point(5, 12);
            this.label_state_light.Name = "label_state_light";
            this.label_state_light.Size = new System.Drawing.Size(183, 25);
            this.label_state_light.TabIndex = 9;
            this.label_state_light.Text = "Current light state";
            // 
            // panel_door
            // 
            this.panel_door.Controls.Add(this.label1);
            this.panel_door.Controls.Add(this.checkBox_door);
            this.panel_door.Controls.Add(this.label2);
            this.panel_door.Controls.Add(this.label_door);
            this.panel_door.Location = new System.Drawing.Point(10, 210);
            this.panel_door.Name = "panel_door";
            this.panel_door.Size = new System.Drawing.Size(372, 99);
            this.panel_door.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Close";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox_door
            // 
            this.checkBox_door.AutoSize = true;
            this.checkBox_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_door.Location = new System.Drawing.Point(259, 66);
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
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "change Door state";
            // 
            // label_door
            // 
            this.label_door.AutoSize = true;
            this.label_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_door.Location = new System.Drawing.Point(7, 21);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(189, 25);
            this.label_door.TabIndex = 9;
            this.label_door.Text = "Current Door state";
            // 
            // panel_camera
            // 
            this.panel_camera.BackColor = System.Drawing.SystemColors.Control;
            this.panel_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_camera.Controls.Add(this.video);
            this.panel_camera.Location = new System.Drawing.Point(777, 12);
            this.panel_camera.Name = "panel_camera";
            this.panel_camera.Size = new System.Drawing.Size(647, 596);
            this.panel_camera.TabIndex = 20;
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(3, 3);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(641, 590);
            this.video.TabIndex = 21;
            // 
            // button_camera
            // 
            this.button_camera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_camera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_camera.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_camera.ForeColor = System.Drawing.Color.Black;
            this.button_camera.Location = new System.Drawing.Point(777, 698);
            this.button_camera.Margin = new System.Windows.Forms.Padding(1);
            this.button_camera.Name = "button_camera";
            this.button_camera.Size = new System.Drawing.Size(245, 52);
            this.button_camera.TabIndex = 22;
            this.button_camera.Text = "open ";
            this.button_camera.UseVisualStyleBackColor = false;
            this.button_camera.UseWaitCursor = true;
            this.button_camera.Click += new System.EventHandler(this.button_camera_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1199, 696);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "close ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Task to service provider";
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
            this.checkedListBox_worker_list.Location = new System.Drawing.Point(23, 420);
            this.checkedListBox_worker_list.Name = "checkedListBox_worker_list";
            this.checkedListBox_worker_list.Size = new System.Drawing.Size(418, 128);
            this.checkedListBox_worker_list.TabIndex = 26;
            this.checkedListBox_worker_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_worker_list_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Task";
            // 
            // textBox_task
            // 
            this.textBox_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_task.Location = new System.Drawing.Point(163, 376);
            this.textBox_task.Name = "textBox_task";
            this.textBox_task.Size = new System.Drawing.Size(572, 27);
            this.textBox_task.TabIndex = 29;
            this.textBox_task.TextChanged += new System.EventHandler(this.textBox_task_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(533, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Add task ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remove_task
            // 
            this.remove_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.remove_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_task.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_task.ForeColor = System.Drawing.Color.Black;
            this.remove_task.Location = new System.Drawing.Point(527, 508);
            this.remove_task.Name = "remove_task";
            this.remove_task.Size = new System.Drawing.Size(208, 40);
            this.remove_task.TabIndex = 31;
            this.remove_task.Text = "delete tasks";
            this.remove_task.UseVisualStyleBackColor = false;
            this.remove_task.Click += new System.EventHandler(this.remove_task_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(110, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(543, 40);
            this.button3.TabIndex = 32;
            this.button3.Text = "send to services provider";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_are_you
            // 
            this.label_are_you.AutoSize = true;
            this.label_are_you.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_are_you.Location = new System.Drawing.Point(775, 633);
            this.label_are_you.Name = "label_are_you";
            this.label_are_you.Size = new System.Drawing.Size(204, 25);
            this.label_are_you.TabIndex = 33;
            this.label_are_you.Text = "select camera place";
            // 
            // comboBox_are_you
            // 
            this.comboBox_are_you.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_are_you.FormattingEnabled = true;
            this.comboBox_are_you.Items.AddRange(new object[] {
            "childern",
            "kitchen",
            "bedroom",
            "living room"});
            this.comboBox_are_you.Location = new System.Drawing.Point(1015, 633);
            this.comboBox_are_you.Name = "comboBox_are_you";
            this.comboBox_are_you.Size = new System.Drawing.Size(409, 37);
            this.comboBox_are_you.TabIndex = 34;
            this.comboBox_are_you.SelectedIndexChanged += new System.EventHandler(this.comboBox_are_you_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "send compaint to company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "compaint";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 674);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 27);
            this.textBox1.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(253, 710);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "send to company";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 762);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_are_you);
            this.Controls.Add(this.label_are_you);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.remove_task);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_task);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox_worker_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_camera);
            this.Controls.Add(this.panel_camera);
            this.Controls.Add(this.panel_door);
            this.Controls.Add(this.panel_light);
            this.Controls.Add(this.panel_tem);
            this.Controls.Add(this.label_smarthome_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_tem.ResumeLayout(false);
            this.panel_tem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temp)).EndInit();
            this.panel_light.ResumeLayout(false);
            this.panel_light.PerformLayout();
            this.panel_door.ResumeLayout(false);
            this.panel_door.PerformLayout();
            this.panel_camera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
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
        private System.Windows.Forms.Panel panel_camera;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Button button_camera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox_worker_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_task;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button remove_task;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_are_you;
        private System.Windows.Forms.ComboBox comboBox_are_you;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}