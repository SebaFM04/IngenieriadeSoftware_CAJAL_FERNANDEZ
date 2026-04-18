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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminitraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesionfrmMenu
            // 
            this.btnCerrarSesionfrmMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCerrarSesionfrmMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionfrmMenu.Location = new System.Drawing.Point(145, 302);
            this.btnCerrarSesionfrmMenu.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Location = new System.Drawing.Point(75, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónUsuariosToolStripMenuItem,
            this.gestiónProductosToolStripMenuItem,
            this.adminitraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónUsuariosToolStripMenuItem
            // 
            this.gestiónUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioUsuariosToolStripMenuItem});
            this.gestiónUsuariosToolStripMenuItem.Name = "gestiónUsuariosToolStripMenuItem";
            this.gestiónUsuariosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestiónUsuariosToolStripMenuItem.Text = "Gestión Usuarios";
            // 
            // formularioUsuariosToolStripMenuItem
            // 
            this.formularioUsuariosToolStripMenuItem.Name = "formularioUsuariosToolStripMenuItem";
            this.formularioUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formularioUsuariosToolStripMenuItem.Text = "Formulario Usuarios";
            this.formularioUsuariosToolStripMenuItem.Click += new System.EventHandler(this.formularioUsuariosToolStripMenuItem_Click);
            // 
            // gestiónProductosToolStripMenuItem
            // 
            this.gestiónProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioProductosToolStripMenuItem});
            this.gestiónProductosToolStripMenuItem.Name = "gestiónProductosToolStripMenuItem";
            this.gestiónProductosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestiónProductosToolStripMenuItem.Text = "Gestión Productos";
            // 
            // formularioProductosToolStripMenuItem
            // 
            this.formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            this.formularioProductosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.formularioProductosToolStripMenuItem.Text = "Formulario Productos";
            // 
            // adminitraciónToolStripMenuItem
            // 
            this.adminitraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem});
            this.adminitraciónToolStripMenuItem.Name = "adminitraciónToolStripMenuItem";
            this.adminitraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.adminitraciónToolStripMenuItem.Text = "Adminitración";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarSesionfrmMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesionfrmMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminitraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
    }
}