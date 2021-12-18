using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lambda_WindowsForm
{
    class Employe
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Ville { get; set; }

        public override string ToString()
        {
            return string.Format("[Id:{0} Nom:{1} Prenom:{2} DateNaissance:{3} Ville:{4}]",
                ID,Nom,Prenom,DateNaissance,Ville);
        }
    }
}
