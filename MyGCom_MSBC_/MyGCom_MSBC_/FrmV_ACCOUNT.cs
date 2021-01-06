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
    public partial class FrmV_ACCOUNT : Form
    {
        public FrmV_ACCOUNT()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "" || txtNomAcc.Text == "")
            {
                MessageBox.Show("Vous devez entrer toutes les informations");
                return;
            }

            Connection c = new Connection();
            c.Executer_Requete(@"INSERT INTO [dbo].[V_Acount] ([v_Account],[NomCompte],dateCreation)
                                    VALUES 
                                 ('" + txtAccount.Text + "' ,'" + txtNomAcc.Text + "',getdate())");
            MessageBox.Show("Information savegardée");
            c.RemplirDGV("select * from V_Acount", tableVaccount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "" || txtNomAcc.Text == "" )
            {
                MessageBox.Show("Prière remplir le champs identification");
            }
            Connection c = new Connection();
            c.Executer_Requete(@"DELETE FORM [dbo].[V_Acount]  WHERE v_Account = '" + txtAccount.Text + "'");

            MessageBox.Show("votre entrée est bien Supprim");
            netoyer();
            afficher_donnee();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.RemplirDGV("select * from V_Acount", tableVaccount);
        }

        private void netoyer()
        {
            txtAccount.Text = " ";
            txtNomAcc.Text  = " ";
        }

        public void afficher_donnee()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [V_Acount]";
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            tableVaccount.DataSource = dt;
            cmd.ExecuteNonQuery(); 
        }

        private void tableVaccount_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtAccount.Text = tableVaccount.SelectedRows[0].Cells[0].Value.ToString();
            txtNomAcc.Text = tableVaccount.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void tableVaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
