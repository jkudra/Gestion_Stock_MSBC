namespace MyGCom_MSBC_
{
    partial class FrmCommandeData
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxV_account = new System.Windows.Forms.ComboBox();
            this.txtDateCmd = new System.Windows.Forms.DateTimePicker();
            this.txtAnn = new System.Windows.Forms.NumericUpDown();
            this.txtPu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMois = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRfCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesig = new System.Windows.Forms.ComboBox();
            this.IdCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.cbxIdCl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tableCommande = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCommande)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 447);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxV_account);
            this.groupBox2.Controls.Add(this.txtDateCmd);
            this.groupBox2.Controls.Add(this.txtAnn);
            this.groupBox2.Controls.Add(this.txtPu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMois);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRfCom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 67);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commande";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "V-account";
            // 
            // cbxV_account
            // 
            this.cbxV_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxV_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxV_account.FormattingEnabled = true;
            this.cbxV_account.Location = new System.Drawing.Point(461, 32);
            this.cbxV_account.Name = "cbxV_account";
            this.cbxV_account.Size = new System.Drawing.Size(183, 21);
            this.cbxV_account.TabIndex = 41;
            this.cbxV_account.SelectedIndexChanged += new System.EventHandler(this.cbxV_account_SelectedIndexChanged);
            // 
            // txtDateCmd
            // 
            this.txtDateCmd.CustomFormat = "yyyy-MM-dd";
            this.txtDateCmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateCmd.Location = new System.Drawing.Point(284, 33);
            this.txtDateCmd.Name = "txtDateCmd";
            this.txtDateCmd.Size = new System.Drawing.Size(159, 20);
            this.txtDateCmd.TabIndex = 34;
            // 
            // txtAnn
            // 
            this.txtAnn.Location = new System.Drawing.Point(780, 33);
            this.txtAnn.Maximum = new decimal(new int[] {
            2031,
            0,
            0,
            0});
            this.txtAnn.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.txtAnn.Name = "txtAnn";
            this.txtAnn.Size = new System.Drawing.Size(86, 20);
            this.txtAnn.TabIndex = 33;
            this.txtAnn.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // txtPu
            // 
            this.txtPu.Location = new System.Drawing.Point(29, 34);
            this.txtPu.Name = "txtPu";
            this.txtPu.Size = new System.Drawing.Size(60, 20);
            this.txtPu.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Prix Unitaire";
            // 
            // txtMois
            // 
            this.txtMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMois.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtMois.FormattingEnabled = true;
            this.txtMois.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtMois.Location = new System.Drawing.Point(671, 32);
            this.txtMois.Name = "txtMois";
            this.txtMois.Size = new System.Drawing.Size(74, 21);
            this.txtMois.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Année d\'exercice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mois concerné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date de commande ";
            // 
            // txtRfCom
            // 
            this.txtRfCom.Location = new System.Drawing.Point(142, 34);
            this.txtRfCom.Name = "txtRfCom";
            this.txtRfCom.Size = new System.Drawing.Size(109, 20);
            this.txtRfCom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference commande";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDesig);
            this.groupBox1.Controls.Add(this.IdCli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQt);
            this.groupBox1.Controls.Add(this.cbxIdCl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRetirer);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.tableCommande);
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 174);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter les clients";
            // 
            // txtNumData
            // 
            this.txtNumData.Enabled = false;
            this.txtNumData.Location = new System.Drawing.Point(82, 122);
            this.txtNumData.Name = "txtNumData";
            this.txtNumData.Size = new System.Drawing.Size(183, 20);
            this.txtNumData.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Numéro Data";
            // 
            // txtDesig
            // 
            this.txtDesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDesig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtDesig.FormattingEnabled = true;
            this.txtDesig.Items.AddRange(new object[] {
            "GB"});
            this.txtDesig.Location = new System.Drawing.Point(212, 84);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(53, 21);
            this.txtDesig.TabIndex = 36;
            // 
            // IdCli
            // 
            this.IdCli.Location = new System.Drawing.Point(173, 15);
            this.IdCli.Name = "IdCli";
            this.IdCli.Size = new System.Drawing.Size(61, 20);
            this.IdCli.TabIndex = 35;
            this.IdCli.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Designation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantité";
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(82, 84);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(48, 20);
            this.txtQt.TabIndex = 21;
            // 
            // cbxIdCl
            // 
            this.cbxIdCl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxIdCl.FormattingEnabled = true;
            this.cbxIdCl.Location = new System.Drawing.Point(82, 41);
            this.cbxIdCl.Name = "cbxIdCl";
            this.cbxIdCl.Size = new System.Drawing.Size(183, 21);
            this.cbxIdCl.TabIndex = 16;
            this.cbxIdCl.SelectedIndexChanged += new System.EventHandler(this.cbxIdCl_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nom du Client";
            // 
            // btnRetirer
            // 
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.Location = new System.Drawing.Point(275, 82);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(38, 23);
            this.btnRetirer.TabIndex = 9;
            this.btnRetirer.Text = "<<";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(275, 38);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(38, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = ">>";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableCommande
            // 
            this.tableCommande.AllowUserToAddRows = false;
            this.tableCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.NomCl,
            this.qte,
            this.designation,
            this.prix,
            this.NumeroData});
            this.tableCommande.Location = new System.Drawing.Point(319, 38);
            this.tableCommande.Name = "tableCommande";
            this.tableCommande.ReadOnly = true;
            this.tableCommande.RowHeadersVisible = false;
            this.tableCommande.Size = new System.Drawing.Size(617, 119);
            this.tableCommande.TabIndex = 0;
            // 
            // idClient
            // 
            this.idClient.HeaderText = "ID Client";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            // 
            // NomCl
            // 
            this.NomCl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomCl.HeaderText = "Nom du client";
            this.NomCl.Name = "NomCl";
            this.NomCl.ReadOnly = true;
            // 
            // qte
            // 
            this.qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qte.HeaderText = "Volume commandé";
            this.qte.Name = "qte";
            this.qte.ReadOnly = true;
            // 
            // designation
            // 
            this.designation.HeaderText = "Designation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix unitaire";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // NumeroData
            // 
            this.NumeroData.HeaderText = "Numero   Data";
            this.NumeroData.Name = "NumeroData";
            this.NumeroData.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(10, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 187);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sauvegarder";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 128);
            this.dataGridView1.TabIndex = 38;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "Enregistrer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(599, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Modiffier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCommandeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 447);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCommandeData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCommandeData";
            this.Load += new System.EventHandler(this.FrmCommandeData_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCommande)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxIdCl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtRfCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.TextBox txtPu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IdCli;
        private System.Windows.Forms.ComboBox txtMois;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtAnn;
        private System.Windows.Forms.DataGridView tableCommande;
        private System.Windows.Forms.ComboBox txtDesig;
        private System.Windows.Forms.DateTimePicker txtDateCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroData;
        private System.Windows.Forms.TextBox txtNumData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxV_account;
    }
}