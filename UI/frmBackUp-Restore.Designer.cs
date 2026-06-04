namespace UI
{
    partial class frmBackUp_Restore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFrmBRExaminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFrmBRCrearBackUp = new System.Windows.Forms.Button();
            this.btnFrmBRRestaurar = new System.Windows.Forms.Button();
            this.btnFrmBREliminar = new System.Windows.Forms.Button();
            this.lblfrmBRTitu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(753, 27);
            this.textBox1.TabIndex = 0;
            // 
            // btnFrmBRExaminar
            // 
            this.btnFrmBRExaminar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRExaminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRExaminar.Location = new System.Drawing.Point(776, 56);
            this.btnFrmBRExaminar.Name = "btnFrmBRExaminar";
            this.btnFrmBRExaminar.Size = new System.Drawing.Size(120, 40);
            this.btnFrmBRExaminar.TabIndex = 1;
            this.btnFrmBRExaminar.Text = "Examinar...";
            this.btnFrmBRExaminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 441);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnFrmBRCrearBackUp
            // 
            this.btnFrmBRCrearBackUp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRCrearBackUp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRCrearBackUp.Location = new System.Drawing.Point(920, 233);
            this.btnFrmBRCrearBackUp.Name = "btnFrmBRCrearBackUp";
            this.btnFrmBRCrearBackUp.Size = new System.Drawing.Size(138, 40);
            this.btnFrmBRCrearBackUp.TabIndex = 3;
            this.btnFrmBRCrearBackUp.Text = "Crear BackUp";
            this.btnFrmBRCrearBackUp.UseVisualStyleBackColor = false;
            // 
            // btnFrmBRRestaurar
            // 
            this.btnFrmBRRestaurar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRRestaurar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRRestaurar.Location = new System.Drawing.Point(920, 309);
            this.btnFrmBRRestaurar.Name = "btnFrmBRRestaurar";
            this.btnFrmBRRestaurar.Size = new System.Drawing.Size(138, 40);
            this.btnFrmBRRestaurar.TabIndex = 4;
            this.btnFrmBRRestaurar.Text = "Restaurar";
            this.btnFrmBRRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnFrmBREliminar
            // 
            this.btnFrmBREliminar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBREliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBREliminar.Location = new System.Drawing.Point(920, 384);
            this.btnFrmBREliminar.Name = "btnFrmBREliminar";
            this.btnFrmBREliminar.Size = new System.Drawing.Size(138, 40);
            this.btnFrmBREliminar.TabIndex = 5;
            this.btnFrmBREliminar.Text = "Eliminar";
            this.btnFrmBREliminar.UseVisualStyleBackColor = false;
            // 
            // lblfrmBRTitu
            // 
            this.lblfrmBRTitu.AutoSize = true;
            this.lblfrmBRTitu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrmBRTitu.Location = new System.Drawing.Point(13, 13);
            this.lblfrmBRTitu.Name = "lblfrmBRTitu";
            this.lblfrmBRTitu.Size = new System.Drawing.Size(155, 23);
            this.lblfrmBRTitu.TabIndex = 6;
            this.lblfrmBRTitu.Text = "BackUp-Restore";
            // 
            // frmBackUp_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1091, 559);
            this.Controls.Add(this.lblfrmBRTitu);
            this.Controls.Add(this.btnFrmBREliminar);
            this.Controls.Add(this.btnFrmBRRestaurar);
            this.Controls.Add(this.btnFrmBRCrearBackUp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFrmBRExaminar);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmBackUp_Restore";
            this.Text = "frmBackUp_Restore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFrmBRExaminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFrmBRCrearBackUp;
        private System.Windows.Forms.Button btnFrmBRRestaurar;
        private System.Windows.Forms.Button btnFrmBREliminar;
        private System.Windows.Forms.Label lblfrmBRTitu;
    }
}