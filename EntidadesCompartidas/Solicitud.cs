using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EntidadesCompartidas
{
    [DataContract]
    public class Solicitud
    {
        DateTime fecha;
        int numero;
        string estado;
        Solicitante solicita;
        TiposdeTramite unTramite;

        [DataMember]
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        [DataMember]
        public int Numero
        {
            get { return numero; }
            set
            {
                if (value < 0)
                    throw new Exception("Número Incorrecto");
                else
                    numero = value;
            }
        }

        [DataMember]
        public string Estado
        {
            get { return estado; }
            set
            {
                if (value != "Alta" && value != "Ejecutada" && value != "Anulada")
                    throw new Exception("Estado de Solicitud Incorrecto");
                else
                    estado = value;
            }
        }

        [DataMember]
        public Solicitante Solicita
        {
            get { return solicita; }
            set
            {
                if (value == null)
                    throw new Exception("Debe Ingresar El Usuario Solicitante");
                else
                    solicita = value;
            }
        }

        [DataMember]
        public TiposdeTramite UnTramite
        {
            get { return unTramite; }
            set
            {
                if (value == null)
                    throw new Exception("Debe Ingresar un Tipo de Trámite");
                else
                    unTramite = value;
            }
        }

        public Solicitud(DateTime fcha, int nmro, string estdo, Solicitante soli, TiposdeTramite tram)
        {
            Solicita = soli;
            Fecha = fcha;
            Numero = nmro;
            Estado = estdo;
            UnTramite = tram;
        }

        public Solicitud()
        {
        }
    }
}