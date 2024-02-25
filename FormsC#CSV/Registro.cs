using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsC_CSV
{
    internal class Registro
    {
       
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return $"{Nombre}, {Edad}, {Email}";
            }
        
    }
}
