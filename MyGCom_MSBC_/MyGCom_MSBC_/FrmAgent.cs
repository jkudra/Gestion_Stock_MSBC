using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyGCom_MSBC_
{
    public partial class FrmAgent : Form
    {
        bool nouveau = true;
        public FrmAgent(bool n)
        {
            nouveau = n;
            InitializeComponent();
        }
        
        private void Close_Click(object sender, EventArgs e)
        {
                this.Hide();
        }

        public void Netoyer()
        {
            txtId.Text="" ;
            txtNom.Text ="" ;
            txtFonc.Text ="" ;
            cbxService.Text ="" ;
            txtSex.Text ="" ;
            txtTel.Text ="" ;
            txtMail.Text ="" ;
            txtpw.Clear();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supp_Click(object sender, EventArgs e)
        {
            Supprimer();
            Connection c =new Connection();
            try
            {
                cboIdentifiant.Items.Clear();
                c.remplirCBO(cboIdentifiant, "select idAgent from Agent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
        }

        private void tableAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Text  = tableAgent.SelectedRows[0].Cells[0].Value.ToString();
            //txtNom.Text  = tableAgent.SelectedRows[0].Cells[1].Value.ToString();
            // txtFonc.Text = tableAgent.SelectedRows[0].Cells[2].Value.ToString();
            // txtSex.Text = tableAgent.SelectedRows[0].Cells[3].Value.ToString();
            // txtpw.Text = tableAgent.SelectedRows[0].Cells[4].Value.ToString();
            // txtTel.Text = tableAgent.SelectedRows[0].Cells[5].Value.ToString();
            // txtMail.Text = tableAgent.SelectedRows[0].Cells[6].Value.ToString();
            //// Actifs. Text = tableAgent.SelectedRows[0].Cells[7].Value.ToString();
            //  cbxRol.Text = tableAgent.SelectedRows[0].Cells[8].Value.ToString();
            //  cbxRol.Text = tableAgent.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Enreegistrer();
        }

        private void FrmAgent_Load(object sender, EventArgs e)
        {
            if (nouveau)
            {
                cboIdentifiant.Visible = false;
                txtId.Visible = true;
                Modif.Enabled = false;
                Supp.Enabled = false;
            }
            else
            {
                cboIdentifiant.Visible = true;
                txtId.Visible = false;
                panel2.Visible = false;
                Save.Enabled = false;
                Connection c = new Connection();
                c.remplirCBO(cboIdentifiant, "select idAgent from Agent");
            }

        }


        public void Enreegistrer()
        {
            if (txtId.Text.Trim() == "" || txtNom.Text == "" || cbxService.Text == "" || txtpw.Text == "" || txtSex.Text == "")
            {
                MessageBox.Show("Vous devez saisir toutes les informations pertinantes");
                return;
            }

            if (txt_cfrm_pw.Text != txtpw.Text)
            {
                MessageBox.Show("Mot de passe non conforme !");
                return;
            }

            bool act = true;
            string status_psw = "0"; // 0 càd le user est obligé de modifier le mot de passe

            if (Actifs.Checked == false)
                act = false;
            if (pw_status.Checked == false)
                status_psw = "1";      // 1 user ne sera pas obligé de modifier le mot de passe. 2 C'est le mode normale 

            Connection con = new Connection();
            try
            {
                con.Executer_Requete(@"INSERT INTO [Agent]
                        ([IdAgent],[NomAgent] ,[fonctionAgent] ,[Sexe],[TeleAgent]
                            ,[EmailAgent],[service],[actif],pass_word,group_role,pw_status)
                        VALUES
                        ('" + txtId.Text.Trim() + "', '" + txtNom.Text + "', '" + txtFonc.Text + "' ,'" + txtSex.Text + "','" + txtTel.Text
                                + "' , '" + txtMail.Text + "' ,'" + cbxService.Text + "' ,'" + act + "', '" + txtpw.Text + "', '" + cbxRol.Text + "', '" + status_psw + "')");
                con.RemplirDGV("SELECT [NomAgent] ,[fonctionAgent] ,[Sexe],[TeleAgent] " +
                            " ,[EmailAgent],[service],[actif],group_role FROM Agent WHERE IdAgent='" + cboIdentifiant.Text + "'", tableAgent);
                if (tableAgent.Rows.Count == 1)
                {
                    MessageBox.Show("Enregistrement bien faite");
                    Netoyer();
                }
                else
                    return;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur :" + exc.Message);
            }

        }


        public void Modifier()
        {
            if (cboIdentifiant.Text == "")
            {
                MessageBox.Show("Selectionner d'abord l'agent à modifier");
                return;
            }
            if (txtNom.Text == "" || cbxService.Text == "" || txtSex.Text == "")
            {
                MessageBox.Show("Vous devez saisir toutes les informations pertinantes");
                return;
            }

            if (txt_cfrm_pw.Text != txtpw.Text)
            {
                MessageBox.Show("Mot de passe non conforme !");
                return;
            }

            bool act = true;
            string status_psw = "0"; // 0 càd le user est obligé de modifier le mot de passe

            if (Actifs.Checked == false)
                act = false;
            if (pw_status.Checked == false)
                status_psw = "1";      // 1 user ne sera pas obligé de modifier le mot de passe. 2 C'est le mode normale 

            Connection con = new Connection();
            try
            {
                con.Executer_Requete(@"UPDATE [Agent] SET [NomAgent]='" + txtNom.Text + 
                                    "',[fonctionAgent]='" + txtFonc.Text + "',[Sexe]='" + txtSex.Text + 
                                    "',[TeleAgent]='" + txtTel.Text + "',[EmailAgent]='" + txtMail.Text + 
                                    "',[service]='" + cbxService.Text + "' ,[actif]='" + act + 
                                    "',group_role='" + cbxRol.Text + 
                                    "',pw_status='" + status_psw + 
                                    "' WHERE IdAgent='"+ cboIdentifiant.Text +"' ");

                con.RemplirDGV("SELECT [NomAgent] ,[fonctionAgent] ,[Sexe],[TeleAgent] " +
                            " ,[EmailAgent],[service],[actif],group_role FROM Agent WHERE IdAgent='" + cboIdentifiant.Text + "'", tableAgent);
                if (tableAgent.Rows.Count == 1)
                {
                    MessageBox.Show("Information sauvegardée");
                    Netoyer();
                }
                else
                    return;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur :" + exc.Message);
            }

        }

        public void Supprimer()
        {
            int count_trans = 0;
            if (cboIdentifiant.Text == "")
            {
                MessageBox.Show("Selectionner d'abord l'agent à supprimer");
                return;
            }
            Connection con = new Connection();
            try
            {
                count_trans=int.Parse(con.Afficher("select count(*)+(select count(*) from payementData where idAgent='" + cboIdentifiant.Text + "') as Nbre " +
                                                   "from commandeData "+
                                                   "where idAgent='" + cboIdentifiant.Text + "'","Nbre"));
                if (count_trans > 0)
                {
                    MessageBox.Show("Cet agent a déjà passée de transaction dans le système. \n Vous pouvez plutôt le désactiver que le supprimer.",
                        "Gestion commerciale MSBC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Voulez-vous supprimer cet agent ?",
                    "Gestion commerciale MSCB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Executer_Requete(@"DELETE FROM Agent WHERE IdAgent='" + cboIdentifiant.Text + "' ");
                    MessageBox.Show("Information supprimée");
                }
                Netoyer();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur :" + exc.Message);
            }

        }

        private void Modif_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void cboIdentifiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection c = new Connection();
            DataTable dt = c.Source_Donnees("SELECT [NomAgent] ,[fonctionAgent] ,[Sexe],[TeleAgent] "+
                            " ,[EmailAgent],[service],[actif],group_role FROM Agent WHERE IdAgent='"+ cboIdentifiant.Text +"'", "Agent");
            txtNom.Text = dt.Rows[0][0].ToString();
            txtFonc.Text = dt.Rows[0][1].ToString();
            txtSex.Text = dt.Rows[0][2].ToString();
            txtTel.Text = dt.Rows[0][3].ToString();
            txtMail.Text = dt.Rows[0][4].ToString();
            cbxService.Text = dt.Rows[0][5].ToString();
            if (dt.Rows[0][6].Equals(true))
                Actifs.Checked = true;
            else
                Actifs.Checked = false;
            cbxRol.Text = dt.Rows[0][7].ToString();
        }

    }
}
