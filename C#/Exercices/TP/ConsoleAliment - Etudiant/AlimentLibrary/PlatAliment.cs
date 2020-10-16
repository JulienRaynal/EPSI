using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class PlatAliment
    {
        #region Propriete
        private Aliment aliment;
        private double poidsAliment;
        #endregion

        #region Methode
        public Aliment Aliment
        {
            get { return aliment; }
            set { aliment = value; }
        }
        public double PoidsAliment
        {
            get { return poidsAliment; }
            set { poidsAliment = value; }
        }
        #endregion
        /** TODO : Tout est à faire */
        public PlatAliment(Aliment aliment, double poidsAliment)
        {
            Aliment = aliment;
            PoidsAliment = poidsAliment;
        }
    }
}
