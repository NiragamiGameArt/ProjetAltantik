using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAltantik
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void miAjouterSecteur_Click(object sender, EventArgs e)
        {
            frmAjouterSecteur ajouterSecteur = new frmAjouterSecteur();
            ajouterSecteur.Show();
        }

        private void miAjouterPort_Click(object sender, EventArgs e)
        {
            frmAjouterPort ajouterPort = new frmAjouterPort();
            ajouterPort.Show();
        }

        private void miAjouterLiaison_Click(object sender, EventArgs e)
        {
            frmAjouterLiaison ajouterLiaison = new frmAjouterLiaison();
            ajouterLiaison.Show();
        }
    }
}
