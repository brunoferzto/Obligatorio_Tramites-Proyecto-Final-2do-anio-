namespace Tramites
{
    partial class FrmAbout
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
            this.pcAbout = new System.Windows.Forms.PictureBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lbldescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pcAbout
            // 
            this.pcAbout.Location = new System.Drawing.Point(45, 33);
            this.pcAbout.Name = "pcAbout";
            this.pcAbout.Size = new System.Drawing.Size(411, 161);
            this.pcAbout.TabIndex = 0;
            this.pcAbout.TabStop = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(180, 343);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(114, 35);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.Location = new System.Drawing.Point(77, 220);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(323, 108);
            this.lbldescripcion.TabIndex = 3;
            this.lbldescripcion.Text = "Diego Guerra - Mauricio de Avila - Bruno Fernandez\r\n\r\nPROYECTO FINAL DE SEGUNDO A" +
    "ÑO\r\nCARRERA DE ANALISTA DE SISTEMAS\r\nANALISTA PROGRAMADOR WEB .NET\r\n2020";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldescripcion.Click += new System.EventHandler(this.lbldescripcion_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 399);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.pcAbout);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pcAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcAbout;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lbldescripcion;
    }
}