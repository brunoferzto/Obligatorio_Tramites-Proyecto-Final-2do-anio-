namespace Tramites
{
    partial class FrmLogueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogueo));
            this.btningresar = new System.Windows.Forms.Button();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblusu = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.barraestado = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraestado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(136, 120);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(86, 30);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.Location = new System.Drawing.Point(26, 77);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(83, 18);
            this.lblcontra.TabIndex = 9;
            this.lblcontra.Text = "Contraseña :";
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusu.Location = new System.Drawing.Point(26, 34);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(63, 18);
            this.lblusu.TabIndex = 8;
            this.lblusu.Text = "Usuario :";
            // 
            // txtcontra
            // 
            this.txtcontra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.Location = new System.Drawing.Point(120, 31);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(102, 26);
            this.txtcontra.TabIndex = 0;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(120, 74);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '*';
            this.txtusuario.Size = new System.Drawing.Size(102, 26);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.UseSystemPasswordChar = true;
            // 
            // barraestado
            // 
            this.barraestado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.barraestado.Location = new System.Drawing.Point(0, 169);
            this.barraestado.Name = "barraestado";
            this.barraestado.Size = new System.Drawing.Size(305, 22);
            this.barraestado.TabIndex = 11;
            this.barraestado.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 191);
            this.Controls.Add(this.barraestado);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusu);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.Load += new System.EventHandler(this.FrmLogueo_Load);
            this.barraestado.ResumeLayout(false);
            this.barraestado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.StatusStrip barraestado;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
    }
}