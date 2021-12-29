using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntidadesCompartidas;
using System.ServiceModel;
using System.Xml;


namespace ServicioWCF
{
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        Documentacion BuscarDocumentacionActiva(int codigo, Empleado EmpleadoActual);
        [OperationContract]
        void AltaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        [OperationContract]
        void ModificarDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        [OperationContract]
        void BajaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        [OperationContract]
        List<Documentacion> ListarDocumentacion(Empleado EmpleadoActual);
        [OperationContract]
        void AltaHorasExtra(HorasExtras oHorasExtra, Empleado EmpleadoActual);
        [OperationContract]
        void AltaSolicitud(Solicitud oSolicitud, Solicitante SolicitanteActual);
        [OperationContract]
        void CambiarEstado(Solicitud oSolicitud, Empleado EmpleadoActual);
        [OperationContract]
        List<Solicitud> ListarSolicitudes(Empleado EmpleadoActual);
        [OperationContract]
        List<Solicitud> ListarSolicitudesAlta(Empleado EmpleadoActual);
        [OperationContract]
        TiposdeTramite BuscarTiposdeTramiteActivo(string codigo, Empleado EmpleadoActual);
        [OperationContract]
        void AltaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        [OperationContract]
        void ModificarTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        [OperationContract]
        void BajaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual);
        [OperationContract]
        string ListarTiposdeTramite(Usuario usuActual);
        [OperationContract]
        Usuario BuscarUsuario(int cedula, Empleado EmpleadoActual);
        [OperationContract]
        void AltaUsuario(Usuario oUsuario, Usuario UsuarioActual);
        [OperationContract]
        void ModificarUsuario(Usuario oUsuario, Empleado EmpleadoActual);
        [OperationContract]
        void BajaUsuario(Usuario oUsuario, Empleado EmpleadoActual);
        [OperationContract]
        Usuario LogueoUsuario(string contra, int cedula);
    }
}