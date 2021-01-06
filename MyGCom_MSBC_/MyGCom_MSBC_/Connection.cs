using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGCom_MSBC_
{
    class Connection
    {
        public static string user { get; set; }
        public static string rol { get; set; }

        public SqlConnection con;
        public SqlDataAdapter dta;
        public SqlCommand cmd;
        public DataSet dts;
        public SqlDataReader dtr;


        public Connection()
        {
            con = new SqlConnection(@"Data Source=DINA\SQLEXPRESS;Initial Catalog=MSBC_FIN;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=FISTON-KASI;Initial Catalog=MSBC_FIN;Integrated Security=True");
            //Mod.
            cmd = new SqlCommand();
            dta = new SqlDataAdapter(cmd);
            dts = new DataSet();
        }

        public void Executer_Requete(string req /*, string message*/)
        {
            cmd.CommandText = req;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show(message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
        }

        public DataTable Source_Donnees(string req, string tab)
        {
            try
            {
                cmd.CommandText = req;
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dts.Clear();
                dta.Fill(dts, tab);
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
            return dts.Tables[tab];
        }

        public string Afficher(string req, string champ)
        {
            string value = "";
            try
            {

                cmd.CommandText = req;
                con.Open();
                cmd.Connection = con;
                dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    value = dtr[champ].ToString();
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
            return value;
        }

        public void remplirCBO(ComboBox txt, string Query)
        {
            try
            {
                cmd.CommandText = Query;
                con.Open();
                cmd.Connection = con;
                dtr = cmd.ExecuteReader();
                txt.Items.Clear();
                while (dtr.Read())
                {
                    txt.Items.Add(dtr.GetString(0));
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
        }
        public void remplirCBOInt(ComboBox txt, string Query)
        {
            cmd.CommandText = Query;
            con.Open();
            cmd.Connection = con;
            dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                txt.Items.Add(dtr.GetInt64(0));
            }
            con.Close();
        }

        public void RemplirDGV(string req, DataGridView dgv)
        {
            try
            {
                cmd.CommandText = req;
                con.Open();
                cmd.Connection = con;
                dta.SelectCommand = cmd;
                dta.Fill(dts);
                dgv.DataSource = dts.Tables[0];
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message);
            }
        }
    }
}
