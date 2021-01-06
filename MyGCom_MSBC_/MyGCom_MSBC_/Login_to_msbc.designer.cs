namespace MyGCom_MSBC_
{
    partial class Login_to_msbc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_to_msbc));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.butSup = new System.Windows.Forms.Button();
            this.butLog = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(16, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 265);
            this.panel2.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.textPWD);
            this.panel8.Controls.Add(this.textNom);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.ForeColor = System.Drawing.SystemColors.Control;
            this.panel8.Location = new System.Drawing.Point(7, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(370, 203);
            this.panel8.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // textPWD
            // 
            this.textPWD.BackColor = System.Drawing.Color.White;
            this.textPWD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPWD.Location = new System.Drawing.Point(191, 130);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(163, 20);
            this.textPWD.TabIndex = 22;
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.White;
            this.textNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNom.Location = new System.Drawing.Point(191, 106);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(163, 20);
            this.textNom.TabIndex = 21;
            this.textNom.Enter += new System.EventHandler(this.textNom_Enter);
            this.textNom.Leave += new System.EventHandler(this.textNom_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(120, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(106, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "password";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Controls.Add(this.butSup);
            this.panel7.Controls.Add(this.butLog);
            this.panel7.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel7.Location = new System.Drawing.Point(4, 216);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 44);
            this.panel7.TabIndex = 27;
            // 
            // butSup
            // 
            this.butSup.BackColor = System.Drawing.Color.Red;
            this.butSup.FlatAppearance.BorderSize = 0;
            this.butSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSup.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSup.Location = new System.Drawing.Point(3, 3);
            this.butSup.Name = "butSup";
            this.butSup.Size = new System.Drawing.Size(92, 35);
            this.butSup.TabIndex = 25;
            this.butSup.Text = "&Quitter";
            this.butSup.UseVisualStyleBackColor = false;
            this.butSup.Click += new System.EventHandler(this.button1_Click);
            // 
            // butLog
            // 
            this.butLog.BackColor = System.Drawing.Color.Red;
            this.butLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLog.FlatAppearance.BorderSize = 0;
            this.butLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLog.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLog.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butLog.Location = new System.Drawing.Point(269, 3);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(92, 36);
            this.butLog.TabIndex = 24;
            this.butLog.Text = "L&ogin";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.butAnnuler_Click);
            this.butLog.Enter += new System.EventHandler(this.butLog_Enter);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(381, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 255);
            this.panel6.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 255);
            this.panel5.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 255);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 5);
            this.panel3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 5);
            this.panel1.TabIndex = 5;
            // 
            // Login_to_msbc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(414, 286);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login_to_msbc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_to_msbc";
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textPWD;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butSup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}