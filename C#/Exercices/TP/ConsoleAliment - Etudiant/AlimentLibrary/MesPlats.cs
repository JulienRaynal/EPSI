using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentLibrary
{
    public class MesPlats
    {
        #region Attributs
        private List<Plat> listePlats = new List<Plat>();
        #endregion

        #region CRUD
        // Ajouter un plat : le C dans CRUD
        public bool AjouterPlat(Plat plat)
        {
            /** TODO : A faire - Ajouter le plat s'il n'existe pas déjà */
            if (plat == null)
            {
                throw new Exception("le plat est null");
            }

            Plat p = RechercherPlat(plat.Id);
            if (p == null)
            {
                listePlats.Add(plat);
            }
            return false;
        }

        // Supprimer un plat : le D dans CRUD
        public bool SupprimerPlat(Plat plat)
        {
            return SupprimerPlat(plat.Id);
        }
        public bool SupprimerPlat(int id)
        {
            /** TODO : A faire */
            Plat p = RechercherPlat(id);
            if (p != null)
            {
                listePlats.Remove(p);
                return true;
            }

            return false;
        }

        // Modifier un plat : le U dans CRUD
        public bool ModifierPlat(Plat plat)
        {
            /** TODO : A faire - Il ne faut modifer que la quantité */
            if (plat == null)
            {
                throw new Exception("Plat est null dans la modification : MesPlats");
            }

            Plat p = RechercherPlat(plat.Id);
            if (p != null)
            {
                p = plat;
                return true;
            }
            return false;
        }
        #endregion

        #region Méthodes de recherche
        public Plat RechercherPlat(int id)
        {
            /** TODO : A faire */
            listePlats.Find(delegate (Plat plat)
            {
                return plat.Id == id;
            });

            return null;
        }

        public List<Plat> RechercherPlatsLibelleCommencePar(string libelle)
        {
            listePlats.Find(delegate (Plat plat)
            {
                return plat.Libelle == libelle;
            });

            return null;
        }

        public List<Plat> RechercherPlatsParCalorie(double min, double max)
        {
            /** TODO : A faire 
             * 
             * Retourne tous les plats dont les calories sont dans l'intervalle indiqué
             * 
             **/
            return listePlats.FindAll(delegate (Plat plat)
            {
                return true;
/*                if (plat.TotalCalorie() >= min && plat.TotalCalorie() <= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
            });
            return null;
        }
        #endregion


        public void AfficherPlats()
        {
            foreach (Plat p in listePlats)
            {

                Console.WriteLine(p.FicheDescriptive);
            }
        }
    }
}
