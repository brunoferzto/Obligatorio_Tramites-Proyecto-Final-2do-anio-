namespace Tramites
{
    partial class FrmABMDocumentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMDocumentacion));
            this.BarradeEstado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarradeHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.ToolStripButton();
            this.txtlugobtencion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BarradeEstado.SuspendLayout();
            this.BarradeHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarradeEstado
            // 
            this.BarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.BarradeEstado.Location = new System.Drawing.Point(0, 295);
            this.BarradeEstado.Name = "BarradeEstado";
            this.BarradeEstado.Size = new System.Drawing.Size(360, 22);
            this.BarradeEstado.TabIndex = 8;
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
            this.BarradeHerramientas.Size = new System.Drawing.Size(360, 25);
            this.BarradeHerramientas.TabIndex = 3;
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
            // txtlugobtencion
            // 
            this.txtlugobtencion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlugobtencion.Location = new System.Drawing.Point(149, 165);
            this.txtlugobtencion.Name = "txtlugobtencion";
            this.txtlugobtencion.Size = new System.Drawing.Size(125, 26);
            this.txtlugobtencion.TabIndex = 2;
            this.txtlugobtencion.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(149, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(125, 26);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(66, 162);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 18);
            this.lblcontraseña.TabIndex = 6;
            this.lblcontraseña.Text = "Lugar de";
            this.lblcontraseña.Click += new System.EventHandler(this.lblcontraseña_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(66, 117);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(55, 18);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "Nombre";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Obtencion";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(149, 69);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(125, 26);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // FrmABMDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 317);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlugobtencion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.BarradeHerramientas);
            this.Controls.Add(this.BarradeEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmABMDocumentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Documentacion";
            this.Load += new System.EventHandler(this.FrmABMDocumentacion_Load);
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
        private System.Windows.Forms.TextBox txtlugobtencion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
    }
}