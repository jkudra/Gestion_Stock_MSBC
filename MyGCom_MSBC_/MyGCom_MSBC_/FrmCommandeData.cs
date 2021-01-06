using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGCom_MSBC_
{
    public partial class FrmCommandeData : Form
    {
        public FrmCommandeData()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCommandeData_Load(object sender, EventArgs e)
        {
            Connection c = new Connection();
            c.remplirCBO(cbxV_account, "select [v_account]+' | '+[NomCompte] as nom from V_acount");
        }
        
        private void cbxIdCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection c = new Connection();
            IdCli.Text = c.Afficher("select IdCustomer from clientData where [IdCustomer]+' | '+[Name]='" + cbxIdCl.Text + "'", "IdCustomer");
            txtNumData.Text = c.Afficher("select MobileData_Number from ClientData where [IdCustomer]+' | '+[Name]='" + cbxIdCl.Text + "'", "MobileData_Number");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. test si dans les textBox il ya quelques deja saisie. sinon atuta ajouter mu DG. 1h il faut ni lale wangu.
            if (cbxIdCl.Text == "" || txtQt.Text == "" || txtDesig.Text == "" || txtPu.Text == "")  //ziko mbili mbili na zile za mu DataG. attention tsifanye confis
            {
                MessageBox.Show("Vous devez saisir toutes les information");
                return;
            }
            int row = 0;
            row = tableCommande.Rows.Count - 1;
            tableCommande.Rows.Add(IdCli.Text, cbxIdCl.Text, txtQt.Text, txtDesig.Text, txtPu.Text,txtNumData.Text);
            ReinitialiserTextBox();
        }

        private void ReinitialiserTextBox()
        {
            cbxIdCl.Text = ""; txtQt.Text = ""; txtDesig.Text = ""; //txtPu.Text = "";
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            int Index;

            if (tableCommande.Rows.Count > 0)
            {
                Index = tableCommande.CurrentRow.Index;
                tableCommande.Rows.RemoveAt(Index);
            }
            else
                MessageBox.Show("Veuillez selectionner une ligne d'information avant de Retirer !", " Message Info. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            if (tableCommande.Rows.Count == 0)
            {
                MessageBox.Show("Ajouter au moins un client dans la liste");
                return;
            }

            if (txtPu.Text == "" || txtRfCom.Text == "" || txtDateCmd.Text == "" || txtMois.Text == "")
            {
                MessageBox.Show("Toutes les informations sont reaquises !");
                return;
            }

            Connection cn = new Connection();
            cn.Executer_Requete(@"set dateformat dmy INSERT INTO commandeData
			                               ([Ref_Command]
			                               ,[DateCommande]
			                               ,[mois]
			                               ,[annee]
			                               ,[idAgent])
                               VALUES('" + txtRfCom.Text + "', '" + Convert.ToDateTime(txtDateCmd.Text) + "', '" + txtMois.Text + "', '" +
                                         txtAnn.Text + "', '" + Connection.user + "')");

            //cn.Executer_Requete(String.Format(rqtCmd, txtRfCom.Text, Convert.ToDateTime(txtDateCmd.Text), txtMois.Text, txtAnn.Text, comboBox1.Text));
            for (int i = 0; i < tableCommande.Rows.Count; i++)
            {
                cn.Executer_Requete(@"INSERT INTO [DetailCommand]
			                               ([Ref_Command]
			                               ,[idCustomer]
			                               ,[Qte]
			                               ,[Designation]
			                               ,[PrixU])
	                                 VALUES('" + txtRfCom.Text + "','" +
                                         tableCommande.Rows[i].Cells[0].Value.ToString() + "','" +
                                         tableCommande.Rows[i].Cells[2].Value.ToString() + "','" +
                                         tableCommande.Rows[i].Cells[3].Value.ToString() + "', " +
                                         decimal.Parse(tableCommande.Rows[i].Cells[4].Value.ToString())
                                         + ")");
            }
            MessageBox.Show("Commande enregistrée. Nombre de client : " + tableCommande.Rows.Count);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxV_account_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nbr_caract = cbxV_account.Text.IndexOf("|");
            Connection c = new  Connection();
            c.remplirCBO(cbxIdCl, "select [IdCustomer]+' | '+[Name] as nom from clientData where [v_account]='" + cbxV_account.Text.Substring(0,nbr_caract) + "'");
        }
    }
}
