namespace BlackGym
{
    partial class Recepcion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eliminarTurno = new System.Windows.Forms.Button();
            this.dgvMuestroTurnos = new System.Windows.Forms.DataGridView();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BtnModificarUsuario = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvMostrarUsuario = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestroTurnos)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.BotonCerrarSesion);
            this.tabPage1.Controls.Add(this.eliminarTurno);
            this.tabPage1.Controls.Add(this.dgvMuestroTurnos);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1277, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INICIO";
            // 
            // eliminarTurno
            // 
            this.eliminarTurno.BackColor = System.Drawing.Color.Maroon;
            this.eliminarTurno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eliminarTurno.FlatAppearance.BorderSize = 3;
            this.eliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarTurno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eliminarTurno.Location = new System.Drawing.Point(801, 447);
            this.eliminarTurno.Name = "eliminarTurno";
            this.eliminarTurno.Size = new System.Drawing.Size(130, 34);
            this.eliminarTurno.TabIndex = 31;
            this.eliminarTurno.Text = "Eliminar turno";
            this.eliminarTurno.UseVisualStyleBackColor = false;
            this.eliminarTurno.Click += new System.EventHandler(this.eliminarTurno_Click);
            // 
            // dgvMuestroTurnos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestroTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMuestroTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMuestroTurnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMuestroTurnos.Location = new System.Drawing.Point(68, -4);
            this.dgvMuestroTurnos.Name = "dgvMuestroTurnos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestroTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMuestroTurnos.RowHeadersWidth = 51;
            this.dgvMuestroTurnos.RowTemplate.Height = 24;
            this.dgvMuestroTurnos.Size = new System.Drawing.Size(646, 603);
            this.dgvMuestroTurnos.TabIndex = 0;
            this.dgvMuestroTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestroTurno_CellContentClick);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1465, 612);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 3;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.guna2GroupBox2);
            this.tabPage2.Controls.Add(this.guna2Button2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1277, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Panel de usuarios";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderRadius = 30;
            this.guna2GroupBox2.BorderThickness = 3;
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.txtFechaPago);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.txtID);
            this.guna2GroupBox2.Controls.Add(this.BtnModificarUsuario);
            this.guna2GroupBox2.Controls.Add(this.txtRol);
            this.guna2GroupBox2.Controls.Add(this.txtTelefono);
            this.guna2GroupBox2.Controls.Add(this.txtCorreo);
            this.guna2GroupBox2.Controls.Add(this.txtNombre);
            this.guna2GroupBox2.Controls.Add(this.dgvMostrarUsuario);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox2.Location = new System.Drawing.Point(152, 42);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(967, 837);
            this.guna2GroupBox2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(689, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fecha de pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(690, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "ID de usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(689, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(690, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Número telefonico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(689, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(689, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre de usuario";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaPago.Location = new System.Drawing.Point(670, 417);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(211, 27);
            this.txtFechaPago.TabIndex = 19;
            this.txtFechaPago.Value = new System.DateTime(2025, 11, 10, 17, 47, 33, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(428, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "// Acreditar Usuario";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(670, 346);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 27);
            this.txtID.TabIndex = 16;
            // 
            // BtnModificarUsuario
            // 
            this.BtnModificarUsuario.Location = new System.Drawing.Point(706, 478);
            this.BtnModificarUsuario.Name = "BtnModificarUsuario";
            this.BtnModificarUsuario.Size = new System.Drawing.Size(130, 34);
            this.BtnModificarUsuario.TabIndex = 15;
            this.BtnModificarUsuario.Text = "Modificar";
            this.BtnModificarUsuario.UseVisualStyleBackColor = true;
            this.BtnModificarUsuario.Click += new System.EventHandler(this.BtnModificarUsuario_Click);
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Location = new System.Drawing.Point(670, 274);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(211, 27);
            this.txtRol.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(670, 203);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(211, 27);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(670, 135);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(211, 27);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(670, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // dgvMostrarUsuario
            // 
            this.dgvMostrarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarUsuario.Location = new System.Drawing.Point(39, 103);
            this.dgvMostrarUsuario.Name = "dgvMostrarUsuario";
            this.dgvMostrarUsuario.RowHeadersWidth = 51;
            this.dgvMostrarUsuario.RowTemplate.Height = 24;
            this.dgvMostrarUsuario.Size = new System.Drawing.Size(607, 341);
            this.dgvMostrarUsuario.TabIndex = 10;
            this.dgvMostrarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarUsuario_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(346, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "MODIFICAR USUARIO";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(1277, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "PANEL DE USUARIOS";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BotonCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(783, 497);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(167, 52);
            this.BotonCerrarSesion.TabIndex = 32;
            this.BotonCerrarSesion.Text = "CerrarSesion";
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 612);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "Recepcion";
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.Recepcion_Load_1);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestroTurnos)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.DataGridView dgvMuestroTurnos;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFechaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BtnModificarUsuario;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvMostrarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eliminarTurno;
        private System.Windows.Forms.Button BotonCerrarSesion;
    }
}