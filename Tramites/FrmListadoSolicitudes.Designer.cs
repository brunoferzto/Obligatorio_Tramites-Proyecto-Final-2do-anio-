namespace Tramites
{
    partial class FrmListadoSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoSolicitudes));
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.lblfilt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Lblfecha = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.BarradeEstado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTipodeT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmesual = new System.Windows.Forms.Button();
            this.btndocumentacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.BarradeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(251, 48);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(514, 267);
            this.dgvlistado.TabIndex = 0;
            // 
            // lblfilt
            // 
            this.lblfilt.AutoSize = true;
            this.lblfilt.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilt.Location = new System.Drawing.Point(53, 9);
            this.lblfilt.Name = "lblfilt";
            this.lblfilt.Size = new System.Drawing.Size(86, 32);
            this.lblfilt.TabIndex = 1;
            this.lblfilt.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tramites";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(35, 273);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(121, 20);
            this.DtpFecha.TabIndex = 4;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // Lblfecha
            // 
            this.Lblfecha.AutoSize = true;
            this.Lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfecha.Location = new System.Drawing.Point(39, 198);
            this.Lblfecha.Name = "Lblfecha";
            this.Lblfecha.Size = new System.Drawing.Size(117, 23);
            this.Lblfecha.TabIndex = 5;
            this.Lblfecha.Text = "Documentación";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(92, 299);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(121, 31);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "Limpiar Filtros";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // BarradeEstado
            // 
            this.BarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.BarradeEstado.Location = new System.Drawing.Point(0, 343);
            this.BarradeEstado.Name = "BarradeEstado";
            this.BarradeEstado.Size = new System.Drawing.Size(808, 22);
            this.BarradeEstado.TabIndex = 7;
            this.BarradeEstado.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // btnTipodeT
            // 
            this.btnTipodeT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipodeT.Location = new System.Drawing.Point(51, 83);
            this.btnTipodeT.Name = "btnTipodeT";
            this.btnTipodeT.Size = new System.Drawing.Size(88, 31);
            this.btnTipodeT.TabIndex = 8;
            this.btnTipodeT.Text = "Resumen";
            this.btnTipodeT.UseVisualStyleBackColor = true;
            this.btnTipodeT.Click += new System.EventHandler(this.btnTipodeT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mensual";
            // 
            // btnmesual
            // 
            this.btnmesual.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmesual.Location = new System.Drawing.Point(50, 152);
            this.btnmesual.Name = "btnmesual";
            this.btnmesual.Size = new System.Drawing.Size(89, 31);
            this.btnmesual.TabIndex = 10;
            this.btnmesual.Text = "Resumen";
            this.btnmesual.UseVisualStyleBackColor = true;
            this.btnmesual.Click += new System.EventHandler(this.btnmesual_Click);
            // 
            // btndocumentacion
            // 
            this.btndocumentacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocumentacion.Location = new System.Drawing.Point(50, 224);
            this.btndocumentacion.Name = "btndocumentacion";
            this.btndocumentacion.Size = new System.Drawing.Size(89, 31);
            this.btndocumentacion.TabIndex = 11;
            this.btndocumentacion.Text = "Resumen";
            this.btndocumentacion.UseVisualStyleBackColor = true;
            this.btndocumentacion.Click += new System.EventHandler(this.btndocumentacion_Click);
            // 
            // FrmListadoSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 365);
            this.Controls.Add(this.btndocumentacion);
            this.Controls.Add(this.btnmesual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTipodeT);
            this.Controls.Add(this.BarradeEstado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.Lblfecha);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfilt);
            this.Controls.Add(this.dgvlistado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmListadoSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Solicitudes";
            this.Load += new System.EventHandler(this.FrmListadoSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.BarradeEstado.ResumeLayout(false);
            this.BarradeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Label lblfilt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label Lblfecha;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.StatusStrip BarradeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Button btnTipodeT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmesual;
        private System.Windows.Forms.Button btndocumentacion;
    }
}