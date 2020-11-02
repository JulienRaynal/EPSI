using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeLibrary
{
    // pas d'existence réel = abstract ?
    public class Document
    {
        private int id;
        private string titre;
        private DateTime dateParution;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public DateTime DateParution { get => dateParution; set => dateParution = value; }

        public virtual string Description
        {
            get
            {
                return string.Format("{0} (num {1}) - {2} paru le {3}",
                                GetType().Name, Id, Titre, DateParution.ToShortDateString());
            }
        }

        public Document(int id, string titre, DateTime dateParution)
        {
            Id = id;
            Titre = titre;
            DateParution = dateParution;
        }

        
    }
}
