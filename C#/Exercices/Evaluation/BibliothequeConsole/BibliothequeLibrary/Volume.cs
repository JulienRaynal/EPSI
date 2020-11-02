using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class Volume : Document
    {
        // ajout des attributs nécessaire
        #region Attributs
        private int nombreExemplaire;
        private int nombreExemplaireEmprunter = 0;
        private string auteur;
        #endregion

        //Creation des propriétes
        #region Proprietes
        public int NombreExemplaire { 
            get { return nombreExemplaire; }
            set { nombreExemplaire = value; }
        }

        public int NombreExemplaireEmprunter
        {
            get { return nombreExemplaireEmprunter; }
            set { nombreExemplaireEmprunter = value; }
        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        #endregion

        public bool Emprunter()
        {
            /** TODO : A Faire */
            if (NombreExemplaire - NombreExemplaireEmprunter <= 0) {
                return false;
            }
            nombreExemplaireEmprunter += 1;
            return true;

        }

        public int NombreExemplaireDisponible()
        {
            return (NombreExemplaire - NombreExemplaireEmprunter);
        }

        override public string Description
        {
            get
            {
                return string.Format("{0}, auteur : {1}, nombre exemplaire restant : {2}", base.Description, Auteur, NombreExemplaire);
            }
        }



        /** TODO : Faire le constructeur */
        public Volume(int id, string titre, DateTime dateParution, int nombreExemplaire, string auteur)
            : base(id, titre, dateParution)
        {
            NombreExemplaire = nombreExemplaire;
            Auteur = auteur;
        }

    }
}
