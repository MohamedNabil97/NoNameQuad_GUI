﻿namespace NoNameQuad_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textbox_alpha_t1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();

            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label_Serv90_t3 = new System.Windows.Forms.Label();
            this.label_Serv180_t3 = new System.Windows.Forms.Label();
            this.label_Serv0_t3 = new System.Windows.Forms.Label();
            this.button_Serv90_t3 = new System.Windows.Forms.Button();
            this.button_Serv180_t3 = new System.Windows.Forms.Button();
            this.button_Serv0_t3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();

            this.pictureBox_inverseK_t1 = new System.Windows.Forms.PictureBox();
            this.comboBox_legNumber_t1 = new System.Windows.Forms.ComboBox();
            this.comboBox_servo_t1 = new System.Windows.Forms.ComboBox();
            this.label_gamma_t1 = new System.Windows.Forms.Label();
            this.label_beta_t1 = new System.Windows.Forms.Label();
            this.label_alpha_t1 = new System.Windows.Forms.Label();
            this.label_servo_t1 = new System.Windows.Forms.Label();
            this.label_legnumber_t1 = new System.Windows.Forms.Label();
            this.textbox_gamma_t1 = new System.Windows.Forms.TextBox();
            this.textbox_beta_t1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_applyChanges_t1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.textbox_alpha_t1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inverseK_t1)).BeginInit();

            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.textbox_alpha_t1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // textbox_alpha_t1
            // 
            this.textbox_alpha_t1.Controls.Add(this.pictureBox_inverseK_t1);
            this.textbox_alpha_t1.Controls.Add(this.comboBox_legNumber_t1);
            this.textbox_alpha_t1.Controls.Add(this.comboBox_servo_t1);
            this.textbox_alpha_t1.Controls.Add(this.label_gamma_t1);
            this.textbox_alpha_t1.Controls.Add(this.label_beta_t1);
            this.textbox_alpha_t1.Controls.Add(this.label_alpha_t1);
            this.textbox_alpha_t1.Controls.Add(this.label_servo_t1);
            this.textbox_alpha_t1.Controls.Add(this.label_legnumber_t1);
            this.textbox_alpha_t1.Controls.Add(this.textbox_gamma_t1);
            this.textbox_alpha_t1.Controls.Add(this.textbox_beta_t1);
            this.textbox_alpha_t1.Controls.Add(this.textBox1);
            this.textbox_alpha_t1.Controls.Add(this.button_applyChanges_t1);
            this.textbox_alpha_t1.Location = new System.Drawing.Point(4, 22);
            this.textbox_alpha_t1.Name = "textbox_alpha_t1";
            this.textbox_alpha_t1.Padding = new System.Windows.Forms.Padding(3);
            this.textbox_alpha_t1.Size = new System.Drawing.Size(597, 272);
            this.textbox_alpha_t1.TabIndex = 0;
            this.textbox_alpha_t1.Text = "Servo Control";
            this.textbox_alpha_t1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_Serv0_t3);
            this.tabPage3.Controls.Add(this.button_Serv180_t3);
            this.tabPage3.Controls.Add(this.button_Serv90_t3);
            this.tabPage3.Controls.Add(this.label_Serv0_t3);
            this.tabPage3.Controls.Add(this.label_Serv180_t3);
            this.tabPage3.Controls.Add(this.label_Serv90_t3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(597, 272);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(597, 272);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox_inverseK_t1
            // 
            this.pictureBox_inverseK_t1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_inverseK_t1.Image")));
            this.pictureBox_inverseK_t1.Location = new System.Drawing.Point(327, 6);
            this.pictureBox_inverseK_t1.Name = "pictureBox_inverseK_t1";
            this.pictureBox_inverseK_t1.Size = new System.Drawing.Size(247, 214);
            this.pictureBox_inverseK_t1.TabIndex = 24;
            this.pictureBox_inverseK_t1.TabStop = false;
            this.pictureBox_inverseK_t1.UseWaitCursor = true;
            // 
            // comboBox_legNumber_t1
            // 
            this.comboBox_legNumber_t1.FormattingEnabled = true;
            this.comboBox_legNumber_t1.Location = new System.Drawing.Point(114, 21);
            this.comboBox_legNumber_t1.Name = "comboBox_legNumber_t1";
            this.comboBox_legNumber_t1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_legNumber_t1.TabIndex = 23;
            this.comboBox_legNumber_t1.UseWaitCursor = true;
            // 
            // comboBox_servo_t1
            // 
            this.comboBox_servo_t1.FormattingEnabled = true;
            this.comboBox_servo_t1.Location = new System.Drawing.Point(114, 51);
            this.comboBox_servo_t1.Name = "comboBox_servo_t1";
            this.comboBox_servo_t1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_servo_t1.TabIndex = 22;
            this.comboBox_servo_t1.UseWaitCursor = true;
            // 
            // label_gamma_t1
            // 
            this.label_gamma_t1.AutoSize = true;
            this.label_gamma_t1.Location = new System.Drawing.Point(21, 155);
            this.label_gamma_t1.Name = "label_gamma_t1";
            this.label_gamma_t1.Size = new System.Drawing.Size(43, 13);
            this.label_gamma_t1.TabIndex = 21;
            this.label_gamma_t1.Text = "Gamma";
            this.label_gamma_t1.UseWaitCursor = true;
            // 
            // label_beta_t1
            // 
            this.label_beta_t1.AutoSize = true;
            this.label_beta_t1.Location = new System.Drawing.Point(30, 113);
            this.label_beta_t1.Name = "label_beta_t1";
            this.label_beta_t1.Size = new System.Drawing.Size(29, 13);
            this.label_beta_t1.TabIndex = 20;
            this.label_beta_t1.Text = "Beta";
            this.label_beta_t1.UseWaitCursor = true;
            // 
            // label_alpha_t1
            // 
            this.label_alpha_t1.AutoSize = true;
            this.label_alpha_t1.Location = new System.Drawing.Point(30, 81);
            this.label_alpha_t1.Name = "label_alpha_t1";
            this.label_alpha_t1.Size = new System.Drawing.Size(34, 13);
            this.label_alpha_t1.TabIndex = 19;
            this.label_alpha_t1.Text = "Alpha";
            this.label_alpha_t1.UseWaitCursor = true;
            // 
            // label_servo_t1
            // 
            this.label_servo_t1.AutoSize = true;
            this.label_servo_t1.Location = new System.Drawing.Point(30, 51);
            this.label_servo_t1.Name = "label_servo_t1";
            this.label_servo_t1.Size = new System.Drawing.Size(35, 13);
            this.label_servo_t1.TabIndex = 18;
            this.label_servo_t1.Text = "Servo";
            this.label_servo_t1.UseWaitCursor = true;
            // 
            // label_legnumber_t1
            // 
            this.label_legnumber_t1.AutoSize = true;
            this.label_legnumber_t1.Location = new System.Drawing.Point(30, 27);
            this.label_legnumber_t1.Name = "label_legnumber_t1";
            this.label_legnumber_t1.Size = new System.Drawing.Size(65, 13);
            this.label_legnumber_t1.TabIndex = 17;
            this.label_legnumber_t1.Text = "Leg Number";
            this.label_legnumber_t1.UseWaitCursor = true;
            // 
            // textbox_gamma_t1
            // 
            this.textbox_gamma_t1.Location = new System.Drawing.Point(114, 155);
            this.textbox_gamma_t1.Name = "textbox_gamma_t1";
            this.textbox_gamma_t1.Size = new System.Drawing.Size(100, 20);
            this.textbox_gamma_t1.TabIndex = 16;
            this.textbox_gamma_t1.UseWaitCursor = true;
            // 
            // textbox_beta_t1
            // 
            this.textbox_beta_t1.Location = new System.Drawing.Point(114, 113);
            this.textbox_beta_t1.Name = "textbox_beta_t1";
            this.textbox_beta_t1.Size = new System.Drawing.Size(100, 20);
            this.textbox_beta_t1.TabIndex = 15;
            this.textbox_beta_t1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.UseWaitCursor = true;
            // 
            // button_applyChanges_t1
            // 
            this.button_applyChanges_t1.Location = new System.Drawing.Point(108, 211);
            this.button_applyChanges_t1.Name = "button_applyChanges_t1";
            this.button_applyChanges_t1.Size = new System.Drawing.Size(106, 33);
            this.button_applyChanges_t1.TabIndex = 13;
            this.button_applyChanges_t1.Text = "Apply Changes";
            this.button_applyChanges_t1.UseVisualStyleBackColor = true;
            this.button_applyChanges_t1.UseWaitCursor = true;
            // 
            // label_Serv90_t3
            // 
            this.label_Serv90_t3.AutoSize = true;
            this.label_Serv90_t3.Location = new System.Drawing.Point(11, 30);
            this.label_Serv90_t3.Name = "label_Serv90_t3";
            this.label_Serv90_t3.Size = new System.Drawing.Size(115, 13);
            this.label_Serv90_t3.TabIndex = 0;
            this.label_Serv90_t3.Text = "Calibrate Servos to 90°";
            // 
            // label_Serv180_t3
            // 
            this.label_Serv180_t3.AutoSize = true;
            this.label_Serv180_t3.Location = new System.Drawing.Point(11, 70);
            this.label_Serv180_t3.Name = "label_Serv180_t3";
            this.label_Serv180_t3.Size = new System.Drawing.Size(121, 13);
            this.label_Serv180_t3.TabIndex = 1;
            this.label_Serv180_t3.Text = "Calibrate Servos to 180°";
            this.label_Serv180_t3.Click += new System.EventHandler(this.Serv180_Click);
            // 
            // label_Serv0_t3
            // 
            this.label_Serv0_t3.AutoSize = true;
            this.label_Serv0_t3.Location = new System.Drawing.Point(11, 110);
            this.label_Serv0_t3.Name = "label_Serv0_t3";
            this.label_Serv0_t3.Size = new System.Drawing.Size(109, 13);
            this.label_Serv0_t3.TabIndex = 2;
            this.label_Serv0_t3.Text = "Calibrate Servos to 0°";
            // 
            // button_Serv90_t3
            // 
            this.button_Serv90_t3.Location = new System.Drawing.Point(148, 30);
            this.button_Serv90_t3.Name = "button_Serv90_t3";
            this.button_Serv90_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv90_t3.TabIndex = 3;
            this.button_Serv90_t3.Text = "Wosh";
            this.button_Serv90_t3.UseVisualStyleBackColor = true;
            // 
            // button_Serv180_t3
            // 
            this.button_Serv180_t3.Location = new System.Drawing.Point(148, 70);
            this.button_Serv180_t3.Name = "button_Serv180_t3";
            this.button_Serv180_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv180_t3.TabIndex = 4;
            this.button_Serv180_t3.Text = "Shazam";
            this.button_Serv180_t3.UseVisualStyleBackColor = true;
            // 
            // button_Serv0_t3
            // 
            this.button_Serv0_t3.Location = new System.Drawing.Point(148, 110);
            this.button_Serv0_t3.Name = "button_Serv0_t3";
            this.button_Serv0_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv0_t3.TabIndex = 5;
            this.button_Serv0_t3.Text = "idk";
            this.button_Serv0_t3.UseVisualStyleBackColor = true;
            this.button_Serv0_t3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 296);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DEVELOPMENT GUI ";
            this.tabControl1.ResumeLayout(false);

            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();

            this.textbox_alpha_t1.ResumeLayout(false);
            this.textbox_alpha_t1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inverseK_t1)).EndInit();
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textbox_alpha_t1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label_Serv90_t3;
        private System.Windows.Forms.Button button_Serv0_t3;
        private System.Windows.Forms.Button button_Serv180_t3;
        private System.Windows.Forms.Button button_Serv90_t3;
        private System.Windows.Forms.Label label_Serv0_t3;
        private System.Windows.Forms.Label label_Serv180_t3;

        private System.Windows.Forms.PictureBox pictureBox_inverseK_t1;
        private System.Windows.Forms.ComboBox comboBox_legNumber_t1;
        private System.Windows.Forms.ComboBox comboBox_servo_t1;
        private System.Windows.Forms.Label label_gamma_t1;
        private System.Windows.Forms.Label label_beta_t1;
        private System.Windows.Forms.Label label_alpha_t1;
        private System.Windows.Forms.Label label_servo_t1;
        private System.Windows.Forms.Label label_legnumber_t1;
        private System.Windows.Forms.TextBox textbox_gamma_t1;
        private System.Windows.Forms.TextBox textbox_beta_t1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_applyChanges_t1;

    }
}

