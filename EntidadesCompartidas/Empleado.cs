using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntidadesCompartidas
{
    [DataContract]
    public class Empleado : Usuario
    {
        string horainicio, horafin;

        [DataMember]
        public string HoraInicio
        {
            get { return horainicio; }
            set
            {
                if (value == "")
                    throw new Exception("Valor Incorrecto");
                else
                    horainicio = value;
            }
        }

        [DataMember]
        public string HoraFin
        {
            get { return horafin; }
            set
            {
                if (value == "")
                    throw new Exception("Valor Incorrecto");
                else
                    horafin = value;
            }
        }

        public Empleado(string nom, string cont, int ced, string hIni, string hFin)
            : base(nom, cont, ced)
        {
            HoraInicio = hIni;
            HoraFin = hFin;
        }
        public Empleado()
        {

        }
    }
    }
