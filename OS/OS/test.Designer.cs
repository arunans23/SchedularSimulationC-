namespace OS
{
    partial class MainWindow
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
            this.main_controlPanel = new System.Windows.Forms.Panel();
            this.main_processPanel = new System.Windows.Forms.Panel();
            this.main_statsPanel = new System.Windows.Forms.Panel();
            this.main_create = new System.Windows.Forms.Button();
            this.main_start = new System.Windows.Forms.Button();
            this.main_pause = new System.Windows.Forms.Button();
            this.main_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.main_controlPanel.SuspendLayout();
            this.main_statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_controlPanel
            // 
            this.main_controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.main_controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_controlPanel.Controls.Add(this.main_reset);
            this.main_controlPanel.Controls.Add(this.main_pause);
            this.main_controlPanel.Controls.Add(this.main_start);
            this.main_controlPanel.Controls.Add(this.main_create);
            this.main_controlPanel.Location = new System.Drawing.Point(45, 12);
            this.main_controlPanel.Name = "main_controlPanel";
            this.main_controlPanel.Size = new System.Drawing.Size(492, 78);
            this.main_controlPanel.TabIndex = 0;
            // 
            // main_processPanel
            // 
            this.main_processPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.main_processPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_processPanel.Location = new System.Drawing.Point(45, 110);
            this.main_processPanel.Name = "main_processPanel";
            this.main_processPanel.Size = new System.Drawing.Size(492, 252);
            this.main_processPanel.TabIndex = 1;
            // 
            // main_statsPanel
            // 
            this.main_statsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.main_statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_statsPanel.Controls.Add(this.label10);
            this.main_statsPanel.Controls.Add(this.label9);
            this.main_statsPanel.Controls.Add(this.label8);
            this.main_statsPanel.Controls.Add(this.label7);
            this.main_statsPanel.Controls.Add(this.label6);
            this.main_statsPanel.Controls.Add(this.label5);
            this.main_statsPanel.Controls.Add(this.label4);
            this.main_statsPanel.Controls.Add(this.label3);
            this.main_statsPanel.Controls.Add(this.label2);
            this.main_statsPanel.Controls.Add(this.label1);
            this.main_statsPanel.Location = new System.Drawing.Point(576, 15);
            this.main_statsPanel.Name = "main_statsPanel";
            this.main_statsPanel.Size = new System.Drawing.Size(303, 346);
            this.main_statsPanel.TabIndex = 2;
            // 
            // main_create
            // 
            this.main_create.Location = new System.Drawing.Point(24, 23);
            this.main_create.Name = "main_create";
            this.main_create.Size = new System.Drawing.Size(75, 38);
            this.main_create.TabIndex = 0;
            this.main_create.Text = "Create Process";
            this.main_create.UseVisualStyleBackColor = true;
            this.main_create.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // main_start
            // 
            this.main_start.Location = new System.Drawing.Point(144, 31);
            this.main_start.Name = "main_start";
            this.main_start.Size = new System.Drawing.Size(75, 23);
            this.main_start.TabIndex = 1;
            this.main_start.Text = "Start";
            this.main_start.UseVisualStyleBackColor = true;
            this.main_start.Click += new System.EventHandler(this.main_start_Click);
            // 
            // main_pause
            // 
            this.main_pause.Location = new System.Drawing.Point(250, 31);
            this.main_pause.Name = "main_pause";
            this.main_pause.Size = new System.Drawing.Size(75, 23);
            this.main_pause.TabIndex = 2;
            this.main_pause.Text = "Pause";
            this.main_pause.UseVisualStyleBackColor = true;
            // 
            // main_reset
            // 
            this.main_reset.Location = new System.Drawing.Point(354, 30);
            this.main_reset.Name = "main_reset";
            this.main_reset.Size = new System.Drawing.Size(75, 23);
            this.main_reset.TabIndex = 3;
            this.main_reset.Text = "Reset";
            this.main_reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Response time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waiting time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "########";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "########";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "########";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 378);
            this.Controls.Add(this.main_statsPanel);
            this.Controls.Add(this.main_processPanel);
            this.Controls.Add(this.main_controlPanel);
            this.Name = "MainWindow";
            this.Text = "CPU Scheduler";
            this.main_controlPanel.ResumeLayout(false);
            this.main_statsPanel.ResumeLayout(false);
            this.main_statsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_controlPanel;
        private System.Windows.Forms.Button main_create;
        private System.Windows.Forms.Panel main_processPanel;
        private System.Windows.Forms.Panel main_statsPanel;
        private System.Windows.Forms.Button main_reset;
        private System.Windows.Forms.Button main_pause;
        private System.Windows.Forms.Button main_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}