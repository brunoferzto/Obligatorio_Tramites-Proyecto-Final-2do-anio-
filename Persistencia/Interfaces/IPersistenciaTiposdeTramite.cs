using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaTiposdeTramite
    {
        void Alta(TiposdeTramite oTram, Empleado EmpleadoActual);
        void Baja(TiposdeTramite oTram, Empleado EmpleadoActual);
        void Modificar(TiposdeTramite oTram, Empleado EmpleadoActual);
        TiposdeTramite BuscarActivo(string código, Usuario usuActual); 
        List<TiposdeTramite> Listar(Usuario usuActual);

        TiposdeTramite Buscar (string codigo,Empleado emplBuscado);
    }
}
