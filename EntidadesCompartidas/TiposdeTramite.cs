using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntidadesCompartidas
{
    [DataContract]
    public class TiposdeTramite
    {
        List<Documentacion> documentolista;
        string codigo, nombre, descripcion;
        int precio;

        [DataMember]
        public List<Documentacion> DocumentoLista
        {
            get { return documentolista; }
            set
            {
                if (value == null)
                    throw new Exception("Debe ingresar Documentación");
                else
                    documentolista = value;
            }
        }

        [DataMember]
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Length == 9 && value.Substring(0, 4).All(char.IsNumber) && value.Substring(4, 5).All(char.IsLetter))
                {
                    codigo = value;
                }
                else
                    throw new Exception("Código Incorrecto");
            }
        }
        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == "" || value.Length > 30)
                    throw new Exception("Error en el Nombre");
                else
                    nombre = value;
            }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value == "" || value.Length > 100)
                    throw new Exception("Error en la Descripcion");
                else
                    descripcion = value;
            }
        }

        [DataMember]
        public int Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new Exception("El Precio Ingresado es Incorrecto");
                else
                    precio = value;
            }
        }

        public TiposdeTramite(List<Documentacion> lista, string cod, string nom, int prec, string desc)
        {
            DocumentoLista = lista;
            Codigo = cod;
            Nombre = nom;
            Precio = prec;
            Descripcion = desc;
        }

        public TiposdeTramite()
        {
        }
    }
}