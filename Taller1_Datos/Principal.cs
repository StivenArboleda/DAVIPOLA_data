using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.IO;

namespace Taller1_Datos
{   
    class Principal
    {

        public Principal(string codDepar, string codMun, string department, string municipality, string type)
        {
            this.codDepar = codDepar;
            this.codMun = codMun;
            this.departament = department;
            this.municipality = municipality;
            this.type = type;
        }

        public string codDepar { get; set; }
        public string codMun { get; set; }
        public string departament { get; set; }
        public string municipality { get; set; }
        public string type { get; set; }
    }



}
