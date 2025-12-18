
namespace intro_project
{
    partial class Form4
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
            this.panel_light = new System.Windows.Forms.Panel();
            this.tb = new System.Windows.Forms.TrackBar();
            this.tr = new System.Windows.Forms.TrackBar();
            this.ta = new System.Windows.Forms.TrackBar();
            this.tg = new System.Windows.Forms.TrackBar();
            this.panel_child = new System.Windows.Forms.Panel();
            this.comboBox_are_you = new System.Windows.Forms.ComboBox();
            this.label_are_you = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Add_task = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_light.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tg)).BeginInit();
            this.panel_child.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_smarthome_name
            // 
            this.label_smarthome_name.AutoSize = true;
            this.label_smarthome_name.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smarthome_name.Location = new System.Drawing.Point(127, 9);
            this.label_smarthome_name.Name = "label_smarthome_name";
            this.label_smarthome_name.Size = new System.Drawing.Size(522, 60);
            this.label_smarthome_name.TabIndex = 5;
            this.label_smarthome_name.Text = "Welcom to children section";
            this.label_smarthome_name.Click += new System.EventHandler(this.label_smarthome_name_Click);
            // 
            // panel_light
            // 
            this.panel_light.Controls.Add(this.tb);
            this.panel_light.Controls.Add(this.tr);
            this.panel_light.Controls.Add(this.ta);
            this.panel_light.Controls.Add(this.tg);
            this.panel_light.Location = new System.Drawing.Point(3, 328);
            this.panel_light.Name = "panel_light";
            this.panel_light.Size = new System.Drawing.Size(786, 240);
            this.panel_light.TabIndex = 20;
            // 
            // tb
            // 
            this.tb.AutoSize = false;
            this.tb.BackColor = System.Drawing.Color.White;
            this.tb.Location = new System.Drawing.Point(3, 190);
            this.tb.Maximum = 255;
            this.tb.Minimum = 1;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(780, 43);
            this.tb.TabIndex = 18;
            this.tb.Value = 1;
            this.tb.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tr
            // 
            this.tr.AutoSize = false;
            this.tr.BackColor = System.Drawing.Color.White;
            this.tr.Location = new System.Drawing.Point(3, 76);
            this.tr.Maximum = 255;
            this.tr.Minimum = 1;
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(780, 40);
            this.tr.TabIndex = 17;
            this.tr.Value = 1;
            this.tr.Scroll += new System.EventHandler(this.tr_Scroll);
            // 
            // ta
            // 
            this.ta.AutoSize = false;
            this.ta.BackColor = System.Drawing.Color.White;
            this.ta.Location = new System.Drawing.Point(3, 12);
            this.ta.Maximum = 255;
            this.ta.Minimum = 1;
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(780, 43);
            this.ta.TabIndex = 16;
            this.ta.Value = 1;
            this.ta.Scroll += new System.EventHandler(this.trackBar_ta_Scroll);
            // 
            // tg
            // 
            this.tg.AutoSize = false;
            this.tg.BackColor = System.Drawing.Color.White;
            this.tg.Location = new System.Drawing.Point(3, 131);
            this.tg.Maximum = 255;
            this.tg.Minimum = 1;
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(780, 42);
            this.tg.TabIndex = 15;
            this.tg.Value = 1;
            this.tg.Scroll += new System.EventHandler(this.tg_Scroll);
            // 
            // panel_child
            // 
            this.panel_child.Controls.Add(this.comboBox1);
            this.panel_child.Controls.Add(this.label1);
            this.panel_child.Controls.Add(this.comboBox_are_you);
            this.panel_child.Controls.Add(this.label_are_you);
            this.panel_child.Controls.Add(this.button3);
            this.panel_child.Controls.Add(this.button_Add_task);
            this.panel_child.Controls.Add(this.panel_light);
            this.panel_child.Controls.Add(this.label_smarthome_name);
            this.panel_child.Location = new System.Drawing.Point(3, 4);
            this.panel_child.Name = "panel_child";
            this.panel_child.Size = new System.Drawing.Size(800, 571);
            this.panel_child.TabIndex = 0;
            this.panel_child.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_child_Paint);
            // 
            // comboBox_are_you
            // 
            this.comboBox_are_you.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_are_you.FormattingEnabled = true;
            this.comboBox_are_you.Items.AddRange(new object[] {
            "a-small-miracle-132333",
            "pp",
            "whip-110235"});
            this.comboBox_are_you.Location = new System.Drawing.Point(116, 81);
            this.comboBox_are_you.Name = "comboBox_are_you";
            this.comboBox_are_you.Size = new System.Drawing.Size(285, 37);
            this.comboBox_are_you.TabIndex = 26;
            this.comboBox_are_you.SelectedIndexChanged += new System.EventHandler(this.comboBox_are_you_SelectedIndexChanged);
            // 
            // label_are_you
            // 
            this.label_are_you.AutoSize = true;
            this.label_are_you.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_are_you.Location = new System.Drawing.Point(9, 81);
            this.label_are_you.Name = "label_are_you";
            this.label_are_you.Size = new System.Drawing.Size(101, 25);
            this.label_are_you.TabIndex = 25;
            this.label_are_you.Text = "music list";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(447, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 48);
            this.button3.TabIndex = 24;
            this.button3.Text = "stop story";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Add_task
            // 
            this.button_Add_task.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add_task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add_task.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_task.ForeColor = System.Drawing.Color.Black;
            this.button_Add_task.Location = new System.Drawing.Point(447, 75);
            this.button_Add_task.Name = "button_Add_task";
            this.button_Add_task.Size = new System.Drawing.Size(342, 44);
            this.button_Add_task.TabIndex = 21;
            this.button_Add_task.Text = "stop music";
            this.button_Add_task.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Add_task.UseVisualStyleBackColor = false;
            this.button_Add_task.Click += new System.EventHandler(this.button_Add_task_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "story list";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3-011",
            "3-004",
            "3-001(1)",
            "h"});
            this.comboBox1.Location = new System.Drawing.Point(116, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 37);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 577);
            this.Controls.Add(this.panel_child);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel_light.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tg)).EndInit();
            this.panel_child.ResumeLayout(false);
            this.panel_child.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_smarthome_name;
        private System.Windows.Forms.Panel panel_light;
        private System.Windows.Forms.TrackBar tg;
        private System.Windows.Forms.Panel panel_child;
        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.TrackBar tr;
        private System.Windows.Forms.TrackBar ta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Add_task;
        private System.Windows.Forms.Label label_are_you;
        private System.Windows.Forms.ComboBox comboBox_are_you;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}