using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class Plat
    {
        private int id;
        private string libelle;

        /*
         * Les attributs suivants indiquent le maximum ou le minimun que l'on veut pour ce plat
         * A fixer dans le constructeur
         * 
         * 
         * TODO : ajouter les bornes min, max dans le constructeur
         */
        private double lipideMax;
        private double selMax;
        private double glucideMin;
        private double proteineMin;
        private double fibreMin;

        private List<PlatAliment> aliments = new List<PlatAliment>();

        #region Propriétés
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

        public string FicheDescriptive
        {
            get
            {
                /** TODO : A Faire 
                 * 
                 * Il faqut afficher la quantité totale de lipide, glucide, ...
                 * 
                 */
                return ($"Plat a afficher : {TotalCalorie()}") ;
            }
        }
        #endregion

        #region Constructeur
        public Plat(int id, string libelle)
        {
            /** TODO : A faire 
             * Aucune contrainte sur les bornes min, max
             */
            Id = id;
            Libelle = libelle;

        }
        public Plat(int id, string libelle, double lipideMax, double selMax, double glucideMin,
                    double proteineMin,double fibreMin)
        {
            /** TODO : A faire */
            Id = id;
            Libelle = libelle;
            this.lipideMax = lipideMax;
            this.selMax = selMax;
            this.glucideMin = glucideMin;
            this.proteineMin = proteineMin;
            this.fibreMin = fibreMin;

        }
        #endregion

        #region CRUD
        // Ajouter un platAliment : le C dans CRUD
        public bool AjouterPlatAliment(PlatAliment platAliment)
        {
            if (platAliment == null)
                return false;

            /** TODO : faire la recherche */
            PlatAliment p = RechercherPlatAliment(platAliment.Aliment.Id);
            if (p == null)
            {
               if (platAliment.Aliment.Lipide <= lipideMax && platAliment.Aliment.Glucide <= glucideMin 
                    && platAliment.Aliment.Sel <= selMax && platAliment.Aliment.Proteine <= proteineMin 
                    && platAliment.Aliment.Fibre <= fibreMin)
                {
                    aliments.Add(platAliment);
                }

                return true;
            }
            return false;
        }

        // Supprimer un platAliment : le D dans CRUD
        public bool SupprimerPlatAliment(PlatAliment platAliment)
        {
            /** TODO : faire l'appel à la méthode de suppression  SupprimerPlatAliment(int id) */
            if (platAliment != null)
            {
                SupprimerPlatAliment(platAliment.Aliment.Id);
            }
            return false;
        }
        public bool SupprimerPlatAliment(int id)
        {
            PlatAliment p = RechercherPlatAliment(id);
            if (p == null)
                return false; // Le platAliment n'existe pas

            aliments.Remove(p);
            return true;
        }

        // Modifier un platAliment : le U dans CRUD
        public bool ModifierPlatAliment(PlatAliment platAliment)
        {
            if (platAliment == null)
                return false;

            /** TODO : corriger la recherche
            PlatAliment platAlimentAModifier = RechercherPlatAliment(platAliment.Id);
            if (platAlimentAModifier == null)
                return false; // Le platAliment n'existe pas
            */
            PlatAliment p = RechercherPlatAliment(platAliment.Aliment.Id);
            if (p == null)
            {
                return false;
            }

            // On fait des modification
            p = platAliment;
            
            /** TODO : Faire la modification de la quantité */
            return true;
        }
        #endregion

        #region Méthodes de recherche
        public PlatAliment RechercherPlatAliment(int id)
        {
            if (aliments != null)
            {
                /** TODO : faire la recherche */
                aliments.Find(delegate (PlatAliment platAliment)
                {
                    return platAliment.Aliment.Id == id;
                });
            }
            return null;
        }
        #endregion

        /** TODO : faire toutes les méthodes suivantes : */
        public double TotalLipides()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Lipide * p.PoidsAliment / 100);
            }
            return total;
        }
        public double TotalGlucides()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Glucide * p.PoidsAliment / 100);
            }
            return total;
        }
        public double TotalProteines()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Proteine * p.PoidsAliment / 100);
            }
            return total;
        }
        public double TotalFibres()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Fibre * p.PoidsAliment / 100);
            }
            return total;
        }
        public double TotalSels()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Sel * p.PoidsAliment / 100);
            }
            return total;
        }
        public double TotalCalorie()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += (p.Aliment.Calorie * p.PoidsAliment / 100);
            }
            return total;
        }

        public double Poids()
        {
            double total = 0;
            foreach (PlatAliment p in aliments)
            {
                total += p.PoidsAliment;
            }
            return total;
        }
    }
}
