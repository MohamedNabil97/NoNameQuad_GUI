namespace NoNameQuad_GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(597, 272);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(597, 272);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}

