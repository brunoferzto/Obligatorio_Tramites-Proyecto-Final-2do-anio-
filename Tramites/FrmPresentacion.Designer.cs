namespace Tramites
{
    partial class FrmPresentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresentacion));
            this.pbPresentacion = new System.Windows.Forms.PictureBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPresentacion
            // 
            this.pbPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("pbPresentacion.Image")));
            this.pbPresentacion.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPresentacion.InitialImage")));
            this.pbPresentacion.Location = new System.Drawing.Point(83, 12);
            this.pbPresentacion.Name = "pbPresentacion";
            this.pbPresentacion.Size = new System.Drawing.Size(341, 235);
            this.pbPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPresentacion.TabIndex = 0;
            this.pbPresentacion.TabStop = false;
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(217, 279);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(294, 17);
            this.lblnombres.TabIndex = 1;
            this.lblnombres.Text = "Diego Guerra - Mauricio de Avila - Bruno Fernandez";
            this.lblnombres.Click += new System.EventHandler(this.lblnombres_Click);
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 4000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 305);
            this.Controls.Add(this.lblnombres);
            this.Controls.Add(this.pbPresentacion);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPresentacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPresentacion;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Timer Cronometro;
    }
}