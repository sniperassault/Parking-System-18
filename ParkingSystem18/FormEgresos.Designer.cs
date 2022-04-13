namespace ParkingSystem18
{
    partial class FormEgresos
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
            this.lblEgresoConcepto = new System.Windows.Forms.Label();
            this.lblEgresoImporte = new System.Windows.Forms.Label();
            this.txtEgresosConcepto = new System.Windows.Forms.TextBox();
            this.btnEgresoCargar = new System.Windows.Forms.Button();
            this.mtbEgresoImporte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mtbEgresoImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEgresoConcepto
            // 
            this.lblEgresoConcepto.AutoSize = true;
            this.lblEgresoConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresoConcepto.Location = new System.Drawing.Point(13, 24);
            this.lblEgresoConcepto.Name = "lblEgresoConcepto";
            this.lblEgresoConcepto.Size = new System.Drawing.Size(78, 16);
            this.lblEgresoConcepto.TabIndex = 0;
            this.lblEgresoConcepto.Text = "Concepto:";
            // 
            // lblEgresoImporte
            // 
            this.lblEgresoImporte.AutoSize = true;
            this.lblEgresoImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresoImporte.Location = new System.Drawing.Point(13, 95);
            this.lblEgresoImporte.Name = "lblEgresoImporte";
            this.lblEgresoImporte.Size = new System.Drawing.Size(64, 16);
            this.lblEgresoImporte.TabIndex = 1;
            this.lblEgresoImporte.Text = "Importe:";
            // 
            // txtEgresosConcepto
            // 
            this.txtEgresosConcepto.Location = new System.Drawing.Point(16, 54);
            this.txtEgresosConcepto.Name = "txtEgresosConcepto";
            this.txtEgresosConcepto.Size = new System.Drawing.Size(199, 20);
            this.txtEgresosConcepto.TabIndex = 2;
            // 
            // btnEgresoCargar
            // 
            this.btnEgresoCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresoCargar.Location = new System.Drawing.Point(16, 184);
            this.btnEgresoCargar.Name = "btnEgresoCargar";
            this.btnEgresoCargar.Size = new System.Drawing.Size(199, 54);
            this.btnEgresoCargar.TabIndex = 4;
            this.btnEgresoCargar.Text = "Guardar egreso";
            this.btnEgresoCargar.UseVisualStyleBackColor = true;
            this.btnEgresoCargar.Click += new System.EventHandler(this.btnEgresoCargar_Click);
            // 
            // mtbEgresoImporte
            // 
            this.mtbEgresoImporte.DecimalPlaces = 2;
            this.mtbEgresoImporte.Location = new System.Drawing.Point(16, 134);
            this.mtbEgresoImporte.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.mtbEgresoImporte.Name = "mtbEgresoImporte";
            this.mtbEgresoImporte.Size = new System.Drawing.Size(120, 20);
            this.mtbEgresoImporte.TabIndex = 5;
            // 
            // FormEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingSystem18.Properties.Resources._166513875_7473867562_b;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mtbEgresoImporte);
            this.Controls.Add(this.btnEgresoCargar);
            this.Controls.Add(this.txtEgresosConcepto);
            this.Controls.Add(this.lblEgresoImporte);
            this.Controls.Add(this.lblEgresoConcepto);
            this.MaximizeBox = false;
            this.Name = "FormEgresos";
            this.Text = "Parking System 18";
            this.Load += new System.EventHandler(this.FormEgresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtbEgresoImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEgresoConcepto;
        private System.Windows.Forms.Label lblEgresoImporte;
        private System.Windows.Forms.TextBox txtEgresosConcepto;
        private System.Windows.Forms.Button btnEgresoCargar;
        private System.Windows.Forms.NumericUpDown mtbEgresoImporte;
    }
}