namespace UI
{
    partial class frmControlCambios
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
            this.lblfrmCCTitu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFrmBRRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfrmCCTitu
            // 
            this.lblfrmCCTitu.AutoSize = true;
            this.lblfrmCCTitu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrmCCTitu.Location = new System.Drawing.Point(12, 27);
            this.lblfrmCCTitu.Name = "lblfrmCCTitu";
            this.lblfrmCCTitu.Size = new System.Drawing.Size(197, 23);
            this.lblfrmCCTitu.TabIndex = 7;
            this.lblfrmCCTitu.Text = "Historial de Cambios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 370);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnFrmBRRestaurar
            // 
            this.btnFrmBRRestaurar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRRestaurar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRRestaurar.Location = new System.Drawing.Point(995, 17);
            this.btnFrmBRRestaurar.Name = "btnFrmBRRestaurar";
            this.btnFrmBRRestaurar.Size = new System.Drawing.Size(178, 44);
            this.btnFrmBRRestaurar.TabIndex = 9;
            this.btnFrmBRRestaurar.Text = "Revertir Cambio";
            this.btnFrmBRRestaurar.UseVisualStyleBackColor = false;
            this.btnFrmBRRestaurar.Click += new System.EventHandler(this.btnFrmBRRestaurar_Click);
            // 
            // frmControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1198, 487);
            this.Controls.Add(this.btnFrmBRRestaurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblfrmCCTitu);
            this.Name = "frmControlCambios";
            this.Text = "frmControlCambios";
            this.Load += new System.EventHandler(this.frmControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrmCCTitu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFrmBRRestaurar;
    }
}