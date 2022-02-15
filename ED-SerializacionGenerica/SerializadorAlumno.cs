using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ED_SerializacionGenerica
{
    public class SerializadorAlumno
    {
        public void Guardar(string ruta, Alumno alumno)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, alumno);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }

        public Alumno Cargar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                return (Alumno)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
