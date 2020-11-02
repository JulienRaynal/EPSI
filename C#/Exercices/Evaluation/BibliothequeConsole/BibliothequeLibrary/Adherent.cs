using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class Adherent
    {
        // Liste des emprunts
        // ajout de new sinon erreur probable
        private List<Emprunt> listeEmprunts = new List<Emprunt>();

        // ajout des attributs nécessaire
        #region Attributs
        private int id;
        private string nom;
        private string prenom;
        #endregion

        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        // besoin de cette methode pour la fonction AfficherEmprunteursDocument dans bibliothèque
        public List<Emprunt> ListeEmprunts { get { return listeEmprunts; } }

        public Adherent(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public string Description
        {
            get
            {
                return string.Format("Adherent n°{0}, {1} {2}", Id, Nom, Prenom);
            }
        }


        public bool Emprunte(Volume volume)
        {
            /** TODO : A Faire */
            if (volume == null)
            {
                throw new Exception();
            }

            // ajout possible d'une methode de verification si il possède déjà l'emprunt et que l'on veut l'en empecher
            if (volume.Emprunter() != true) {
                return false;
            }

            Emprunt e = new Emprunt(new DateTime(), Id, volume.Id);

            listeEmprunts.Add(e);
            return true;
        }

        public void AfficherEmprunts()
        {
            /** TODO : A Faire */
            foreach(Emprunt e in listeEmprunts)
            {
                if (listeEmprunts.Count() > 0)
                Console.WriteLine(e.Description());
            }
        }

        // permet d'afficher le nombre d'emprunts total
        public int nombreEmpruntsAdherent()
        {
            return listeEmprunts.Count() ;
        }

    }
}
