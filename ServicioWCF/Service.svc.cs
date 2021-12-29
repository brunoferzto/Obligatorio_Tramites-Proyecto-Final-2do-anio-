using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Logica;
using EntidadesCompartidas;
using System.Xml;

namespace ServicioWCF
{
    public class Service : IServicio
    { 

        Documentacion IServicio.BuscarDocumentacionActiva(int codigo, Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaDocumentacion().BuscarDocumentacionActiva(codigo, EmpleadoActual);
        }

        void IServicio.AltaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual) 
        {
            FabricaLogica.GetLogicaDocumentacion().AltaDocumentacion(oDocumentacion, EmpleadoActual); 
        }

        void IServicio.ModificarDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaDocumentacion().ModificarDocumentacion(oDocumentacion, EmpleadoActual);
        }

        void IServicio.BajaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaDocumentacion().BajaDocumentacion(oDocumentacion, EmpleadoActual);
        }

        List<Documentacion> IServicio.ListarDocumentacion(Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaDocumentacion().ListarDocumentacion(EmpleadoActual);
        }

        void IServicio.AltaHorasExtra(HorasExtras oHorasExtra, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaHorasExtras().AltaHorasExtra(oHorasExtra, EmpleadoActual);
        }

        void IServicio.AltaSolicitud(Solicitud oSolicitud, Solicitante SolicitanteActual)
        {
            FabricaLogica.GetLogicaSolicitud().AltaSolicitud(oSolicitud, SolicitanteActual);
        }

        void IServicio.CambiarEstado(Solicitud oSolicitud, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaSolicitud().CambiarEstado(oSolicitud, EmpleadoActual);
        }

        List<Solicitud> IServicio.ListarSolicitudes(Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaSolicitud().ListarSolicitudes(EmpleadoActual);
        }

        List<Solicitud> IServicio.ListarSolicitudesAlta(Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaSolicitud().ListarSolicitudesAlta(EmpleadoActual);
        }

        TiposdeTramite IServicio.BuscarTiposdeTramiteActivo(string codigo, Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaTiposdeTramite().BuscarTiposdeTramiteActivo(codigo, EmpleadoActual);
        }

        void IServicio.AltaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaTiposdeTramite().AltaTiposdeTramite(oTiposdeTramite, EmpleadoActual);
        }

        void IServicio.ModificarTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaTiposdeTramite().ModificarTiposdeTramite(oTiposdeTramite, EmpleadoActual);
        }

        void IServicio.BajaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaTiposdeTramite().BajaTiposdeTramite(oTiposdeTramite, EmpleadoActual); 
        }

        string IServicio.ListarTiposdeTramite(Usuario usuActual)
        {
            return (FabricaLogica.GetLogicaTiposdeTramite().ListarTiposdeTramite(usuActual)).OuterXml;
        }

        Usuario IServicio.BuscarUsuario(int cedula, Empleado EmpleadoActual)
        {
            return FabricaLogica.GetLogicaUsuario().BuscarUsuario(cedula, EmpleadoActual); 
        }

        void IServicio.AltaUsuario(Usuario oUsuario, Usuario UsuarioActual)
        {
           FabricaLogica.GetLogicaUsuario().AltaUsuario(oUsuario, UsuarioActual);
        }

        void IServicio.ModificarUsuario(Usuario oUsuario, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaUsuario().ModificarUsuario(oUsuario, EmpleadoActual);
        }

        void IServicio.BajaUsuario(Usuario oUsuario, Empleado EmpleadoActual)
        {
            FabricaLogica.GetLogicaUsuario().BajaUsuario(oUsuario, EmpleadoActual); 
        }

        Usuario IServicio.LogueoUsuario(string contra, int cedula)
        {
            return FabricaLogica.GetLogicaUsuario().LogueoUsuario(contra, cedula); 
        }
    }
}
