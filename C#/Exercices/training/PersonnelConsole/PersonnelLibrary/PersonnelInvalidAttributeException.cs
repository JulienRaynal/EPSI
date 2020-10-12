using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    class PersonnelInvalidAttributeException : PersonnelException
    {
        #region Constructeur
        public PersonnelInvalidAttributeException(string libelle)
            : base(libelle)
        {
        }
        public PersonnelInvalidAttributeException()
            : base("Exception attribut invalide exception")
        {
        }
        #endregion
    }
}
