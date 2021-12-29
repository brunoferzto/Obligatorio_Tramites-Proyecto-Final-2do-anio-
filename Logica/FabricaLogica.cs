using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FabricaLogica
    {
        public static ILogicaDocumentacion GetLogicaDocumentacion()
        {
            return (LogicaDocumentacion.GetInstancia());
        }
        public static ILogicaUsuario GetLogicaUsuario()
        {
            return (LogicaUsuario.GetInstancia());
        }
        public static ILogicaHorasExtras GetLogicaHorasExtras()
        {
            return (LogicaHorasExtras.GetInstancia());
        }
        public static ILogicaSolicitud GetLogicaSolicitud()
        {
            return (LogicaSolicitud.GetInstancia());
        }
        public static ILogicaTiposdeTramite GetLogicaTiposdeTramite()
        {
            return (LogicaTiposdeTramite.GetInstancia());
        }

        
    }
}
