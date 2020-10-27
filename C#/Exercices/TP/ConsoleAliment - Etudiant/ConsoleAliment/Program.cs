using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlimentLibrary;

namespace ConsoleAliment
{
    class Program
    {
        static void Main(string[] args)
        {
            Plat ratatouille = new Plat(1, "Ratatouille", 10000, 10000, 10000, 10000, 10000);

            Aliment tomate = new Aliment(1, "tomate", 2, 15, 1, 5, 0.5, 135); // L, G, P, F, S, Calorie
            ratatouille.AjouterPlatAliment(new PlatAliment(tomate, 2100)); // 2.1 Kg
            Aliment courgette = new Aliment(2, "courgette", 4, 21, 1, 3, 0.8, 161); // L, G, P, F, S
            ratatouille.AjouterPlatAliment(new PlatAliment(courgette, 1800)); // 1.8 Kg

            MesPlats mesPlats = new MesPlats();
            mesPlats.AjouterPlat(ratatouille);

            mesPlats.AfficherPlats();

            List<Plat> liste = mesPlats.RechercherPlatsParCalorie(5, 600);
/*            AfficherPlats(liste);
*/        }

/*        static void AfficherPlats(List<Plat> liste)
        {
            foreach (Plat p in liste)
            {
                Console.WriteLine(p.FicheDescriptive);
            }
        }*/
    }
}
