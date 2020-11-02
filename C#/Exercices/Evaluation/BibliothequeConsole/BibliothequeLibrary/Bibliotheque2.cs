using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    public class Bibliotheque
    {
        private List<Document> listeDocuments = new List<Document>();
        private List<Adherent> listeAdherents = new List<Adherent>();

        public List<Document> Documents
        {
            get { return new List<Document>(listeDocuments); }
        }
        public List<Adherent> Adherents
        {
            get { return new List<Adherent>(listeAdherents); }
        }

        #region Méthodes CRUD Adherent
        public bool AjouterAdherent(Adherent adherent)
        {
            /** TODO : un peu de vérification tout de même */
            if (adherent == null)
            {
                return false;
            }

            Adherent a = RechercherAdherent(adherent.Id);
            if ( a != null )
            {
                return false;
            }
            
            listeAdherents.Add(adherent);
            return true;
        }

        //Ajout de RechercherAdherent afin de ne pas ajouter deux fois le même
        public Adherent RechercherAdherent(int id)
        {
            return listeAdherents.Find(
                delegate (Adherent a) { return a.Id == id; });
        }

        // Vous parlez de la methode de suppression d'adherent mais vous nous dites que les adherents peuvent seulement être ajouté

        #endregion

        #region Méthodes CRUD Document

        /** TODO : A Faire */
        public bool AjouterDocument(Document document)
        {
            if (document == null)
            {
                return false;
            }

            Document d = RechercherDocument(document.Id);
            if (d != null)
            {
                return false;
            }

            listeDocuments.Add(document);
            return true;
        }

        public Document RechercherDocument(int id)
        {
            return listeDocuments.Find(delegate (Document document)
            {
                return document.Id == id;
            });
        }

        public bool SupprimerDocument(Document document)
        {
            if (document == null)
            {
                return false;
            }

            Document d = RechercherDocument(document.Id);

            if (d != null)
            {
                listeDocuments.Remove(document);
                return true;
            }

            return false;
        }
        #endregion

        public bool Emprunte(Adherent a, Volume v)
        {
            // Retroune vrai si l'adhérent a pu emprunter le document
            /** TODO : A Faire */
            if (a == null || v == null)
            {
                return false;
            }

            Adherent adherentRecherche = RechercherAdherent(a.Id);
            Document documentRecherche = RechercherDocument(v.Id);
            if (adherentRecherche == null || documentRecherche == null)
            {
                return false;
            }

            bool empruntFait = a.Emprunte(v);
            if (empruntFait == true)
            {
                return true;
            }
            return false ;
        }
        public void AfficherEmprunts()
        {
            /** TODO : A Faire */
            foreach(Adherent a in listeAdherents)
            {
                a.AfficherEmprunts();
            }

        }

        public void AfficherEmprunteursDocument(int id)
        {
            /** TODO : A Faire */
            Document d = RechercherDocument(id);


            if (d != null)
            {
                foreach (Adherent a in listeAdherents)
                {
                    Emprunt aDoc = a.ListeEmprunts.Find(delegate (Emprunt e)
                    {
                        return e.IdVolumeEmprunter == id;
                    });
                    if (aDoc != null)
                    {
                        Document livreEmprunter = RechercherDocument(aDoc.IdVolumeEmprunter);
                        Console.WriteLine(a.Description + ":" + livreEmprunter.Description);
                    }
                }
            }
        }

        public void AfficherEmpruntsAdherent(Adherent adherent)
        {
            /** TODO : A Faire */
            if (adherent != null)
            {


                Adherent a = RechercherAdherent(adherent.Id);
                if (a != null)
                {
                    Console.WriteLine(a.Description);
                    Console.WriteLine($"nombre d'emprunts total = {a.nombreEmpruntsAdherent()}");
                }
            }

        }
    }
}
