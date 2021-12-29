namespace ServicioWin
{
    partial class ServicioHoras
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.Mensaje = new System.Diagnostics.EventLog();
            this.FswXml = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FswXml)).BeginInit();
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // FswXml
            // 
            this.FswXml.EnableRaisingEvents = true;
            this.FswXml.Created += new System.IO.FileSystemEventHandler(this.FswXml_Created);
            this.FswXml.Deleted += new System.IO.FileSystemEventHandler(this.FswXml_Deleted);
            // 
            // ServicioHoras
            // 
            this.CanPauseAndContinue = true;
            this.ServiceName = "ServicioXml";
            ((System.ComponentModel.ISupportInitialize)(this.Mensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FswXml)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Timer Cronometro;
        private System.Diagnostics.EventLog Mensaje;
        private System.IO.FileSystemWatcher FswXml;
    }
}
