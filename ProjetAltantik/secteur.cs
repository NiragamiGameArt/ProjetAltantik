using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAltantik
{
    internal class secteur
    {
        private int nosecteur;
        private string nom;

        public secteur(int nopsecteur, string nom)
        {
            this.nom = nom;
            this.nosecteur = nopsecteur;

        }
        public string GetNomSecteur()
        {
            return nom;
        }
        public int GetNoSecteur()
        {
            return nosecteur;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
