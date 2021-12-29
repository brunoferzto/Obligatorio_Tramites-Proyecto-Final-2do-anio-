using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Xml;

namespace Logica
{
    public interface ILogicaTiposdeTramite
    {
        TiposdeTramite BuscarTiposdeTramiteActivo(string codigo, Empleado EmpleadoActual);
        void AltaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        void ModificarTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        void BajaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        XmlDocument ListarTiposdeTramite(Usuario usuActual);
    }
}
