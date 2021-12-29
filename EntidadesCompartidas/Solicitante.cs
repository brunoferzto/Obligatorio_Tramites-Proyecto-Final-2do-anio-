using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EntidadesCompartidas
{
    [DataContract]
    public class Solicitante : Usuario
    {
        string telefono;

        [DataMember]
        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (value.Length != 9)
                    throw new Exception("Valor Incorrecto, el Teléfono deben ser 8 digitos");
                else
                    telefono = value;
            }
        }
        public Solicitante(string nom, string cont, int ced, string tele)
            : base(nom, cont, ced)
        {
            Telefono = tele;
        }

        public Solicitante()
        {

        }

    }
}
