namespace ParkingSystem18
{
    partial class FormAlquilerFinalizar
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
            this.btnFinalizarAlquiler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numAlquilerMensualRenovacion = new System.Windows.Forms.NumericUpDown();
            this.lblRenovarAlquiler = new System.Windows.Forms.Label();
            this.btnRenovarAlquiler = new System.Windows.Forms.Button();
            this.lblFinalizarAlquilerFechaIngreso = new System.Windows.Forms.Label();
            this.lblFinalizarAlquilerFecha = new System.Windows.Forms.Label();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.lblImporteParcial = new System.Windows.Forms.Label();
            this.lblImporteParcialMostrar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlquilerMensualRenovacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizarAlquiler
            // 
            this.btnFinalizarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarAlquiler.Location = new System.Drawing.Point(47, 23);
            this.btnFinalizarAlquiler.Name = "btnFinalizarAlquiler";
            this.btnFinalizarAlquiler.Size = new System.Drawing.Size(105, 52);
            this.btnFinalizarAlquiler.TabIndex = 0;
            this.btnFinalizarAlquiler.Text = "Finalizar alquiler";
            this.btnFinalizarAlquiler.UseVisualStyleBackColor = true;
            this.btnFinalizarAlquiler.Click += new System.EventHandler(this.btnFinalizarAlquiler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFinalizarAlquiler);
            this.panel1.Location = new System.Drawing.Point(46, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numAlquilerMensualRenovacion);
            this.panel2.Controls.Add(this.lblRenovarAlquiler);
            this.panel2.Controls.Add(this.btnRenovarAlquiler);
            this.panel2.Location = new System.Drawing.Point(46, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 206);
            this.panel2.TabIndex = 4;
            // 
            // numAlquilerMensualRenovacion
            // 
            this.numAlquilerMensualRenovacion.Enabled = false;
            this.numAlquilerMensualRenovacion.Location = new System.Drawing.Point(44, 74);
            this.numAlquilerMensualRenovacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlquilerMensualRenovacion.Name = "numAlquilerMensualRenovacion";
            this.numAlquilerMensualRenovacion.Size = new System.Drawing.Size(105, 20);
            this.numAlquilerMensualRenovacion.TabIndex = 7;
            this.numAlquilerMensualRenovacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRenovarAlquiler
            // 
            this.lblRenovarAlquiler.AutoSize = true;
            this.lblRenovarAlquiler.BackColor = System.Drawing.Color.White;
            this.lblRenovarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenovarAlquiler.Location = new System.Drawing.Point(8, 31);
            this.lblRenovarAlquiler.Name = "lblRenovarAlquiler";
            this.lblRenovarAlquiler.Size = new System.Drawing.Size(176, 13);
            this.lblRenovarAlquiler.TabIndex = 6;
            this.lblRenovarAlquiler.Text = "Cantidad de meses a renovar:";
            // 
            // btnRenovarAlquiler
            // 
            this.btnRenovarAlquiler.Enabled = false;
            this.btnRenovarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarAlquiler.Location = new System.Drawing.Point(44, 124);
            this.btnRenovarAlquiler.Name = "btnRenovarAlquiler";
            this.btnRenovarAlquiler.Size = new System.Drawing.Size(105, 52);
            this.btnRenovarAlquiler.TabIndex = 5;
            this.btnRenovarAlquiler.Text = "Renovar Alquiler";
            this.btnRenovarAlquiler.UseVisualStyleBackColor = true;
            this.btnRenovarAlquiler.Click += new System.EventHandler(this.btnRenovarAlquiler_Click);
            // 
            // lblFinalizarAlquilerFechaIngreso
            // 
            this.lblFinalizarAlquilerFechaIngreso.AutoSize = true;
            this.lblFinalizarAlquilerFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarAlquilerFechaIngreso.Location = new System.Drawing.Point(43, 13);
            this.lblFinalizarAlquilerFechaIngreso.Name = "lblFinalizarAlquilerFechaIngreso";
            this.lblFinalizarAlquilerFechaIngreso.Size = new System.Drawing.Size(221, 16);
            this.lblFinalizarAlquilerFechaIngreso.TabIndex = 5;
            this.lblFinalizarAlquilerFechaIngreso.Text = "Fecha de ingreso del vehiculo:";
            this.lblFinalizarAlquilerFechaIngreso.Click += new System.EventHandler(this.lblFinalizarAlquilerFechaIngreso_Click);
            // 
            // lblFinalizarAlquilerFecha
            // 
            this.lblFinalizarAlquilerFecha.AutoSize = true;
            this.lblFinalizarAlquilerFecha.BackColor = System.Drawing.Color.GreenYellow;
            this.lblFinalizarAlquilerFecha.Location = new System.Drawing.Point(56, 54);
            this.lblFinalizarAlquilerFecha.Name = "lblFinalizarAlquilerFecha";
            this.lblFinalizarAlquilerFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFinalizarAlquilerFecha.TabIndex = 6;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(95, 144);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(105, 23);
            this.btnVerDatos.TabIndex = 7;
            this.btnVerDatos.Text = "Ver datos vehiculo";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // lblImporteParcial
            // 
            this.lblImporteParcial.AutoSize = true;
            this.lblImporteParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteParcial.Location = new System.Drawing.Point(43, 92);
            this.lblImporteParcial.Name = "lblImporteParcial";
            this.lblImporteParcial.Size = new System.Drawing.Size(116, 16);
            this.lblImporteParcial.TabIndex = 8;
            this.lblImporteParcial.Text = "Importe parcial:";
            // 
            // lblImporteParcialMostrar
            // 
            this.lblImporteParcialMostrar.AutoSize = true;
            this.lblImporteParcialMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteParcialMostrar.Location = new System.Drawing.Point(165, 103);
            this.lblImporteParcialMostrar.Name = "lblImporteParcialMostrar";
            this.lblImporteParcialMostrar.Size = new System.Drawing.Size(0, 16);
            this.lblImporteParcialMostrar.TabIndex = 9;
            // 
            // FormAlquilerFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingSystem18.Properties.Resources._166513875_7473867562_b;
            this.ClientSize = new System.Drawing.Size(284, 536);
            this.Controls.Add(this.lblImporteParcialMostrar);
            this.Controls.Add(this.lblImporteParcial);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.lblFinalizarAlquilerFecha);
            this.Controls.Add(this.lblFinalizarAlquilerFechaIngreso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormAlquilerFinalizar";
            this.Text = "Parking System 18";
            this.Load += new System.EventHandler(this.FormAlquilerFinalizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlquilerMensualRenovacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizarAlquiler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numAlquilerMensualRenovacion;
        private System.Windows.Forms.Label lblRenovarAlquiler;
        private System.Windows.Forms.Button btnRenovarAlquiler;
        private System.Windows.Forms.Label lblFinalizarAlquilerFechaIngreso;
        private System.Windows.Forms.Label lblFinalizarAlquilerFecha;
        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Label lblImporteParcial;
        private System.Windows.Forms.Label lblImporteParcialMostrar;
    }
}