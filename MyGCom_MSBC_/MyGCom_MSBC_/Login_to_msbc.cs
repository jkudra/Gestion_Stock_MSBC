using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyGCom_MSBC_
{
    public partial class Login_to_msbc : Form
    {
        public Login_to_msbc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //bouton oublie mot de passe 

        }

        private void butAnnuler_Click(object sender, EventArgs e)
        {
            if (textPWD.Text == "" || textNom.Text == "")
            {
                MessageBox.Show("Vous devez saisir le login");
                return;
            }

            Connection c = new Connection();
            int exist = 0;
            bool actif = true;
            exist = Convert.ToInt32(c.Afficher("select COUNT(*) as counts from Agent where IdAgent='" + textNom.Text + "' and Pass_Word='" + textPWD.Text + "'", "counts"));
            
            //TODO : check pass word status: 0 pass to change

            if (exist == 1)
            {
                actif = Convert.ToBoolean(c.Afficher("select [actif] as actif from Agent where IdAgent='" + textNom.Text + "' and Pass_Word='" + textPWD.Text + "'", "actif"));
                if (!actif)
                {
                    MessageBox.Show("Compte inactif !");
                    return;
                }
                Connection.user = c.Afficher(@"SELECT IdAgent FROM [dbo].[Agent] where IdAgent='" + textNom.Text + "' and Pass_Word='" + textPWD.Text + "'", "IdAgent");
                Connection.rol = c.Afficher(@"SELECT Group_Role FROM [dbo].[Agent] where IdAgent='" + textNom.Text + "' and Pass_Word='" + textPWD.Text + "'", "Group_Role");
                this.Hide();
                FrmPricncipale main = new FrmPricncipale();
                main.Show();
            }
            else
                MessageBox.Show("Nom ou  mot de passe invalide.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //button1_Click(sender, e);
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            textNom.BackColor = Color.YellowGreen;
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            textNom.BackColor = Color.Turquoise;
        }

        private void butLog_Enter(object sender, EventArgs e)
        {
            butLog.BackColor = Color.SaddleBrown;
        }


    }
}

