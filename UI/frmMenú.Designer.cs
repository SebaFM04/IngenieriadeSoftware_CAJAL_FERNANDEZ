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
            this.SuspendLayout();
            // 
            // btnCerrarSesionfrmMenu
            // 
            this.btnCerrarSesionfrmMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCerrarSesionfrmMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionfrmMenu.Location = new System.Drawing.Point(145, 302);
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
            this.label1.Location = new System.Drawing.Point(75, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarSesionfrmMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenú";
            this.Text = "frmMenú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesionfrmMenu;
        private System.Windows.Forms.Label label1;
    }
}