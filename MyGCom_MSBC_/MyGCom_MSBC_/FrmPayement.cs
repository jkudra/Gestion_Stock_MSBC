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
    public partial class FrmPayement : Form
    {
        public FrmPayement()
        {
            InitializeComponent();
        }

        private void FrmPayement_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.remplirCBO(cbxRfCom, "select Ref_Command from CommandeData");
            txtRfP.Text= con.Afficher("select REPLACE(convert(varchar,getdate(),104),'.','')+''+(select REPLACE(convert(varchar,getdate(),108),':','')) as refpaie", "refpaie");
            //con.remplirCBO(cbxIdClient,"select IdCustomer+'/'+Name as ClientData from ClientData");
        }

        private void cbxIdClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection con = new Connection();
            txtIdCds.Text = con.Afficher("Select  IdCustomer from ClientData where IdCustomer+'/'+Name ='" + cbxIdClient.Text + "'", "IdCustomer");
            txtMntDuClient.Text = con.Afficher(@"select coalesce(sum(qte*Prixu),0) as tot_due_client 
                                           from DetailCommand
                                           where Ref_Command='" + cbxRfCom.Text + "' and [IdCustomer]='" + txtIdCds.Text + "'", "tot_due_client"
                                        );
        }

        private void cbxRfCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cn=new Connection ();
            cbxIdClient.Items.Clear();
            cn.remplirCBO(cbxIdClient, @"select ClientData.IdCustomer+'/'+Name as ClientData 
                                          from ClientData inner join Detailcommand on clientData.IdCustomer=DetailCommand.IdCustomer
                                          where Ref_Command='"+cbxRfCom.Text +"'");
            txtMntDu.Text = cn.Afficher(@"select coalesce(sum(qte*Prixu),0) as tot_due 
                                          from DetailCommand
                                          where Ref_Command='" + cbxRfCom.Text + "'", "tot_due"
                                        );

            txtMntPaye.Text = cn.Afficher(@"select coalesce(sum(montantPaye),0) as tot_paie  
                                              from DetailPayement inner join payementData on DetailPayement.Ref_Payement=payementData.Ref_Payement
                                              where Ref_Command='" + cbxRfCom.Text + "'", "tot_paie"
                                         );
            txtMntRestantDu.Text = Convert.ToString(decimal.Parse(txtMntDu.Text) - decimal.Parse(txtMntPaye.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Index;

            if (tablePayment.Rows.Count > 0)
            {
                Index = tablePayment.CurrentRow.Index;
                tablePayment.Rows.RemoveAt(Index);
            }
            else
                MessageBox.Show("Veuillez selectionner une ligne d'information avant de Retirer !", " Message Info. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            if (txtMontant.Text=="" || txtIdCds.Text== "")  //ziko mbili mbili na zile za mu DataG. attention tsifanye confis
            {
                MessageBox.Show("Vous devez selectionner le client et saisir le montant");
                return;
            }
            double diffMontDuMontPayeCl= double.Parse(txtMntDuClient.Text) - double.Parse(txtMontant.Text);
            tablePayment.Rows.Add(txtIdCds.Text, cbxIdClient.Text, txtMntDuClient.Text, txtMontant.Text, diffMontDuMontPayeCl);

            cbxIdClient.Items.Clear();
            cn.remplirCBO(cbxIdClient, @"select ClientData.IdCustomer+'/'+Name as ClientData 
                                          from ClientData inner join Detailcommand on clientData.IdCustomer=DetailCommand.IdCustomer
                                          where Ref_Command='" + cbxRfCom.Text + "' and ClientData.IdCustomer not in('" + txtIdCds.Text + "') ");
            txtMntPaye.Text = (Double.Parse(txtMntPaye.Text)+ Double.Parse(txtMontant.Text)).ToString();
            txtMntRestantDu.Text = Convert.ToString(Double.Parse(txtMntDu.Text) - Double.Parse(txtMntPaye.Text));
            ReinitialiserTextBox();
        }

        private void ReinitialiserTextBox()
        {
            cbxIdClient.Text = ""; txtMontant.Text = ""; txtMntDuClient.Text="" ; txtIdCds.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tablePayment.Rows.Count == 0)
            {
                MessageBox.Show("Aucun client ajouté dans la liste!");
                return;
            }
            Connection con = new Connection();
            con.Executer_Requete(@"INSERT INTO [dbo].[payementData]([Ref_Payement] ,[MoisPaye],[Payement_Date],[Ref_Command] ,[idAgent])
                                   VALUES
                                        ('" + txtRfP.Text + "','" + cbxMois.Text + "','" + Convert.ToDateTime(txtDate.Text) + "','" + cbxRfCom.Text + "','" + Connection.user + "')");

            for(int i=0; i<tablePayment.Rows.Count; i++)
            {
                Connection cn = new Connection();
                con.Executer_Requete(@"INSERT INTO [dbo].[Detailpayement](Ref_Payement,IdCustomer,montantPaye)
                                    Values 
                                         ('" + txtRfP.Text + "','" + tablePayment.Rows[i].Cells[0].Value.ToString() + "'," + tablePayment.Rows[i].Cells[3].Value.ToString() + ")");
            }
        }

        private void txtMntRestantDu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
