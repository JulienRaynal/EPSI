using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class Livre: Volume
    {
        #region Attributs
        private string isbn;
        #endregion
        public string ISBN { get; private set; }


        override public string Description
        {
            get
            {
                return string.Format("{0}, isbn : {1}", base.Description, ISBN);
            }
        }

        public Livre(int id, string titre, DateTime dateParution, string auteur, string isbn, int nbExemplaire)
            :base(id, titre, dateParution, nbExemplaire, auteur)
        {
            ISBN = isbn;
        }
    }
}
