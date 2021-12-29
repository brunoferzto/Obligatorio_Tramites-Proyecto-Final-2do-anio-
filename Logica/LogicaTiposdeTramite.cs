using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;
using System.Xml;

namespace Logica
{
    internal class LogicaTiposdeTramite: ILogicaTiposdeTramite
    {
        private static LogicaTiposdeTramite _instancia = null;
        private LogicaTiposdeTramite() { }
        public static LogicaTiposdeTramite GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaTiposdeTramite();

            return _instancia;
        }
        public TiposdeTramite BuscarTiposdeTramiteActivo(string codigo, Empleado EmpleadoActual)
        {
            return (FabricaPersistencia.GetPersistenciaTiposdeTramite().BuscarActivo(codigo, EmpleadoActual));
        }
        public void AltaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaTiposdeTramite().Alta(oTiposdeTramite, EmpleadoActual);
        }
        public void ModificarTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaTiposdeTramite().Modificar(oTiposdeTramite, EmpleadoActual);
        }
        public void BajaTiposdeTramite(TiposdeTramite oTiposdeTramite, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaTiposdeTramite().Baja(oTiposdeTramite, EmpleadoActual);
        }
        public XmlDocument ListarTiposdeTramite(Usuario usuActual) 
        {
            List<TiposdeTramite> tramites = FabricaPersistencia.GetPersistenciaTiposdeTramite().Listar(usuActual);
            XmlDocument documento = new XmlDocument();
            documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <TiposdeTramites> </TiposdeTramites>");
            XmlNode NodoTra = documento.DocumentElement;
            foreach (TiposdeTramite tiposdetramite in tramites)
            {
                XmlNode NodoT = documento.CreateNode(XmlNodeType.Element, "Tramite", "");

                XmlNode NodoCodigo = documento.CreateNode(XmlNodeType.Element, "Codigo", "");
                NodoCodigo.InnerXml = tiposdetramite.Codigo;
                NodoT.AppendChild(NodoCodigo);

                XmlNode NodoNombre = documento.CreateNode(XmlNodeType.Element, "Nombre", "");
                NodoNombre.InnerXml = tiposdetramite.Nombre;
                NodoT.AppendChild(NodoNombre);

                XmlNode NodoDescripcion = documento.CreateNode(XmlNodeType.Element, "Descripcion", "");
                NodoDescripcion.InnerXml = tiposdetramite.Descripcion;
                NodoT.AppendChild(NodoDescripcion);

                XmlNode NodoPrecio = documento.CreateNode(XmlNodeType.Element, "Precio", "");
                NodoPrecio.InnerXml = Convert.ToString(tiposdetramite.Precio);
                NodoT.AppendChild(NodoPrecio);

                XmlNode NodoR = documento.CreateNode(XmlNodeType.Element, "Requiere", "");

                foreach (Documentacion nodo in tiposdetramite.DocumentoLista)
                {
                    XmlNode NodoD = documento.CreateNode(XmlNodeType.Element, "Documentos", "");

                    XmlNode NodoDocumentocionCodigo = documento.CreateNode(XmlNodeType.Element, "DocumentocionCodigo", "");
                    NodoDocumentocionCodigo.InnerXml = tiposdetramite.Descripcion;
                    NodoD.AppendChild(NodoDocumentocionCodigo);

                    XmlNode NodoDocumentacionNombre = documento.CreateNode(XmlNodeType.Element, "DocumentacionNombre", "");
                    NodoDocumentacionNombre.InnerXml = Convert.ToString(tiposdetramite.Precio);
                    NodoD.AppendChild(NodoDocumentacionNombre);

                    NodoR.AppendChild(NodoD);
                }

                NodoT.AppendChild(NodoR);

                NodoTra.AppendChild(NodoT);
            }
            return documento;
        }
    }
}
