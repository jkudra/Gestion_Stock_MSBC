namespace MyGCom_MSBC_
{
    partial class FrmPayement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCds = new System.Windows.Forms.TextBox();
            this.txtMntDuClient = new System.Windows.Forms.TextBox();
            this.cbxIdClient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tablePayment = new System.Windows.Forms.DataGridView();
            this.IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantPaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMntRestantDu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMntPaye = new System.Windows.Forms.TextBox();
            this.txtRfP = new System.Windows.Forms.TextBox();
            this.txtMntDu = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.cbxRfCom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 477);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(256, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(428, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "ENREGISTREMENT DES PAYEMENTS ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 436);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(9, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 47);
            this.panel3.TabIndex = 73;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(425, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 42;
            this.button6.Text = "Supprimer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(610, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(74, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Enregistrer";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(248, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Modiffier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(9, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 157);
            this.panel4.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 150);
            this.dataGridView1.TabIndex = 71;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIdCds);
            this.groupBox2.Controls.Add(this.txtMntDuClient);
            this.groupBox2.Controls.Add(this.cbxIdClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMontant);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tablePayment);
            this.groupBox2.Location = new System.Drawing.Point(10, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 142);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details clients";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "ID Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Montant dû";
            // 
            // txtIdCds
            // 
            this.txtIdCds.Enabled = false;
            this.txtIdCds.Location = new System.Drawing.Point(47, 79);
            this.txtIdCds.Name = "txtIdCds";
            this.txtIdCds.Size = new System.Drawing.Size(73, 20);
            this.txtIdCds.TabIndex = 68;
            // 
            // txtMntDuClient
            // 
            this.txtMntDuClient.Enabled = false;
            this.txtMntDuClient.Location = new System.Drawing.Point(153, 79);
            this.txtMntDuClient.Name = "txtMntDuClient";
            this.txtMntDuClient.Size = new System.Drawing.Size(58, 20);
            this.txtMntDuClient.TabIndex = 68;
            // 
            // cbxIdClient
            // 
            this.cbxIdClient.FormattingEnabled = true;
            this.cbxIdClient.Location = new System.Drawing.Point(47, 31);
            this.cbxIdClient.Name = "cbxIdClient";
            this.cbxIdClient.Size = new System.Drawing.Size(275, 21);
            this.cbxIdClient.TabIndex = 55;
            this.cbxIdClient.SelectedIndexChanged += new System.EventHandler(this.cbxIdClient_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Montant payé";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(231, 79);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(91, 20);
            this.txtMontant.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(345, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablePayment
            // 
            this.tablePayment.AllowUserToAddRows = false;
            this.tablePayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePayment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tablePayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCustomer,
            this.nom,
            this.MontantDue,
            this.montantPaye,
            this.Restant});
            this.tablePayment.Location = new System.Drawing.Point(417, 10);
            this.tablePayment.Name = "tablePayment";
            this.tablePayment.Size = new System.Drawing.Size(410, 103);
            this.tablePayment.TabIndex = 31;
            // 
            // IdCustomer
            // 
            this.IdCustomer.HeaderText = "ID Client";
            this.IdCustomer.Name = "IdCustomer";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // MontantDue
            // 
            this.MontantDue.HeaderText = "Montant du";
            this.MontantDue.Name = "MontantDue";
            this.MontantDue.ReadOnly = true;
            // 
            // montantPaye
            // 
            this.montantPaye.HeaderText = "Montant payé";
            this.montantPaye.Name = "montantPaye";
            // 
            // Restant
            // 
            this.Restant.HeaderText = "Restant du";
            this.Restant.Name = "Restant";
            this.Restant.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtMntRestantDu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMntPaye);
            this.groupBox1.Controls.Add(this.txtRfP);
            this.groupBox1.Controls.Add(this.txtMntDu);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.cbxMois);
            this.groupBox1.Controls.Add(this.cbxRfCom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 70);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info paiement";
            // 
            // txtMntRestantDu
            // 
            this.txtMntRestantDu.Enabled = false;
            this.txtMntRestantDu.Location = new System.Drawing.Point(375, 44);
            this.txtMntRestantDu.Name = "txtMntRestantDu";
            this.txtMntRestantDu.Size = new System.Drawing.Size(121, 20);
            this.txtMntRestantDu.TabIndex = 74;
            this.txtMntRestantDu.TextChanged += new System.EventHandler(this.txtMntRestantDu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Restant dû";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Réf. paiement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Mois Payé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Mnt. Payé";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Montant du";
            // 
            // txtMntPaye
            // 
            this.txtMntPaye.Enabled = false;
            this.txtMntPaye.Location = new System.Drawing.Point(218, 44);
            this.txtMntPaye.Name = "txtMntPaye";
            this.txtMntPaye.Size = new System.Drawing.Size(58, 20);
            this.txtMntPaye.TabIndex = 70;
            // 
            // txtRfP
            // 
            this.txtRfP.Enabled = false;
            this.txtRfP.Location = new System.Drawing.Point(88, 18);
            this.txtRfP.Name = "txtRfP";
            this.txtRfP.Size = new System.Drawing.Size(188, 20);
            this.txtRfP.TabIndex = 33;
            // 
            // txtMntDu
            // 
            this.txtMntDu.Enabled = false;
            this.txtMntDu.Location = new System.Drawing.Point(88, 44);
            this.txtMntDu.Name = "txtMntDu";
            this.txtMntDu.Size = new System.Drawing.Size(63, 20);
            this.txtMntDu.TabIndex = 72;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(740, 20);
            this.txtDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(88, 20);
            this.txtDate.TabIndex = 66;
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Items.AddRange(new object[] {
            "JANVIER",
            "FEVRIER",
            "MARS",
            "AVRIL",
            "MAI",
            "JUIN ",
            "JUILLET",
            "AOUT",
            "SEPTEMBRE",
            "OCTOBRE",
            "NOVEMBRE",
            "DECEMBRE"});
            this.cbxMois.Location = new System.Drawing.Point(576, 20);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(112, 21);
            this.cbxMois.TabIndex = 65;
            // 
            // cbxRfCom
            // 
            this.cbxRfCom.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.cbxRfCom.BackColor = System.Drawing.SystemColors.Window;
            this.cbxRfCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRfCom.FormattingEnabled = true;
            this.cbxRfCom.Location = new System.Drawing.Point(375, 17);
            this.cbxRfCom.Name = "cbxRfCom";
            this.cbxRfCom.Size = new System.Drawing.Size(121, 21);
            this.cbxRfCom.TabIndex = 59;
            this.cbxRfCom.SelectedIndexChanged += new System.EventHandler(this.cbxRfCom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Réf. Commande";
            // 
            // FrmPayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 477);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPayement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPayement";
            this.Load += new System.EventHandler(this.FrmPayement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxRfCom;
        private System.Windows.Forms.ComboBox cbxIdClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRfP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablePayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMntDuClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMntPaye;
        private System.Windows.Forms.TextBox txtIdCds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMntRestantDu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMntDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantPaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restant;
        private System.Windows.Forms.Label label12;
    }
}