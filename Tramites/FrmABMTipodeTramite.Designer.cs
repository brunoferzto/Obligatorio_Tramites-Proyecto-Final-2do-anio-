namespace Tramites
{
    partial class FrmABMTipodeTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMTipodeTramite));
            this.BarradeEstado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarradeHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.ToolStripButton();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminarDoc = new System.Windows.Forms.Button();
            this.LbDocumentacion = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.documentossistema = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BarradeEstado.SuspendLayout();
            this.BarradeHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarradeEstado
            // 
            this.BarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.BarradeEstado.Location = new System.Drawing.Point(0, 425);
            this.BarradeEstado.Name = "BarradeEstado";
            this.BarradeEstado.Size = new System.Drawing.Size(572, 22);
            this.BarradeEstado.TabIndex = 5;
            this.BarradeEstado.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // BarradeHerramientas
            // 
            this.BarradeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnagregar,
            this.btnmodificar,
            this.btneliminar,
            this.btncancelar});
            this.BarradeHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarradeHerramientas.Name = "BarradeHerramientas";
            this.BarradeHerramientas.Size = new System.Drawing.Size(572, 25);
            this.BarradeHerramientas.TabIndex = 8;
            this.BarradeHerramientas.Text = "toolStrip1";
            // 
            // btnagregar
            // 
            this.btnagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(23, 22);
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(23, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(23, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(23, 22);
            this.btncancelar.Text = "Limpiar";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(169, 37);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Codigo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(169, 85);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(81, 85);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(55, 18);
            this.lblusuario.TabIndex = 28;
            this.lblusuario.Text = "Nombre";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(169, 131);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(216, 26);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Descripcion";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(169, 179);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(81, 26);
            this.TxtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Precio";
            // 
            // BtnEliminarDoc
            // 
            this.BtnEliminarDoc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarDoc.Location = new System.Drawing.Point(404, 257);
            this.BtnEliminarDoc.Name = "BtnEliminarDoc";
            this.BtnEliminarDoc.Size = new System.Drawing.Size(75, 25);
            this.BtnEliminarDoc.TabIndex = 7;
            this.BtnEliminarDoc.Text = "Quitar";
            this.BtnEliminarDoc.UseVisualStyleBackColor = true;
            this.BtnEliminarDoc.Click += new System.EventHandler(this.BtnEliminarDoc_Click);
            // 
            // LbDocumentacion
            // 
            this.LbDocumentacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDocumentacion.FormattingEnabled = true;
            this.LbDocumentacion.ItemHeight = 18;
            this.LbDocumentacion.Location = new System.Drawing.Point(145, 233);
            this.LbDocumentacion.Name = "LbDocumentacion";
            this.LbDocumentacion.Size = new System.Drawing.Size(240, 76);
            this.LbDocumentacion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Documentacion";
            // 
            // documentossistema
            // 
            this.documentossistema.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentossistema.FormattingEnabled = true;
            this.documentossistema.ItemHeight = 18;
            this.documentossistema.Location = new System.Drawing.Point(145, 342);
            this.documentossistema.Name = "documentossistema";
            this.documentossistema.Size = new System.Drawing.Size(240, 76);
            this.documentossistema.TabIndex = 42;
            this.documentossistema.SelectedIndexChanged += new System.EventHandler(this.documentossistema_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Documentación en el Sistema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "$$";
            // 
            // FrmABMTipodeTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.documentossistema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminarDoc);
            this.Controls.Add(this.LbDocumentacion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.BarradeHerramientas);
            this.Controls.Add(this.BarradeEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmABMTipodeTramite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Tipo de Tramite";
            this.Load += new System.EventHandler(this.FrmABMTipodeTramite_Load);
            this.BarradeEstado.ResumeLayout(false);
            this.BarradeEstado.PerformLayout();
            this.BarradeHerramientas.ResumeLayout(false);
            this.BarradeHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarradeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.ToolStrip BarradeHerramientas;
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btncancelar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminarDoc;
        private System.Windows.Forms.ListBox LbDocumentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox documentossistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}