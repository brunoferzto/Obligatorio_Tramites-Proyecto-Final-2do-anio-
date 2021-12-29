namespace Tramites
{
    partial class FrmCambioEstadoSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioEstadoSolicitud));
            this.BarradeEstado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ejecutada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anulada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BarradeEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // BarradeEstado
            // 
            this.BarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.BarradeEstado.Location = new System.Drawing.Point(0, 336);
            this.BarradeEstado.Name = "BarradeEstado";
            this.BarradeEstado.Size = new System.Drawing.Size(659, 22);
            this.BarradeEstado.TabIndex = 5;
            this.BarradeEstado.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ejecutada,
            this.Nro,
            this.Tramite,
            this.Solicitante,
            this.Fecha,
            this.Anulada});
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 98);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.Size = new System.Drawing.Size(598, 193);
            this.dgvSolicitudes.TabIndex = 6;
            this.dgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Solicitudes";
            // 
            // Ejecutada
            // 
            this.Ejecutada.HeaderText = "Ejecutar";
            this.Ejecutada.Name = "Ejecutada";
            this.Ejecutada.ReadOnly = true;
            this.Ejecutada.Width = 50;
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "Numero";
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 50;
            // 
            // Tramite
            // 
            this.Tramite.DataPropertyName = "Tramite";
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            this.Tramite.Width = 150;
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Solicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.ReadOnly = true;
            this.Solicitante.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 50;
            // 
            // Anulada
            // 
            this.Anulada.HeaderText = "Anular";
            this.Anulada.Name = "Anulada";
            this.Anulada.ReadOnly = true;
            this.Anulada.Width = 50;
            // 
            // FrmCambioEstadoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.BarradeEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCambioEstadoSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio Estado Solicitud";
            this.Load += new System.EventHandler(this.FrmCambioEstadoSolicitud_Load);
            this.BarradeEstado.ResumeLayout(false);
            this.BarradeEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarradeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ejecutada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anulada;
    }
}