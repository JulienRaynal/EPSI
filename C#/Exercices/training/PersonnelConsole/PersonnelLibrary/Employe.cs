using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    public class Employe : Personnel
    {
        private int nbRtt;
        private static double tauxEmploye = 0.2;

        #region Propriete
        public int NbRtt
        {
            get { return nbRtt; }
            set { if (value > 0 && value < 26)
                {
                    nbRtt = value;
                }
                else
                {
                    throw new System.Exception();
                } }
        }
        #endregion

        #region Methode
        public override double TauxImposition { 
            get { return tauxEmploye; }
        }
        public override double SalaireNet
        {
            get { return SalaireBrut * TauxImposition; }
        }
        public override double SupplementSalaire
        {
            get { return 0; }
        }
        #endregion



        #region Constructeur
        public Employe(int id, string nom, string prenom, Gender gender, DateTime dateDeNaissance, int salaireBrut, Services service, int nbRtt)
            : base(id, nom, prenom, service, gender, dateDeNaissance, salaireBrut)
        {
            NbRtt = nbRtt;
        }
        #endregion
    }
}
