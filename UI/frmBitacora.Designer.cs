namespace UI
{
    partial class frmBitacora
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
            this.lblUsuarioBitacora = new System.Windows.Forms.Label();
            this.lblDesdeBitacora = new System.Windows.Forms.Label();
            this.lblHastaBitacora = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarBitacora = new System.Windows.Forms.Button();
            this.btnLimpiarBitacora = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioBitacora
            // 
            this.lblUsuarioBitacora.AutoSize = true;
            this.lblUsuarioBitacora.Location = new System.Drawing.Point(46, 34);
            this.lblUsuarioBitacora.Name = "lblUsuarioBitacora";
            this.lblUsuarioBitacora.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioBitacora.TabIndex = 0;
            this.lblUsuarioBitacora.Text = "Usuario";
            // 
            // lblDesdeBitacora
            // 
            this.lblDesdeBitacora.AutoSize = true;
            this.lblDesdeBitacora.Location = new System.Drawing.Point(46, 67);
            this.lblDesdeBitacora.Name = "lblDesdeBitacora";
            this.lblDesdeBitacora.Size = new System.Drawing.Size(38, 13);
            this.lblDesdeBitacora.TabIndex = 1;
            this.lblDesdeBitacora.Text = "Desde";
            // 
            // lblHastaBitacora
            // 
            this.lblHastaBitacora.AutoSize = true;
            this.lblHastaBitacora.Location = new System.Drawing.Point(46, 90);
            this.lblHastaBitacora.Name = "lblHastaBitacora";
            this.lblHastaBitacora.Size = new System.Drawing.Size(35, 13);
            this.lblHastaBitacora.TabIndex = 2;
            this.lblHastaBitacora.Text = "Hasta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(96, 61);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 4;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(96, 90);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // btnBuscarBitacora
            // 
            this.btnBuscarBitacora.Location = new System.Drawing.Point(49, 128);
            this.btnBuscarBitacora.Name = "btnBuscarBitacora";
            this.btnBuscarBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBitacora.TabIndex = 6;
            this.btnBuscarBitacora.Text = "Buscar";
            this.btnBuscarBitacora.UseVisualStyleBackColor = true;
            this.btnBuscarBitacora.Click += new System.EventHandler(this.btnBuscarBitacora_Click);
            // 
            // btnLimpiarBitacora
            // 
            this.btnLimpiarBitacora.Location = new System.Drawing.Point(49, 171);
            this.btnLimpiarBitacora.Name = "btnLimpiarBitacora";
            this.btnLimpiarBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarBitacora.TabIndex = 7;
            this.btnLimpiarBitacora.Text = "Limpiar";
            this.btnLimpiarBitacora.UseVisualStyleBackColor = true;
            this.btnLimpiarBitacora.Click += new System.EventHandler(this.btnLimpiarBitacora_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 297);
            this.dataGridView1.TabIndex = 8;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiarBitacora);
            this.Controls.Add(this.btnBuscarBitacora);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHastaBitacora);
            this.Controls.Add(this.lblDesdeBitacora);
            this.Controls.Add(this.lblUsuarioBitacora);
            this.Name = "frmBitacora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioBitacora;
        private System.Windows.Forms.Label lblDesdeBitacora;
        private System.Windows.Forms.Label lblHastaBitacora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnBuscarBitacora;
        private System.Windows.Forms.Button btnLimpiarBitacora;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}