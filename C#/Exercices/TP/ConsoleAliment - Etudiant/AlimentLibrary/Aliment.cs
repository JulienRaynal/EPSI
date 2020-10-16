using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class Aliment
    {
        private int id;
        private string libelle;
        // Les quantité suivantes sont exprimées pour 100 g de produit
        // Exemple : lipide = 21 ==> 21g de lipide pour 100 g de cet aliment ou 21 % de lipide dans cet aliment
        private double lipide;
        private double glucide;
        private double proteine;
        private double fibre;
        private double sel;
        // Calorie pour 100 g d'aliment
        private double calorie;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Libelle
        {
            get
            {
                return libelle;
            }
            set
            {
                libelle = value;
            }
        }
        public double Lipide
        {
            get
            {
                return lipide;
            }
            set
            {
                lipide = value;
            }
        }
        public double Glucide
        {
            get
            {
                return glucide;
            }
            set
            {
                glucide = value;
            }
        }
        public double Proteine
        {
            get
            {
                return proteine;
            }
            set
            {
                proteine = value;
            }
        }
        public double Fibre
        {
            get
            {
                return fibre;
            }
            set
            {
                fibre = value;
            }
        }
        public double Sel
        {
            get
            {
                return sel;
            }
            set
            {
                sel = value;
            }
        }
        public double Calorie
        {
            get
            {
                return calorie;
            }
            set
            {
                calorie = value;
            }
        }

        #region Constructeur
        /** TODO : A faire */
        public Aliment(int id, String libelle, double lipides, double glucides, double proteines, double fibres, double sel, double calories)
        {
            Id = id;
            Libelle = libelle;
            Lipide = lipides;
            Glucide = glucides;
            Proteine = proteines;
            Fibre = fibres;
            Sel = sel;
            Calorie = calories;
        }
        #endregion
    }
}
