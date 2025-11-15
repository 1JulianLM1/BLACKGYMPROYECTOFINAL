namespace BlackGym
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.MostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SalirPrograma = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Registro = new System.Windows.Forms.LinkLabel();
            this.InicioSesion = new System.Windows.Forms.Button();
            this.ContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.MostrarContraseña);
            this.panel2.Controls.Add(this.SalirPrograma);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.Registro);
            this.panel2.Controls.Add(this.InicioSesion);
            this.panel2.Controls.Add(this.ContraseñaUsuario);
            this.panel2.Controls.Add(this.NombreUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(352, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 733);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(169, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mostrar contraseña";
            // 
            // MostrarContraseña
            // 
            this.MostrarContraseña.AutoSize = true;
            this.MostrarContraseña.Location = new System.Drawing.Point(145, 285);
            this.MostrarContraseña.Name = "MostrarContraseña";
            this.MostrarContraseña.Size = new System.Drawing.Size(18, 17);
            this.MostrarContraseña.TabIndex = 35;
            this.MostrarContraseña.UseVisualStyleBackColor = true;
            this.MostrarContraseña.CheckedChanged += new System.EventHandler(this.MostrarContraseña_CheckedChanged);
            // 
            // SalirPrograma
            // 
            this.SalirPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SalirPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalirPrograma.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.SalirPrograma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SalirPrograma.Location = new System.Drawing.Point(157, 492);
            this.SalirPrograma.Name = "SalirPrograma";
            this.SalirPrograma.Size = new System.Drawing.Size(167, 52);
            this.SalirPrograma.TabIndex = 34;
            this.SalirPrograma.Text = "Cerrar";
            this.SalirPrograma.UseVisualStyleBackColor = false;
            this.SalirPrograma.Click += new System.EventHandler(this.SalirPrograma_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(170, 437);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidaste la contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.LinkColor = System.Drawing.Color.White;
            this.Registro.Location = new System.Drawing.Point(204, 400);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(77, 16);
            this.Registro.TabIndex = 7;
            this.Registro.TabStop = true;
            this.Registro.Text = "Registrarse";
            this.Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registro_LinkClicked);
            // 
            // InicioSesion
            // 
            this.InicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InicioSesion.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InicioSesion.Location = new System.Drawing.Point(157, 317);
            this.InicioSesion.Name = "InicioSesion";
            this.InicioSesion.Size = new System.Drawing.Size(167, 52);
            this.InicioSesion.TabIndex = 6;
            this.InicioSesion.Text = "Ingresar";
            this.InicioSesion.UseVisualStyleBackColor = false;
            this.InicioSesion.Click += new System.EventHandler(this.InicioSesion_Click);
            // 
            // ContraseñaUsuario
            // 
            this.ContraseñaUsuario.Location = new System.Drawing.Point(99, 249);
            this.ContraseñaUsuario.Name = "ContraseñaUsuario";
            this.ContraseñaUsuario.Size = new System.Drawing.Size(285, 22);
            this.ContraseñaUsuario.TabIndex = 4;
            this.ContraseñaUsuario.TextChanged += new System.EventHandler(this.ContraseñaUsuario_TextChanged);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Location = new System.Drawing.Point(99, 154);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(285, 22);
            this.NombreUsuario.TabIndex = 3;
            this.NombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(94, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1223, 642);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel Registro;
        private System.Windows.Forms.Button InicioSesion;
        private System.Windows.Forms.TextBox ContraseñaUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalirPrograma;
        private System.Windows.Forms.CheckBox MostrarContraseña;
        private System.Windows.Forms.Label label7;
    }
}

