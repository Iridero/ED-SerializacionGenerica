using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ED_SerializacionGenerica
{
    public class Serializador<T>
    {
        public void Guardar(string ruta, T elemento)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, elemento);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }

        public T Cargar(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                return (T)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
