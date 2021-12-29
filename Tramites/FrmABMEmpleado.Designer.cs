namespace Tramites
{
    partial class FrmABMEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMEmpleado));
            this.BarradeEstado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnvercontra = new System.Windows.Forms.Button();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.TxtNomCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.BarradeHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btncancelar = new System.Windows.Forms.ToolStripButton();
            this.DtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.BarradeEstado.SuspendLayout();
            this.BarradeHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarradeEstado
            // 
            this.BarradeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.BarradeEstado.Location = new System.Drawing.Point(0, 361);
            this.BarradeEstado.Name = "BarradeEstado";
            this.BarradeEstado.Size = new System.Drawing.Size(448, 22);
            this.BarradeEstado.TabIndex = 5;
            this.BarradeEstado.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(294, 69);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 18);
            this.lblcount.TabIndex = 23;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(327, 118);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(0, 18);
            this.lblpass.TabIndex = 22;
            // 
            // btnvercontra
            // 
            this.btnvercontra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercontra.Location = new System.Drawing.Point(276, 114);
            this.btnvercontra.Name = "btnvercontra";
            this.btnvercontra.Size = new System.Drawing.Size(45, 26);
            this.btnvercontra.TabIndex = 21;
            this.btnvercontra.Text = "Ver";
            this.btnvercontra.UseVisualStyleBackColor = true;
            this.btnvercontra.Click += new System.EventHandler(this.btnvercontra_Click);
            // 
            // TxtContra
            // 
            this.TxtContra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(170, 115);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(100, 26);
            this.TxtContra.TabIndex = 1;
            this.TxtContra.UseSystemPasswordChar = true;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(170, 62);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(100, 26);
            this.TxtCedula.TabIndex = 0;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            this.TxtCedula.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCedula_Validating);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(78, 115);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(75, 18);
            this.lblcontraseña.TabIndex = 18;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(78, 65);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(49, 18);
            this.lblusuario.TabIndex = 17;
            this.lblusuario.Text = "Cedula";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // TxtNomCompleto
            // 
            this.TxtNomCompleto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomCompleto.Location = new System.Drawing.Point(170, 168);
            this.TxtNomCompleto.Name = "TxtNomCompleto";
            this.TxtNomCompleto.Size = new System.Drawing.Size(100, 26);
            this.TxtNomCompleto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fin";
            // 
            // DtpHoraInicio
            // 
            this.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraInicio.Location = new System.Drawing.Point(170, 254);
            this.DtpHoraInicio.Name = "DtpHoraInicio";
            this.DtpHoraInicio.Size = new System.Drawing.Size(87, 20);
            this.DtpHoraInicio.TabIndex = 3;
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
            this.BarradeHerramientas.Size = new System.Drawing.Size(448, 25);
            this.BarradeHerramientas.TabIndex = 5;
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
            // DtpHoraFin
            // 
            this.DtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraFin.Location = new System.Drawing.Point(170, 292);
            this.DtpHoraFin.Name = "DtpHoraFin";
            this.DtpHoraFin.Size = new System.Drawing.Size(87, 20);
            this.DtpHoraFin.TabIndex = 4;
            // 
            // FrmABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 383);
            this.Controls.Add(this.BarradeHerramientas);
            this.Controls.Add(this.DtpHoraFin);
            this.Controls.Add(this.DtpHoraInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.btnvercontra);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.BarradeEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmABMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Empleado";
            this.Load += new System.EventHandler(this.FrmABMEmpleado_Load);
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
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnvercontra;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox TxtNomCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpHoraInicio;
        private System.Windows.Forms.ToolStrip BarradeHerramientas;
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btncancelar;
        private System.Windows.Forms.DateTimePicker DtpHoraFin;
    }
}