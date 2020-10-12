using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    public class Entreprise
    {
        #region Attribut
        private List<Personnel> listPersonnel;
        private List<Services> listService;
        #endregion

        #region Propriété
        public List<Personnel> ListPersonnel
        {
            get { return listPersonnel; }
            set { listPersonnel = value; }
        }
        public List<Services> ListService
        {
            get { return listService; }
            set { listService = value; }
        }
        #endregion

        #region Methode CRUD
        public bool AjouterPersonne(Employe personne)
        {
            if (personne == null)
            {
                throw new PersonneNullReferenceException("Personne à AJOUTER n'as pas pu être ajouté car elle est null");
            }

            Employe p = RechercherPersonne(personne.Id);
            if (p == null)
            {
                ListPersonnel.Add(personne);
                p = personne;
            }

            return false;
        }
        public bool ModifierPersonne(Employe personne)
        {
            if (personne == null)
            {
                throw new PersonneNullReferenceException("Le personne a MODIFIER n'as pas été trouvé dans la liste des employées");
            }

            Employe p = RechercherPersonne(personne.Id);
            if (p != null)
            {
                p = personne;
                return true;
            }
            return false;
        }
        public bool SupprimerPersonne(Employe personne)
        {
            if (personne == null)
            {
                throw new PersonneNullReferenceException("La personne a SUPPRIMER n'as pas été trouvé");
            }

            return SupprimerPersonne(personne.Id);
        }
        public bool SupprimerPersonne(int id)
        {
            Employe p = RechercherPersonne(id);
            if (p != null)
            {
                ListPersonnel.Remove(p);
                return true;
            }
            return false;
        }
        public Employe RechercherPersonne(int id)
        {
            listPersonnel.Find(delegate (Personnel personne)
            {
                return personne.Id == id;
            });

            return null;
        }
        public List<Employe> RechercherPersonneCommencantPar(string nom)
        {
            listPersonnel.Find(delegate (Personnel personne)
            {
                return personne.Nom == nom;
            });

            return null;
        }
        public void AfficherPersonne()
        {
            foreach(Employe personne in ListPersonnel)
            {
                Console.WriteLine(personne.Identite);
            }
        }
        public List<Employe> AfficherLesPersonnesDuService(int id)
        {
            ListPersonnel.FindAll(delegate (Personnel personne)
            {
                return personne.Service.Id == id;
            });

            return null;
        }
        #endregion

        #region Methode
        public double getMasseSalarial()
        {
            double masseSalarial = 0;
            foreach(Personnel employee in ListPersonnel)
            {
                masseSalarial += employee.SalaireBrut;
            }
            return masseSalarial;
        }

        public Dictionary<int, double> getMasseSalarialParService()
        {
            Dictionary<int, double> masseSalarialParService = new Dictionary<int, double>();
            foreach(Personnel p in ListPersonnel)
            {
                if (! masseSalarialParService.ContainsKey(p.Service.Id))
                {
                    masseSalarialParService.Add(p.Service.Id, p.SalaireBrut);
                } else
                {
                    double cumul = masseSalarialParService[p.Service.Id];
                    cumul += p.SalaireBrut;
                    masseSalarialParService[p.Service.Id] = cumul;
                }
            }
            return masseSalarialParService;
        }

        public void calculateSalary()
        {
            int moyenneSalaire = 0;
            int salaireMinimum = 0;
            int salaireMaximum = 0;
            int ecart = 0;
            foreach(Personnel p in ListPersonnel)
            {
                moyenneSalaire += p.SalaireBrut;
                if (p.SalaireBrut < salaireMinimum)
                {
                    salaireMinimum = p.SalaireBrut;
                } else if (p.SalaireBrut > salaireMaximum)
                {
                    salaireMaximum = p.SalaireBrut;
                }
            }

            moyenneSalaire = moyenneSalaire / ListPersonnel.Count;
            ecart = salaireMaximum - salaireMinimum;

            Console.WriteLine(String.Format("La moyenne salarial est {0} \nLe salaire minimum est {1} \nLe salaire maximum est {2} \n" +
                "L'écart de salaire est de {3}", moyenneSalaire, salaireMinimum, salaireMaximum, ecart));
        }
        #endregion

        #region Constructeur
        public Entreprise(List<Personnel> listPersonnel, List<Services> listService)
        {
            ListPersonnel = listPersonnel;
            ListService = listService;
        }
        #endregion
    }
}