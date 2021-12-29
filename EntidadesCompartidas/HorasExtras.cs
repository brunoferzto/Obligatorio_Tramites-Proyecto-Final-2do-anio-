using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntidadesCompartidas
{
    [DataContract]
    public class HorasExtras
    {
        DateTime fecha;
        int minutos;
        Empleado emple;

        [DataMember]
        public Empleado Empleado
        {
            get { return Empleado; }
            set
            {
                if (value == null)
                    throw new Exception("Debe Ingresar Empleado");
                else
                    Empleado = value;

            }
        }


        [DataMember]
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        [DataMember]
        public int Minutos
        {
            get { return minutos; }
            set
            {
                if (value < 0)
                    throw new Exception("Valor Incorrecto");
                else
                    minutos = value;
            }
        }



        public HorasExtras(DateTime fecha, int minutos, Empleado empl)
        {
            Fecha = fecha;
            Minutos = minutos;
            Empleado = empl;
        }

        public HorasExtras()
        {
        }
    }
}

