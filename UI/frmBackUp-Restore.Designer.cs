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
            this.btnFrmBRVerError = new System.Windows.Forms.Button();
            this.btnFrmBRCrearBackUp = new System.Windows.Forms.Button();
            this.btnFrmBRRestaurar = new System.Windows.Forms.Button();
            this.btnFrmBRSolucionarErrores = new System.Windows.Forms.Button();
            this.lblfrmBRTitu = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblfrmBRInfoGenBk = new System.Windows.Forms.Label();
            this.lblfrmBRInfoR = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnFrmBRVerError
            // 
            this.btnFrmBRVerError.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRVerError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRVerError.Location = new System.Drawing.Point(146, 226);
            this.btnFrmBRVerError.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrmBRVerError.Name = "btnFrmBRVerError";
            this.btnFrmBRVerError.Size = new System.Drawing.Size(113, 32);
            this.btnFrmBRVerError.TabIndex = 1;
            this.btnFrmBRVerError.Text = " Ver Error DV";
            this.btnFrmBRVerError.UseVisualStyleBackColor = false;
            this.btnFrmBRVerError.Click += new System.EventHandler(this.btnFrmBRVerError_Click);
            // 
            // btnFrmBRCrearBackUp
            // 
            this.btnFrmBRCrearBackUp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRCrearBackUp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRCrearBackUp.Location = new System.Drawing.Point(146, 165);
            this.btnFrmBRCrearBackUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrmBRCrearBackUp.Name = "btnFrmBRCrearBackUp";
            this.btnFrmBRCrearBackUp.Size = new System.Drawing.Size(113, 32);
            this.btnFrmBRCrearBackUp.TabIndex = 3;
            this.btnFrmBRCrearBackUp.Text = "Crear BackUp";
            this.btnFrmBRCrearBackUp.UseVisualStyleBackColor = false;
            this.btnFrmBRCrearBackUp.Click += new System.EventHandler(this.btnFrmBRCrearBackUp_Click);
            // 
            // btnFrmBRRestaurar
            // 
            this.btnFrmBRRestaurar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRRestaurar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRRestaurar.Location = new System.Drawing.Point(145, 358);
            this.btnFrmBRRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrmBRRestaurar.Name = "btnFrmBRRestaurar";
            this.btnFrmBRRestaurar.Size = new System.Drawing.Size(113, 32);
            this.btnFrmBRRestaurar.TabIndex = 4;
            this.btnFrmBRRestaurar.Text = "Restaurar Base";
            this.btnFrmBRRestaurar.UseVisualStyleBackColor = false;
            this.btnFrmBRRestaurar.Click += new System.EventHandler(this.btnFrmBRRestaurar_Click);
            // 
            // btnFrmBRSolucionarErrores
            // 
            this.btnFrmBRSolucionarErrores.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFrmBRSolucionarErrores.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmBRSolucionarErrores.Location = new System.Drawing.Point(145, 420);
            this.btnFrmBRSolucionarErrores.Margin = new System.Windows.Forms.Padding(2);
            this.btnFrmBRSolucionarErrores.Name = "btnFrmBRSolucionarErrores";
            this.btnFrmBRSolucionarErrores.Size = new System.Drawing.Size(113, 45);
            this.btnFrmBRSolucionarErrores.TabIndex = 5;
            this.btnFrmBRSolucionarErrores.Text = "Solucionar Errores";
            this.btnFrmBRSolucionarErrores.UseVisualStyleBackColor = false;
            this.btnFrmBRSolucionarErrores.Click += new System.EventHandler(this.btnFrmBRSolucionarErrores_Click);
            // 
            // lblfrmBRTitu
            // 
            this.lblfrmBRTitu.AutoSize = true;
            this.lblfrmBRTitu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrmBRTitu.Location = new System.Drawing.Point(10, 11);
            this.lblfrmBRTitu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrmBRTitu.Name = "lblfrmBRTitu";
            this.lblfrmBRTitu.Size = new System.Drawing.Size(130, 19);
            this.lblfrmBRTitu.TabIndex = 6;
            this.lblfrmBRTitu.Text = "BackUp-Restore";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 319);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 23);
            this.textBox2.TabIndex = 7;
            // 
            // lblfrmBRInfoGenBk
            // 
            this.lblfrmBRInfoGenBk.AutoSize = true;
            this.lblfrmBRInfoGenBk.Location = new System.Drawing.Point(11, 58);
            this.lblfrmBRInfoGenBk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrmBRInfoGenBk.Name = "lblfrmBRInfoGenBk";
            this.lblfrmBRInfoGenBk.Size = new System.Drawing.Size(834, 13);
            this.lblfrmBRInfoGenBk.TabIndex = 1;
            this.lblfrmBRInfoGenBk.Text = "Debe ingresar una ruta existente en su dispositivo y al final ingresar el nombre " +
    "del archivo con el que desea guardar el backup. Ej: \'C:\\BackupVSStudio\\NombreBdB" +
    "ackup.bak\'";
            // 
            // lblfrmBRInfoR
            // 
            this.lblfrmBRInfoR.AutoSize = true;
            this.lblfrmBRInfoR.Location = new System.Drawing.Point(11, 273);
            this.lblfrmBRInfoR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrmBRInfoR.Name = "lblfrmBRInfoR";
            this.lblfrmBRInfoR.Size = new System.Drawing.Size(696, 13);
            this.lblfrmBRInfoR.TabIndex = 8;
            this.lblfrmBRInfoR.Text = "Debe ingresar la ruta correspondiente a la ubicación donde se encuenta el archivo" +
    " a restaurar. Ej: \'C:\\BackupVSStudio\\NombreBdRestaurar.bak\' ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmBackUp_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(877, 503);
            this.Controls.Add(this.lblfrmBRInfoR);
            this.Controls.Add(this.lblfrmBRInfoGenBk);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblfrmBRTitu);
            this.Controls.Add(this.btnFrmBRSolucionarErrores);
            this.Controls.Add(this.btnFrmBRRestaurar);
            this.Controls.Add(this.btnFrmBRCrearBackUp);
            this.Controls.Add(this.btnFrmBRVerError);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBackUp_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackUp_Restore";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFrmBRVerError;
        private System.Windows.Forms.Button btnFrmBRCrearBackUp;
        private System.Windows.Forms.Button btnFrmBRRestaurar;
        private System.Windows.Forms.Button btnFrmBRSolucionarErrores;
        private System.Windows.Forms.Label lblfrmBRTitu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblfrmBRInfoGenBk;
        private System.Windows.Forms.Label lblfrmBRInfoR;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}