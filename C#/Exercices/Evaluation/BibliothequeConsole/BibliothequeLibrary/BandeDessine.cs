using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class BandeDessine : Volume
    {
        // ajout des attributs
        #region Attributs
        private string scenariste;
        #endregion
        public string Scenariste { get; private set; }

        override public string Description
        {
            get
            {
                return string.Format("{0} (num {1}) - {2} paru le {3}, nom du dessinateur : {4}, scenariste {5}", base.GetType().Name , Id, Titre, DateParution.ToShortDateString(), Auteur, Scenariste);
            }
        }

        public BandeDessine(int id, string titre, DateTime dateParution, string auteur, string scenariste, int nbExemplaire)
            : base(id, titre, dateParution, nbExemplaire, auteur)
        {
            /** TODO : A compléter */
            Scenariste = scenariste;
        }
    }
}
