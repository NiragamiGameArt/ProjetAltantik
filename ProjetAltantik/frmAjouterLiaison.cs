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
    public partial class frmAjouterLiaison : Form
    {
        public frmAjouterLiaison()
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
                requête = "insert into liaison(nosecteur, noport_depart, noport_arrivee, distance) values(@nosecteur, @noport_depart, @noport_arrivee, @distance)";
                var commande = new MySqlCommand(requête, Cnx);
                commande.Parameters.AddWithValue("@nosecteur", ((secteur)lbxSecteurs.SelectedItem).GetNoSecteur());
                commande.Parameters.AddWithValue("@noport_depart", ((Port)cmbDepart.SelectedItem).GetNoPort());
                commande.Parameters.AddWithValue("@noport_arrivee", ((Port)cmbArrivee.SelectedItem).GetNoPort());
                commande.Parameters.AddWithValue("@distance", tbxDistance.Text);
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

        private void frmAjouterLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            MySqlDataReader Reader = null;
            try
            {
                string requête;
                maCnx.Open();
                requête = "select * from port";
                var maCmd = new MySqlCommand(requête, maCnx);
                Reader = maCmd.ExecuteReader();
                while (Reader.Read())
                {
                    cmbDepart.Items.Add(new Port((int)Reader["noport"], Reader["nom"].ToString()));
                    cmbArrivee.Items.Add(new Port((int)Reader["noport"], Reader["nom"].ToString()));
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            
            }
            try
            {
                string requête;
                requête = "select * from secteur";
                maCnx.Open();
                var commande = new MySqlCommand(requête, maCnx);
                commande.ExecuteNonQuery();
                Reader = commande.ExecuteReader();
                while (Reader.Read())
                {
                    lbxSecteurs.Items.Add(new secteur((int)Reader["nosecteur"], Reader["nom"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
    }
}
