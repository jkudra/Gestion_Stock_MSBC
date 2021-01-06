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
    public partial class FrmPricncipale : Form
    {
        public FrmPricncipale()
        {
            InitializeComponent();
        }

        private void FrmPricncipale_Load(object sender, EventArgs e)
        {
            //menuStrip1.Hide();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            menuStrip1.Show();
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgent agent = new FrmAgent(true);
            agent.MdiParent = this;
            agent.Show();
        }

        private void clientDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmV_ACCOUNT Acc = new FrmV_ACCOUNT();
            Acc.MdiParent = this;
            Acc.Show();
        }

        private void clientDataaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClient Cli = new FrmClient();
            Cli.MdiParent = this;
            Cli.Show();
        }

        private void commandeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommandeData Com = new FrmCommandeData();
            Com.MdiParent = this;
            Com.Show();
        }

        private void payementDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayement pay = new FrmPayement();
            pay.MdiParent = this;
            pay.Show();
        }

        private void Fermer_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FrmAgent agent = new FrmAgent(true);
            agent.MdiParent = this;
            agent.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quitter le sytème?", "Gestion commerciale MSBC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {             
                Application.Exit();
            }
        }

        private void déconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_to_msbc l = new Login_to_msbc();
            l.Show();
        }

        private void miseÀJourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgent agent = new FrmAgent(false);
            agent.MdiParent = this;
            agent.Show();
        }

        private void modifierLeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNouveauPW agent = new FrmNouveauPW();
            agent.MdiParent = this;
            agent.Show();
        }

        private void aIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
