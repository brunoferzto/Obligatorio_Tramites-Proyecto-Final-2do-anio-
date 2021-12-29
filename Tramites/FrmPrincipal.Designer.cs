namespace Tramites
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.aBMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDocumentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTiposDeTramiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFGHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMsToolStripMenuItem,
            this.dFGHToolStripMenuItem,
            this.listadoDeSolicitudesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(722, 28);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // aBMsToolStripMenuItem
            // 
            this.aBMsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem,
            this.aBMDocumentacionToolStripMenuItem,
            this.aBMTiposDeTramiteToolStripMenuItem});
            this.aBMsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBMsToolStripMenuItem.Name = "aBMsToolStripMenuItem";
            this.aBMsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.aBMsToolStripMenuItem.Text = "ABMs";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aBMEmpleadosToolStripMenuItem.Text = "ABM Empleados";
            this.aBMEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadosToolStripMenuItem_Click);
            // 
            // aBMDocumentacionToolStripMenuItem
            // 
            this.aBMDocumentacionToolStripMenuItem.Name = "aBMDocumentacionToolStripMenuItem";
            this.aBMDocumentacionToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aBMDocumentacionToolStripMenuItem.Text = "ABM Documentacion";
            this.aBMDocumentacionToolStripMenuItem.Click += new System.EventHandler(this.aBMDocumentacionToolStripMenuItem_Click);
            // 
            // aBMTiposDeTramiteToolStripMenuItem
            // 
            this.aBMTiposDeTramiteToolStripMenuItem.Name = "aBMTiposDeTramiteToolStripMenuItem";
            this.aBMTiposDeTramiteToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.aBMTiposDeTramiteToolStripMenuItem.Text = "ABM Tipos de Tramite";
            this.aBMTiposDeTramiteToolStripMenuItem.Click += new System.EventHandler(this.aBMTiposDeTramiteToolStripMenuItem_Click);
            // 
            // dFGHToolStripMenuItem
            // 
            this.dFGHToolStripMenuItem.Name = "dFGHToolStripMenuItem";
            this.dFGHToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.dFGHToolStripMenuItem.Text = "Cambio de Estado de Solicitud";
            this.dFGHToolStripMenuItem.Click += new System.EventHandler(this.dFGHToolStripMenuItem_Click);
            // 
            // listadoDeSolicitudesToolStripMenuItem
            // 
            this.listadoDeSolicitudesToolStripMenuItem.Name = "listadoDeSolicitudesToolStripMenuItem";
            this.listadoDeSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.listadoDeSolicitudesToolStripMenuItem.Text = "Listado de Solicitudes";
            this.listadoDeSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSolicitudesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 327);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem aBMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dFGHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMDocumentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTiposDeTramiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}