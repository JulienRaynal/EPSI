using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    class PersonnelException : Exception
    {
        #region Constructeur
        public PersonnelException(string libelle)
            : base(libelle)
        {
        }
        public PersonnelException()
            : base("Exception class personnel")
        { }
        #endregion
    }
}
