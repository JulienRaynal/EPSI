using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class Emprunt
    {
        /** TODO: TOUT EST A FAIRE **/
        // ajout de l'attribut
        #region Attribut
        private DateTime dateEmprunt;
        private int idEmprunteur;
        private int idVolumeEmprunter;
        #endregion

        //ajout de la propriété
        #region Propriété
        public DateTime DateEmprunt
        {
            get { return dateEmprunt; }
            set { dateEmprunt = value; }
        }

        public int IdEmprunteur
        {
            get { return idEmprunteur; }
            set { idEmprunteur = value; }
        }

        public int IdVolumeEmprunter
        {
            get { return idVolumeEmprunter; }
            set { idVolumeEmprunter = value; }
        }
        #endregion

        #region Methode
        public string Description()
        {
            return ($" Emprunteur = {idEmprunteur} // Volume emprunté = {idVolumeEmprunter}");
        }
        #endregion

        #region Constructeur
        public Emprunt (DateTime dateEmprunt, int emprunteur, int volumeEmprunter)
        {
            DateEmprunt = dateEmprunt;
            idEmprunteur = emprunteur;
            idVolumeEmprunter = volumeEmprunter;
        }
        #endregion

    }
}
