using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_SerializacionGenerica
{
    [Serializable]
    public class Alumno
    {
        public string NumControl { get; set; }
        public string Nombre { get; set; }
        public byte Semestre { get; set; }
    }
}
