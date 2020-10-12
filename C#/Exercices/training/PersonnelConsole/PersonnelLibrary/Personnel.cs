using System;

namespace PersonnelLibrary
{
    public abstract class Personnel
    {
        public enum Gender { male, female };

        #region attributs
        private int id;
        private string nom;
        private string prenom;
        private Services service;
        private DateTime dateDeNaissance;
        private Gender gender;
        private string adresse;
        private int salaireBrut;
        private int age;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            private set {
                if (value == null || value.Length == 0)
                {
                    throw new PersonnelInvalidAttributeException("Le nom est invalide");
                } else
                {
                    nom = value;
                }
            }
        }
        public string Prenom
        {
            get { return prenom; }
            private set {
                if (value == null || value.Length == 0)
                {
                    throw new PersonnelInvalidAttributeException("Le prenom est invalide");
                } else
                {
                    prenom = value;
                }
            }
        }
        public Services Service
        {
            get { return service; }
            set { service = value; }
        }
        public DateTime DateDeNaissance
        {
            get { return dateDeNaissance; }
            private set { 
                if ((int)Math.Floor(DateTime.Now.Subtract(value).TotalDays / 365) < 18)
                {
                    throw new PersonnelInvalidAttributeException("date de naissance");
                } else
                {
                    dateDeNaissance = value;
                }
            }
        }
        public Gender Genre
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public int SalaireBrut
        {
            get { return salaireBrut; }
            set { salaireBrut = value; }
        }
        public int Age
        {
            get { return (int)Math.Floor(DateTime.Now.Subtract(DateDeNaissance).TotalDays / 365); }
        }
        public virtual string Identite
        {
            get { return string.Format("{0}, {1}, {2}, {3} ans, {4:C}", Id, Nom, Prenom, Age, SalaireBrut); }
        }
        public abstract double TauxImposition { get; }
        public abstract double SalaireNet { get; }
        public abstract double SupplementSalaire { get; }
        #endregion

        #region Constructeur
        public Personnel(int id, string nom, string prenom, Services service, Gender gender, DateTime dateDeNaissance, int salaireBrut)
            : this(id, nom, prenom, service, gender, dateDeNaissance)
        {
            SalaireBrut = salaireBrut;
        }
        public Personnel(int id, string nom, string prenom, Services service, Gender gender, DateTime dateDeNaissance)
            : this(id, nom, prenom, service, gender)
        {
            DateDeNaissance = dateDeNaissance;
        }
        public Personnel(int id, string nom, string prenom, Services service, Gender gender)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Service = service;
            Genre = gender;
        }
        #endregion
    }
}
