using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProduction.Class
{
    public class Box
    {
        public bool IsOk { get; set; }
        private string name;
        private DateTime manufacturingTime;


        public Box(string _name)
        {
            this.name = _name;
            IsOk = true;
            manufacturingTime = DateTime.Now;
        }

        // Génération aléatoire d'une box déféctueuse
    }
}
