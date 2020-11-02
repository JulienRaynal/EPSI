using System;
using BibliothequeLibrary;

namespace BibliothequeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque bibliotheque = new Bibliotheque();
            
            Console.WriteLine("Ajout des adhérents");
            Adherent jdupond = new Adherent(1, "Jean", "Dupond");
            bibliotheque.AjouterAdherent(jdupond);
            Adherent mdubois = new Adherent(2, "Marie", "Dubois");
            bibliotheque.AjouterAdherent(mdubois);
            
            Console.WriteLine("Ajout des documents");
            bibliotheque.AjouterDocument(new BandeDessine(1, "Thorgal: La galère noire", new DateTime(2014, 10, 23), "Van Hamme", "Rosinsky", 4));
            Livre lesMiserables = new Livre(2, "Les misérables", new DateTime(1862, 3, 30), "Hugo V.", "2-86889-006-7", 15);
            bibliotheque.AjouterDocument(lesMiserables);
            Livre systeme = new Livre(3, "Systèmes multi-agents", new DateTime(2009, 10, 23), "Ferber J.", "2-56784-015-2", 2);
            bibliotheque.AjouterDocument(systeme);

            Console.WriteLine("Liste de tous les documents de la bibliotheque");
            // Affichage des volumes
            foreach (Volume volume in bibliotheque.Documents)
            {
                Console.WriteLine(volume.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("Emprunts");
            if (! bibliotheque.Emprunte(jdupond, lesMiserables))
            {
                Console.WriteLine("Le livre suivant n'a plus d'exemplaires de libre: {0}", lesMiserables.Description);
            }
            if (!bibliotheque.Emprunte(jdupond, systeme))
            {
                Console.WriteLine("Le livre suivant n'a plus d'exemplaires de libre: {0}", systeme.Description);
            }
            if (!bibliotheque.Emprunte(mdubois, systeme))
            {
                Console.WriteLine("Le livre suivant n'a plus d'exemplaires de libre: {0}", systeme.Description);
            }
            if (!bibliotheque.Emprunte(jdupond, systeme))
            {
                Console.WriteLine("Le livre suivant n'a plus d'exemplaires de libre: {0}", systeme.Description);
            }
            Console.WriteLine("");
            
            Console.WriteLine("Liste des emprunts");
            // Affichage des emprunts de chaque adhérent
            bibliotheque.AfficherEmprunts();
            // Affichage des emprunts d'un adhérent
            bibliotheque.AfficherEmpruntsAdherent(jdupond);
            
            // Affichage des emprunteurs d'un document inexistant
            bibliotheque.AfficherEmprunteursDocument(99);

            // Affichage des emprunteurs du livre numéro 3
            bibliotheque.AfficherEmprunteursDocument(3);
        }
    }
}