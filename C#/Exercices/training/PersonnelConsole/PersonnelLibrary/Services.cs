using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    public class Services
    {
        #region Attributs
        private int id;
        private string libelle;
        #endregion

        #region Methodes
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        #endregion

        #region Constructeur
        public Services(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
        #endregion
    }
}
