using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Documentacion
    {
        int codigo;
        string nombre;
        string lugarobtencion;

        [DataMember]
        public int Codigo
        {
            get { return codigo; }
            set
            {
                if (value < 0)
                    throw new Exception("Código Incorrecto");
                else
                    codigo = value;
            }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == "" || value.Length > 30)
                    throw new Exception("Error en Tipo de Nombre");
                else
                    nombre = value;
            }
        }

        [DataMember]
        public string LugarObtencion
        {
            get { return lugarobtencion; }
            set
            {
                if (value == "" || value.Length > 30)
                    throw new Exception("Error en Lugar de Obtención");
                else
                    lugarobtencion = value;
            }
        }

        public Documentacion(int cod, string nombre, string lugar)
        {
            Codigo = cod;
            Nombre = nombre;
            LugarObtencion = lugar;
        }
        public Documentacion()
        {
        }
    }
}
