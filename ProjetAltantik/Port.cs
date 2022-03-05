using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAltantik
{
    internal class Port
    {
        private int noport;
        private string nom;

        public Port(int noport, string nom )
        {
            this.nom = nom;
            this.noport = noport;

        }
        public string GetNomPort()
            {
                return nom;
            }
        public int GetNoPort()
        {
            return noport;
        }
        public override string ToString()
        {
            return nom;      
        }
    }
}
