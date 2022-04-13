namespace ParkingSystem18
{
    partial class FormAlquilerInicio
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
            this.lblTipoAlquiler = new System.Windows.Forms.Label();
            this.rbtAlquilerHora = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtAlquilerMensual = new System.Windows.Forms.RadioButton();
            this.btnComenzarAlquilerHora = new System.Windows.Forms.Button();
            this.lblAlquilerMensualTitular = new System.Windows.Forms.Label();
            this.lblAlquilerTipoVehiculo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnPickup = new System.Windows.Forms.RadioButton();
            this.rbnMoto = new System.Windows.Forms.RadioButton();
            this.rbnAuto = new System.Windows.Forms.RadioButton();
            this.txtAlquilerMensualTitular = new System.Windows.Forms.TextBox();
            this.lblAlquilerMensualCantidadMeses = new System.Windows.Forms.Label();
            this.numAlquilerMensualCantidadMeses = new System.Windows.Forms.NumericUpDown();
            this.lblAlqulerDominio = new System.Windows.Forms.Label();
            this.txtAlquilerDominio = new System.Windows.Forms.TextBox();
            this.lblAlquilerMarca = new System.Windows.Forms.Label();
            this.txtAlquilerMarca = new System.Windows.Forms.TextBox();
            this.lblAlquilerModelo = new System.Windows.Forms.Label();
            this.txtAlquilerModelo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlquilerMensualCantidadMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoAlquiler
            // 
            this.lblTipoAlquiler.AutoSize = true;
            this.lblTipoAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAlquiler.Location = new System.Drawing.Point(43, 39);
            this.lblTipoAlquiler.Name = "lblTipoAlquiler";
            this.lblTipoAlquiler.Size = new System.Drawing.Size(199, 15);
            this.lblTipoAlquiler.TabIndex = 0;
            this.lblTipoAlquiler.Text = "Seleccione el tipo de alquiler:";
            this.lblTipoAlquiler.Click += new System.EventHandler(this.lblTipoAlquiler_Click);
            // 
            // rbtAlquilerHora
            // 
            this.rbtAlquilerHora.AutoSize = true;
            this.rbtAlquilerHora.Checked = true;
            this.rbtAlquilerHora.Location = new System.Drawing.Point(16, 12);
            this.rbtAlquilerHora.Name = "rbtAlquilerHora";
            this.rbtAlquilerHora.Size = new System.Drawing.Size(101, 17);
            this.rbtAlquilerHora.TabIndex = 1;
            this.rbtAlquilerHora.TabStop = true;
            this.rbtAlquilerHora.Text = "Alquiler por hora";
            this.rbtAlquilerHora.UseVisualStyleBackColor = true;
            this.rbtAlquilerHora.CheckedChanged += new System.EventHandler(this.rbtAlquilerHora_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtAlquilerMensual);
            this.panel1.Controls.Add(this.rbtAlquilerHora);
            this.panel1.Location = new System.Drawing.Point(46, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 78);
            this.panel1.TabIndex = 2;
            // 
            // rbtAlquilerMensual
            // 
            this.rbtAlquilerMensual.AutoSize = true;
            this.rbtAlquilerMensual.Location = new System.Drawing.Point(16, 47);
            this.rbtAlquilerMensual.Name = "rbtAlquilerMensual";
            this.rbtAlquilerMensual.Size = new System.Drawing.Size(101, 17);
            this.rbtAlquilerMensual.TabIndex = 2;
            this.rbtAlquilerMensual.Text = "Alquiler mensual";
            this.rbtAlquilerMensual.UseVisualStyleBackColor = true;
            this.rbtAlquilerMensual.CheckedChanged += new System.EventHandler(this.rbtAlquilerMensual_CheckedChanged);
            // 
            // btnComenzarAlquilerHora
            // 
            this.btnComenzarAlquilerHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarAlquilerHora.Location = new System.Drawing.Point(142, 567);
            this.btnComenzarAlquilerHora.Name = "btnComenzarAlquilerHora";
            this.btnComenzarAlquilerHora.Size = new System.Drawing.Size(200, 61);
            this.btnComenzarAlquilerHora.TabIndex = 11;
            this.btnComenzarAlquilerHora.Text = "Realizar Alquiler";
            this.btnComenzarAlquilerHora.UseVisualStyleBackColor = true;
            this.btnComenzarAlquilerHora.Click += new System.EventHandler(this.btnComenzarAlquilerHora_Click);
            // 
            // lblAlquilerMensualTitular
            // 
            this.lblAlquilerMensualTitular.AutoSize = true;
            this.lblAlquilerMensualTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerMensualTitular.Location = new System.Drawing.Point(46, 427);
            this.lblAlquilerMensualTitular.Name = "lblAlquilerMensualTitular";
            this.lblAlquilerMensualTitular.Size = new System.Drawing.Size(120, 16);
            this.lblAlquilerMensualTitular.TabIndex = 4;
            this.lblAlquilerMensualTitular.Text = "Titular Vehiculo:";
            // 
            // lblAlquilerTipoVehiculo
            // 
            this.lblAlquilerTipoVehiculo.AutoSize = true;
            this.lblAlquilerTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerTipoVehiculo.Location = new System.Drawing.Point(46, 171);
            this.lblAlquilerTipoVehiculo.Name = "lblAlquilerTipoVehiculo";
            this.lblAlquilerTipoVehiculo.Size = new System.Drawing.Size(118, 15);
            this.lblAlquilerTipoVehiculo.TabIndex = 5;
            this.lblAlquilerTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbnPickup);
            this.panel2.Controls.Add(this.rbnMoto);
            this.panel2.Controls.Add(this.rbnAuto);
            this.panel2.Location = new System.Drawing.Point(46, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 25);
            this.panel2.TabIndex = 6;
            // 
            // rbnPickup
            // 
            this.rbnPickup.AutoSize = true;
            this.rbnPickup.Location = new System.Drawing.Point(185, 4);
            this.rbnPickup.Name = "rbnPickup";
            this.rbnPickup.Size = new System.Drawing.Size(60, 17);
            this.rbnPickup.TabIndex = 5;
            this.rbnPickup.Text = "PickUp";
            this.rbnPickup.UseVisualStyleBackColor = true;
            // 
            // rbnMoto
            // 
            this.rbnMoto.AutoSize = true;
            this.rbnMoto.Location = new System.Drawing.Point(95, 4);
            this.rbnMoto.Name = "rbnMoto";
            this.rbnMoto.Size = new System.Drawing.Size(49, 17);
            this.rbnMoto.TabIndex = 4;
            this.rbnMoto.Text = "Moto";
            this.rbnMoto.UseVisualStyleBackColor = true;
            // 
            // rbnAuto
            // 
            this.rbnAuto.AutoSize = true;
            this.rbnAuto.Checked = true;
            this.rbnAuto.Location = new System.Drawing.Point(5, 4);
            this.rbnAuto.Name = "rbnAuto";
            this.rbnAuto.Size = new System.Drawing.Size(47, 17);
            this.rbnAuto.TabIndex = 3;
            this.rbnAuto.Text = "Auto";
            this.rbnAuto.UseVisualStyleBackColor = true;
            // 
            // txtAlquilerMensualTitular
            // 
            this.txtAlquilerMensualTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlquilerMensualTitular.Enabled = false;
            this.txtAlquilerMensualTitular.Location = new System.Drawing.Point(49, 474);
            this.txtAlquilerMensualTitular.Name = "txtAlquilerMensualTitular";
            this.txtAlquilerMensualTitular.Size = new System.Drawing.Size(149, 20);
            this.txtAlquilerMensualTitular.TabIndex = 9;
            this.txtAlquilerMensualTitular.TextChanged += new System.EventHandler(this.txtAlquilerMensualTitular_TextChanged);
            // 
            // lblAlquilerMensualCantidadMeses
            // 
            this.lblAlquilerMensualCantidadMeses.AutoSize = true;
            this.lblAlquilerMensualCantidadMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerMensualCantidadMeses.Location = new System.Drawing.Point(43, 526);
            this.lblAlquilerMensualCantidadMeses.Name = "lblAlquilerMensualCantidadMeses";
            this.lblAlquilerMensualCantidadMeses.Size = new System.Drawing.Size(130, 15);
            this.lblAlquilerMensualCantidadMeses.TabIndex = 8;
            this.lblAlquilerMensualCantidadMeses.Text = "Meses de alquiler: ";
            // 
            // numAlquilerMensualCantidadMeses
            // 
            this.numAlquilerMensualCantidadMeses.Enabled = false;
            this.numAlquilerMensualCantidadMeses.Location = new System.Drawing.Point(179, 526);
            this.numAlquilerMensualCantidadMeses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlquilerMensualCantidadMeses.Name = "numAlquilerMensualCantidadMeses";
            this.numAlquilerMensualCantidadMeses.Size = new System.Drawing.Size(63, 20);
            this.numAlquilerMensualCantidadMeses.TabIndex = 10;
            this.numAlquilerMensualCantidadMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlquilerMensualCantidadMeses.ValueChanged += new System.EventHandler(this.numAlquilerMensualCantidadMeses_ValueChanged);
            // 
            // lblAlqulerDominio
            // 
            this.lblAlqulerDominio.AutoSize = true;
            this.lblAlqulerDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlqulerDominio.Location = new System.Drawing.Point(46, 254);
            this.lblAlqulerDominio.Name = "lblAlqulerDominio";
            this.lblAlqulerDominio.Size = new System.Drawing.Size(69, 16);
            this.lblAlqulerDominio.TabIndex = 10;
            this.lblAlqulerDominio.Text = "Dominio:";
            // 
            // txtAlquilerDominio
            // 
            this.txtAlquilerDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlquilerDominio.Location = new System.Drawing.Point(49, 290);
            this.txtAlquilerDominio.Name = "txtAlquilerDominio";
            this.txtAlquilerDominio.Size = new System.Drawing.Size(250, 20);
            this.txtAlquilerDominio.TabIndex = 6;
            // 
            // lblAlquilerMarca
            // 
            this.lblAlquilerMarca.AutoSize = true;
            this.lblAlquilerMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerMarca.Location = new System.Drawing.Point(46, 336);
            this.lblAlquilerMarca.Name = "lblAlquilerMarca";
            this.lblAlquilerMarca.Size = new System.Drawing.Size(55, 16);
            this.lblAlquilerMarca.TabIndex = 12;
            this.lblAlquilerMarca.Text = "Marca:";
            // 
            // txtAlquilerMarca
            // 
            this.txtAlquilerMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlquilerMarca.Location = new System.Drawing.Point(46, 372);
            this.txtAlquilerMarca.Name = "txtAlquilerMarca";
            this.txtAlquilerMarca.Size = new System.Drawing.Size(152, 20);
            this.txtAlquilerMarca.TabIndex = 7;
            // 
            // lblAlquilerModelo
            // 
            this.lblAlquilerModelo.AutoSize = true;
            this.lblAlquilerModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerModelo.Location = new System.Drawing.Point(229, 336);
            this.lblAlquilerModelo.Name = "lblAlquilerModelo";
            this.lblAlquilerModelo.Size = new System.Drawing.Size(64, 16);
            this.lblAlquilerModelo.TabIndex = 14;
            this.lblAlquilerModelo.Text = "Modelo:";
            // 
            // txtAlquilerModelo
            // 
            this.txtAlquilerModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlquilerModelo.Location = new System.Drawing.Point(232, 372);
            this.txtAlquilerModelo.Name = "txtAlquilerModelo";
            this.txtAlquilerModelo.Size = new System.Drawing.Size(152, 20);
            this.txtAlquilerModelo.TabIndex = 8;
            // 
            // FormAlquilerInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingSystem18.Properties.Resources._166513875_7473867562_b;
            this.ClientSize = new System.Drawing.Size(474, 640);
            this.Controls.Add(this.txtAlquilerModelo);
            this.Controls.Add(this.lblAlquilerModelo);
            this.Controls.Add(this.txtAlquilerMarca);
            this.Controls.Add(this.lblAlquilerMarca);
            this.Controls.Add(this.txtAlquilerDominio);
            this.Controls.Add(this.lblAlqulerDominio);
            this.Controls.Add(this.numAlquilerMensualCantidadMeses);
            this.Controls.Add(this.lblAlquilerMensualCantidadMeses);
            this.Controls.Add(this.txtAlquilerMensualTitular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAlquilerTipoVehiculo);
            this.Controls.Add(this.lblAlquilerMensualTitular);
            this.Controls.Add(this.btnComenzarAlquilerHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipoAlquiler);
            this.MaximizeBox = false;
            this.Name = "FormAlquilerInicio";
            this.Text = " Parking System 18";
            this.Load += new System.EventHandler(this.FormAlquilerInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlquilerMensualCantidadMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAlquiler;
        private System.Windows.Forms.RadioButton rbtAlquilerHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtAlquilerMensual;
        private System.Windows.Forms.Button btnComenzarAlquilerHora;
        private System.Windows.Forms.Label lblAlquilerMensualTitular;
        private System.Windows.Forms.Label lblAlquilerTipoVehiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnPickup;
        private System.Windows.Forms.RadioButton rbnMoto;
        private System.Windows.Forms.RadioButton rbnAuto;
        private System.Windows.Forms.TextBox txtAlquilerMensualTitular;
        private System.Windows.Forms.Label lblAlquilerMensualCantidadMeses;
        private System.Windows.Forms.NumericUpDown numAlquilerMensualCantidadMeses;
        private System.Windows.Forms.Label lblAlqulerDominio;
        private System.Windows.Forms.TextBox txtAlquilerDominio;
        private System.Windows.Forms.Label lblAlquilerMarca;
        private System.Windows.Forms.TextBox txtAlquilerMarca;
        private System.Windows.Forms.Label lblAlquilerModelo;
        private System.Windows.Forms.TextBox txtAlquilerModelo;
    }
}