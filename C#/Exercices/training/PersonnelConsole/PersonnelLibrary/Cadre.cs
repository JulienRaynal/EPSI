using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    public class Cadre : Personnel
    {
        #region enum 
        public enum TypeStatut { aucun, Technique, Administratif, Juridique, Financier }
        #endregion

        #region Attributs
        private double prime;
        private static  double tauxCadre = 0.25;
        private TypeStatut status;
        #endregion

        #region Propriete
        public TypeStatut Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region Methode
        public double Prime { get { return prime; }
        set { if (value > 0 && value < 6000)
                {
                    prime = value;
                }
                else {
                    throw new System.Exception();
                } }
        }
        public override double TauxImposition
        {
            get { return tauxCadre; }
        }
        public override double SalaireNet {
            get { return (SalaireBrut + prime) * TauxImposition; }
        }
        public override double SupplementSalaire
        {
            get { return Prime; }
        }
        public override string Identite
        {
            get { return string.Format("{0}, {1}, {2}, {3} ans, {4:C}, Status: {5}", Id, Nom, Prenom, Age, SalaireBrut, Status); }
        }
        #endregion

        #region Constructeur
        public Cadre(int id, string nom, string prenom, Gender gender, DateTime dateDeNaissance, int salaireBrut, Services service, double prime)
            : base(id, nom, prenom, service, gender, dateDeNaissance, salaireBrut)
        {
            switch(service.Id)
            {
                case 0:
                    Status = TypeStatut.aucun;
                    break;
                case 1:
                    Status = TypeStatut.Technique;
                    break;
                case 2:
                    Status = TypeStatut.Administratif;
                    break;
                case 3:
                    Status = TypeStatut.Juridique;
                    break;
                case 4:
                    Status = TypeStatut.Financier;
                    break;
                default:
                    Status = TypeStatut.aucun;
                    break;
            }
            Prime = prime;
        }
        #endregion
    }
}