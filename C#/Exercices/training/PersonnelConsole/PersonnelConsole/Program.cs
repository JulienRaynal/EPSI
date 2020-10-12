using System;
using PersonnelLibrary;
using System.Collections.Generic;

namespace PersonnelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Services service1 = new Services(1, "Production");
            Services service2 = new Services(2, "Comptabilité");
            Services service3 = new Services(3, "Direction");

            Employe p1 = new Employe(1, "DUPONT", "Charles", Personnel.Gender.male, new DateTime(1998, 04, 12), 1500, service1, 14);
            Employe p2 = new Employe(2, "KERBAN", "Henry", Personnel.Gender.female, new DateTime(1981, 09, 24), 1500, service1, 7);
            Employe p3 = new Employe(3, "CHAMPOT", "Paul", Personnel.Gender.male, new DateTime(1981, 03, 17), 1500, service1, 6);
            Cadre p4 = new Cadre(4, "JOULIE", "Alexandre", Personnel.Gender.female, new DateTime(1987, 11, 21), 2100, service2, 100);
            Cadre p5 = new Cadre(5, "MITAUT", "Marcel", Personnel.Gender.female, new DateTime(1972, 10, 06), 6000, service3, 2000);

            List<Personnel> listPersonne = new List<Personnel>();
            listPersonne.AddRange(new Personnel[] { p1, p2, p3, p4, p5 });
            List<Services> listService = new List<Services>();
            listService.AddRange(new Services[] { service1, service2, service3 });

            Entreprise entreprise = new Entreprise(listPersonne, listService);

            Console.WriteLine(p1.Identite);
            Console.WriteLine(p2.Identite);
            Console.WriteLine(p3.Identite);
            Console.WriteLine(p4.Identite);
            Console.WriteLine(p5.Identite); 
        }
    }
}
