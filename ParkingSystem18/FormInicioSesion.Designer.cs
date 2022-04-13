namespace ParkingSystem18
{
    partial class FormInicioSesion
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
            this.lblInicioSesionUser = new System.Windows.Forms.Label();
            this.lblInicioSesionPassword = new System.Windows.Forms.Label();
            this.txtIniciarSesionUser = new System.Windows.Forms.TextBox();
            this.txtIniciarSesionPassword = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblRestablecerContraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblInicioSesionUser
            // 
            this.lblInicioSesionUser.AutoSize = true;
            this.lblInicioSesionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesionUser.Location = new System.Drawing.Point(106, 10);
            this.lblInicioSesionUser.Name = "lblInicioSesionUser";
            this.lblInicioSesionUser.Size = new System.Drawing.Size(66, 16);
            this.lblInicioSesionUser.TabIndex = 0;
            this.lblInicioSesionUser.Text = "Usuario:";
            // 
            // lblInicioSesionPassword
            // 
            this.lblInicioSesionPassword.AutoSize = true;
            this.lblInicioSesionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesionPassword.Location = new System.Drawing.Point(94, 110);
            this.lblInicioSesionPassword.Name = "lblInicioSesionPassword";
            this.lblInicioSesionPassword.Size = new System.Drawing.Size(91, 16);
            this.lblInicioSesionPassword.TabIndex = 1;
            this.lblInicioSesionPassword.Text = "Contraseña:";
            // 
            // txtIniciarSesionUser
            // 
            this.txtIniciarSesionUser.Location = new System.Drawing.Point(12, 60);
            this.txtIniciarSesionUser.Name = "txtIniciarSesionUser";
            this.txtIniciarSesionUser.Size = new System.Drawing.Size(260, 20);
            this.txtIniciarSesionUser.TabIndex = 2;
            // 
            // txtIniciarSesionPassword
            // 
            this.txtIniciarSesionPassword.Location = new System.Drawing.Point(12, 160);
            this.txtIniciarSesionPassword.Name = "txtIniciarSesionPassword";
            this.txtIniciarSesionPassword.PasswordChar = '*';
            this.txtIniciarSesionPassword.Size = new System.Drawing.Size(260, 20);
            this.txtIniciarSesionPassword.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(97, 210);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(88, 58);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblRestablecerContraseña
            // 
            this.lblRestablecerContraseña.AutoSize = true;
            this.lblRestablecerContraseña.Location = new System.Drawing.Point(12, 320);
            this.lblRestablecerContraseña.Name = "lblRestablecerContraseña";
            this.lblRestablecerContraseña.Size = new System.Drawing.Size(106, 13);
            this.lblRestablecerContraseña.TabIndex = 5;
            this.lblRestablecerContraseña.TabStop = true;
            this.lblRestablecerContraseña.Text = "Olvide mi contraseña";
            this.lblRestablecerContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRestablecerContraseña_LinkClicked);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingSystem18.Properties.Resources.Parking_area_top_view_pavement_yellow_lines_yellow_red_blue_cars_2560x1600;
            this.ClientSize = new System.Drawing.Size(284, 369);
            this.Controls.Add(this.lblRestablecerContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtIniciarSesionPassword);
            this.Controls.Add(this.txtIniciarSesionUser);
            this.Controls.Add(this.lblInicioSesionPassword);
            this.Controls.Add(this.lblInicioSesionUser);
            this.MaximizeBox = false;
            this.Name = "FormInicioSesion";
            this.Text = "Parking System 18";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioSesionUser;
        private System.Windows.Forms.Label lblInicioSesionPassword;
        private System.Windows.Forms.TextBox txtIniciarSesionUser;
        private System.Windows.Forms.TextBox txtIniciarSesionPassword;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel lblRestablecerContraseña;
    }
}