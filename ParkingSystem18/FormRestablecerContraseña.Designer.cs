namespace ParkingSystem18
{
    partial class FormRestablecerContraseña
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(142, 35);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(170, 16);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Pregunta de seguridad:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(46, 82);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ReadOnly = true;
            this.txtPregunta.Size = new System.Drawing.Size(363, 20);
            this.txtPregunta.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(174, 154);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(87, 16);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(45, 212);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(363, 20);
            this.txtRespuesta.TabIndex = 3;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(166, 282);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(109, 67);
            this.btnRestablecer.TabIndex = 4;
            this.btnRestablecer.Text = "Restablecer Contraseña";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // FormRestablecerContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingSystem18.Properties.Resources._166513875_7473867562_b;
            this.ClientSize = new System.Drawing.Size(452, 391);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblPregunta);
            this.MaximizeBox = false;
            this.Name = "FormRestablecerContraseña";
            this.Text = "Parking System 18";
            this.Load += new System.EventHandler(this.FormRestablecerContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnRestablecer;
    }
}