namespace UI
{
    partial class frmMenú
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
            this.btnCerrarSesionfrmMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnstripMenu = new System.Windows.Forms.MenuStrip();
            this.gestiónUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminitraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioLog = new System.Windows.Forms.Label();
            this.mnstripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesionfrmMenu
            // 
            this.btnCerrarSesionfrmMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCerrarSesionfrmMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionfrmMenu.Location = new System.Drawing.Point(215, 298);
            this.btnCerrarSesionfrmMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesionfrmMenu.Name = "btnCerrarSesionfrmMenu";
            this.btnCerrarSesionfrmMenu.Size = new System.Drawing.Size(162, 38);
            this.btnCerrarSesionfrmMenu.TabIndex = 17;
            this.btnCerrarSesionfrmMenu.Text = "Cerrar Sesión";
            this.btnCerrarSesionfrmMenu.UseVisualStyleBackColor = false;
            this.btnCerrarSesionfrmMenu.Click += new System.EventHandler(this.btnCerrarSesionfrmMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "...";
            // 
            // mnstripMenu
            // 
            this.mnstripMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnstripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónUsuariosToolStripMenuItem,
            this.gestiónProductosToolStripMenuItem,
            this.adminitraciónToolStripMenuItem});
            this.mnstripMenu.Location = new System.Drawing.Point(0, 0);
            this.mnstripMenu.Name = "mnstripMenu";
            this.mnstripMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnstripMenu.Size = new System.Drawing.Size(600, 24);
            this.mnstripMenu.TabIndex = 19;
            this.mnstripMenu.Text = "menuStrip1";
            // 
            // gestiónUsuariosToolStripMenuItem
            // 
            this.gestiónUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioUsuariosToolStripMenuItem});
            this.gestiónUsuariosToolStripMenuItem.Name = "gestiónUsuariosToolStripMenuItem";
            this.gestiónUsuariosToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestiónUsuariosToolStripMenuItem.Text = "Gestión Usuarios";
            // 
            // formularioUsuariosToolStripMenuItem
            // 
            this.formularioUsuariosToolStripMenuItem.Name = "formularioUsuariosToolStripMenuItem";
            this.formularioUsuariosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.formularioUsuariosToolStripMenuItem.Text = "Formulario Usuarios";
            this.formularioUsuariosToolStripMenuItem.Click += new System.EventHandler(this.formularioUsuariosToolStripMenuItem_Click);
            // 
            // gestiónProductosToolStripMenuItem
            // 
            this.gestiónProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioProductosToolStripMenuItem});
            this.gestiónProductosToolStripMenuItem.Name = "gestiónProductosToolStripMenuItem";
            this.gestiónProductosToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.gestiónProductosToolStripMenuItem.Text = "Gestión Productos";
            // 
            // formularioProductosToolStripMenuItem
            // 
            this.formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            this.formularioProductosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.formularioProductosToolStripMenuItem.Text = "Formulario Productos";
            // 
            // adminitraciónToolStripMenuItem
            // 
            this.adminitraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem});
            this.adminitraciónToolStripMenuItem.Name = "adminitraciónToolStripMenuItem";
            this.adminitraciónToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminitraciónToolStripMenuItem.Text = "Adminitración";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblUsuarioLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuarioLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuarioLog.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLog.Location = new System.Drawing.Point(9, 58);
            this.lblUsuarioLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(209, 20);
            this.lblUsuarioLog.TabIndex = 20;
            this.lblUsuarioLog.Text = "El usuario Logueado es: ";
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblUsuarioLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarSesionfrmMenu);
            this.Controls.Add(this.mnstripMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mnstripMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenú";
            this.mnstripMenu.ResumeLayout(false);
            this.mnstripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesionfrmMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnstripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestiónUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminitraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuarioLog;
    }
}