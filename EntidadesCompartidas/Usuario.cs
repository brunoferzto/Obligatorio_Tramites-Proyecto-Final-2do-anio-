using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntidadesCompartidas
{
    [KnownType(typeof(Solicitante))]
    [KnownType(typeof(Empleado))]
    [DataContract]

    public class Usuario
    {
        string contra, nombre;
        int cedula;

        [DataMember]
        public string Contraseña
        {
            get { return contra; } //LLL/NN/S 
            set
            {
                if (value.Length == 6 && value.Substring(0, 3).All(char.IsLetter) &&
                    value.Substring(3, 2).All(char.IsNumber) && value.Substring(6).All(char.IsSymbol))
                {
                    contra = value;
                }

                else
                    throw new Exception("Constraseña Inválida");
            }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if ((value == "") || (value.All(char.IsNumber) || (value.Length > 50)))
                    throw new Exception("Nombre Incorrecto");
                else
                    nombre = value;
            }


        }

        [DataMember]
        public int Cedula
        {
            get { return cedula; }
            set
            {
                if (Convert.ToString(value).Length != 8)
                    throw new Exception("La Cédula Debe Tener 8 dígitos númericos");
                else
                    cedula = value;
            }
        }

        public Usuario(string nom, string cont, int ced)
        {
            Nombre = nom;
            Contraseña = cont;
            Cedula = ced;
        }

        public Usuario()
        {

        }


    }
}

