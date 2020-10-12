using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelLibrary
{
    class PersonneNullReferenceException : PersonnelException
    {
        public PersonneNullReferenceException(string libelle)
            : base(libelle)
        {}
        public PersonneNullReferenceException()
            : base()
        { }
    }
}
