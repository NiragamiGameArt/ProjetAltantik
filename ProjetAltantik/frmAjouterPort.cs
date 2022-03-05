using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetAltantik
{
    public partial class frmAjouterPort : Form
    {
        public frmAjouterPort()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection Cnx;
            Cnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                //MessageBox.Show("open");
                string requête;
                Cnx.Open();
                requête = "insert into port(nom) values(@nom)";
                var commande = new MySqlCommand(requête, Cnx);
                commande.Parameters.AddWithValue("@nom", tbxNomPort.Text);
                commande.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (Cnx is object & Cnx.State == ConnectionState.Open)
                {
                    Cnx.Close();
                }
            }
            MessageBox.Show("Port Ajouter!");
        }
    }
}
