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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.remplirCBO(this.cbo1, "select v_account from v_acount");
            // txt1.Text = cn.Afficher("select REPLACE(convert(varchar,getdate(),104),'-','-')+'-'+(select REPLACE(convert(varchar,getdate(),108),'-','-')) as IdCustomer", "IdCustomer");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            c.RemplirDGV("select * from ClientData", tableClent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection co = new Connection();
            co.Executer_Requete(@"insert into [dbo].[clientData] ([IdCustomer]
           ,[Name]
           ,[sexe]
           ,[RefCustomer]
           ,[TelephonePersonnel]
           ,[MobileData_Number]
           ,[Adresse]
           ,[v_Account])
            values ('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + cbo1.Text + "')");
            //MessageBox.Show("Enregistrée avec succès.......!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();

            DialogResult res = MessageBox.Show("voulez-vous vraiment supprimer ce client ?", "Gestion commerciale MCSB",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (txt1.Text != "")
            {
                if (res == DialogResult.OK)
                {
                    c.Executer_Requete(@"DELETE From clientData   WHERE idCustomer = '" + txt1.Text + "'");
                    MessageBox.Show("suppression bien effectuée");
                }
                else
                {
                    MessageBox.Show("Suppression annulée.........!!!!");
                }
            }
        }

        private void tableClent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt1.Text = tableClent.SelectedRows[0].Cells[0].Value.ToString();
            txt2.Text = tableClent.SelectedRows[0].Cells[1].Value.ToString();
            txt3.Text = tableClent.SelectedRows[0].Cells[2].Value.ToString();
            txt4.Text = tableClent.SelectedRows[0].Cells[3].Value.ToString();
            txt5.Text = tableClent.SelectedRows[0].Cells[4].Value.ToString();
            txt6.Text = tableClent.SelectedRows[0].Cells[5].Value.ToString();
            txt7.Text = tableClent.SelectedRows[0].Cells[6].Value.ToString();
            cbo1.Text = tableClent.SelectedRows[0].Cells[7].Value.ToString();
        }


    }
}
