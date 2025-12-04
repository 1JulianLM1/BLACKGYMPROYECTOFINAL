namespace BlackGym
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.eliminarTurno = new System.Windows.Forms.Button();
            this.dgvMuestroTurnos = new System.Windows.Forms.DataGridView();
            this.BotonCerrarSesion = new System.Windows.Forms.Button();
            this.MiFechaVencimiento = new System.Windows.Forms.TextBox();
            this.MiFechaAbono = new System.Windows.Forms.TextBox();
            this.IngresoRestanteT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abono = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BotonTemporizador = new Guna.UI2.WinForms.Guna2Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.guardarT = new Guna.UI2.WinForms.Guna2Button();
            this.listaHorarios = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaTurno = new System.Windows.Forms.DateTimePicker();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.MisTurnosSemanalesCBX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuotaMensual = new System.Windows.Forms.TextBox();
            this.BotonPago = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.TurnoClienteTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRefrsh = new System.Windows.Forms.Button();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestroTurnos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1532, 866);
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
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.guna2GroupBox1);
            this.tabPage1.Controls.Add(this.guna2Button1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1344, 858);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INICIO";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderRadius = 30;
            this.guna2GroupBox1.BorderThickness = 3;
            this.guna2GroupBox1.Controls.Add(this.btnRefrsh);
            this.guna2GroupBox1.Controls.Add(this.eliminarTurno);
            this.guna2GroupBox1.Controls.Add(this.dgvMuestroTurnos);
            this.guna2GroupBox1.Controls.Add(this.BotonCerrarSesion);
            this.guna2GroupBox1.Controls.Add(this.MiFechaVencimiento);
            this.guna2GroupBox1.Controls.Add(this.MiFechaAbono);
            this.guna2GroupBox1.Controls.Add(this.IngresoRestanteT);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.abono);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox1.Location = new System.Drawing.Point(91, 51);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(967, 677);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // eliminarTurno
            // 
            this.eliminarTurno.BackColor = System.Drawing.Color.Maroon;
            this.eliminarTurno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eliminarTurno.FlatAppearance.BorderSize = 3;
            this.eliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarTurno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eliminarTurno.Location = new System.Drawing.Point(764, 299);
            this.eliminarTurno.Name = "eliminarTurno";
            this.eliminarTurno.Size = new System.Drawing.Size(130, 34);
            this.eliminarTurno.TabIndex = 32;
            this.eliminarTurno.Text = "Eliminar turno";
            this.eliminarTurno.UseVisualStyleBackColor = false;
            this.eliminarTurno.Click += new System.EventHandler(this.eliminarTurno_Click);
            // 
            // dgvMuestroTurnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestroTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMuestroTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMuestroTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMuestroTurnos.Location = new System.Drawing.Point(23, 157);
            this.dgvMuestroTurnos.Name = "dgvMuestroTurnos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuestroTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMuestroTurnos.RowHeadersWidth = 51;
            this.dgvMuestroTurnos.RowTemplate.Height = 24;
            this.dgvMuestroTurnos.Size = new System.Drawing.Size(646, 437);
            this.dgvMuestroTurnos.TabIndex = 20;
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonCerrarSesion.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BotonCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(753, 358);
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Size = new System.Drawing.Size(167, 52);
            this.BotonCerrarSesion.TabIndex = 19;
            this.BotonCerrarSesion.Text = "CerrarSesion";
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // MiFechaVencimiento
            // 
            this.MiFechaVencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.MiFechaVencimiento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MiFechaVencimiento.Location = new System.Drawing.Point(414, 91);
            this.MiFechaVencimiento.Name = "MiFechaVencimiento";
            this.MiFechaVencimiento.Size = new System.Drawing.Size(154, 27);
            this.MiFechaVencimiento.TabIndex = 18;
            this.MiFechaVencimiento.TextChanged += new System.EventHandler(this.MiFechaVencimiento_TextChanged_1);
            // 
            // MiFechaAbono
            // 
            this.MiFechaAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.MiFechaAbono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MiFechaAbono.Location = new System.Drawing.Point(108, 91);
            this.MiFechaAbono.Name = "MiFechaAbono";
            this.MiFechaAbono.Size = new System.Drawing.Size(154, 27);
            this.MiFechaAbono.TabIndex = 17;
            this.MiFechaAbono.TextChanged += new System.EventHandler(this.MiFechaAbono_TextChanged);
            // 
            // IngresoRestanteT
            // 
            this.IngresoRestanteT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.IngresoRestanteT.Location = new System.Drawing.Point(764, 91);
            this.IngresoRestanteT.Name = "IngresoRestanteT";
            this.IngresoRestanteT.Size = new System.Drawing.Size(100, 27);
            this.IngresoRestanteT.TabIndex = 12;
            this.IngresoRestanteT.TextChanged += new System.EventHandler(this.IngresoRestanteT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(749, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingreso Rest.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(435, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vence el:";
            // 
            // abono
            // 
            this.abono.AutoSize = true;
            this.abono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.abono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abono.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.abono.Location = new System.Drawing.Point(147, 51);
            this.abono.Name = "abono";
            this.abono.Size = new System.Drawing.Size(72, 23);
            this.abono.TabIndex = 6;
            this.abono.Text = "Abono:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(1338, 38);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "INICIO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.guna2GroupBox2);
            this.tabPage2.Controls.Add(this.guna2Button2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1344, 858);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TURNOS";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderRadius = 30;
            this.guna2GroupBox2.BorderThickness = 3;
            this.guna2GroupBox2.Controls.Add(this.BotonTemporizador);
            this.guna2GroupBox2.Controls.Add(this.lblCronometro);
            this.guna2GroupBox2.Controls.Add(this.guardarT);
            this.guna2GroupBox2.Controls.Add(this.listaHorarios);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.FechaTurno);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox2.Location = new System.Drawing.Point(91, 53);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(967, 837);
            this.guna2GroupBox2.TabIndex = 3;
            // 
            // BotonTemporizador
            // 
            this.BotonTemporizador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonTemporizador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonTemporizador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonTemporizador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonTemporizador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonTemporizador.ForeColor = System.Drawing.Color.White;
            this.BotonTemporizador.Location = new System.Drawing.Point(403, 376);
            this.BotonTemporizador.Name = "BotonTemporizador";
            this.BotonTemporizador.Size = new System.Drawing.Size(172, 48);
            this.BotonTemporizador.TabIndex = 10;
            this.BotonTemporizador.Text = "INICIAR TEMPORIZADOR";
            this.BotonTemporizador.Click += new System.EventHandler(this.BotonTemporizador_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Location = new System.Drawing.Point(397, 446);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(178, 20);
            this.lblCronometro.TabIndex = 9;
            this.lblCronometro.Text = "Tiempo restante: 01:00:00";
            // 
            // guardarT
            // 
            this.guardarT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guardarT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guardarT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guardarT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guardarT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guardarT.ForeColor = System.Drawing.Color.White;
            this.guardarT.Location = new System.Drawing.Point(383, 288);
            this.guardarT.Name = "guardarT";
            this.guardarT.Size = new System.Drawing.Size(208, 57);
            this.guardarT.TabIndex = 5;
            this.guardarT.Text = "Guardar Turno";
            this.guardarT.Click += new System.EventHandler(this.guardarT_Click);
            // 
            // listaHorarios
            // 
            this.listaHorarios.FormattingEnabled = true;
            this.listaHorarios.ItemHeight = 20;
            this.listaHorarios.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00"});
            this.listaHorarios.Location = new System.Drawing.Point(427, 184);
            this.listaHorarios.Name = "listaHorarios";
            this.listaHorarios.Size = new System.Drawing.Size(120, 84);
            this.listaHorarios.TabIndex = 4;
            this.listaHorarios.SelectedIndexChanged += new System.EventHandler(this.listaHorarios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(368, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "ASIGNAR TURNO";
            // 
            // FechaTurno
            // 
            this.FechaTurno.Location = new System.Drawing.Point(340, 128);
            this.FechaTurno.Name = "FechaTurno";
            this.FechaTurno.Size = new System.Drawing.Size(301, 27);
            this.FechaTurno.TabIndex = 2;
            this.FechaTurno.ValueChanged += new System.EventHandler(this.FechaTurno_ValueChanged);
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
            this.guna2Button2.Location = new System.Drawing.Point(3, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(1338, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "TURNOS";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.guna2GroupBox3);
            this.tabPage3.Controls.Add(this.guna2Button5);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1344, 858);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagos";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.BorderRadius = 30;
            this.guna2GroupBox3.BorderThickness = 3;
            this.guna2GroupBox3.Controls.Add(this.MisTurnosSemanalesCBX);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.label6);
            this.guna2GroupBox3.Controls.Add(this.txtCuotaMensual);
            this.guna2GroupBox3.Controls.Add(this.BotonPago);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2GroupBox3.Location = new System.Drawing.Point(139, 51);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(967, 837);
            this.guna2GroupBox3.TabIndex = 5;
            // 
            // MisTurnosSemanalesCBX
            // 
            this.MisTurnosSemanalesCBX.FormattingEnabled = true;
            this.MisTurnosSemanalesCBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.MisTurnosSemanalesCBX.Location = new System.Drawing.Point(388, 200);
            this.MisTurnosSemanalesCBX.Name = "MisTurnosSemanalesCBX";
            this.MisTurnosSemanalesCBX.Size = new System.Drawing.Size(199, 28);
            this.MisTurnosSemanalesCBX.TabIndex = 14;
            this.MisTurnosSemanalesCBX.SelectedIndexChanged += new System.EventHandler(this.MisTurnosSemanalesCBX_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(325, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Turnos semanales totales:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label6.Font = new System.Drawing.Font("Arial", 16F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(382, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cuota mensual:";
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.Enabled = false;
            this.txtCuotaMensual.Location = new System.Drawing.Point(388, 319);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.Size = new System.Drawing.Size(199, 27);
            this.txtCuotaMensual.TabIndex = 6;
            this.txtCuotaMensual.TextChanged += new System.EventHandler(this.txtCuotaMensual_TextChanged);
            // 
            // BotonPago
            // 
            this.BotonPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotonPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotonPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotonPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotonPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotonPago.ForeColor = System.Drawing.Color.White;
            this.BotonPago.Location = new System.Drawing.Point(379, 374);
            this.BotonPago.Name = "BotonPago";
            this.BotonPago.Size = new System.Drawing.Size(208, 57);
            this.BotonPago.TabIndex = 5;
            this.BotonPago.Text = "Pagar";
            this.BotonPago.Click += new System.EventHandler(this.BotonPago_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label5.Font = new System.Drawing.Font("Arial", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(417, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pagos";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(0, 0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(1344, 45);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "TURNOS";
            // 
            // TurnoClienteTimer
            // 
            this.TurnoClienteTimer.Enabled = true;
            this.TurnoClienteTimer.Interval = 1000;
            this.TurnoClienteTimer.Tick += new System.EventHandler(this.TurnoClienteTimer_Tick_1);
            // 
            // btnRefrsh
            // 
            this.btnRefrsh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefrsh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefrsh.FlatAppearance.BorderSize = 3;
            this.btnRefrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrsh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefrsh.Location = new System.Drawing.Point(764, 433);
            this.btnRefrsh.Name = "btnRefrsh";
            this.btnRefrsh.Size = new System.Drawing.Size(130, 34);
            this.btnRefrsh.TabIndex = 33;
            this.btnRefrsh.Text = "Actualizar";
            this.btnRefrsh.UseVisualStyleBackColor = false;
            this.btnRefrsh.Click += new System.EventHandler(this.btnRefrsh_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 866);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestroTurnos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label abono;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Timer TurnoClienteTimer;
        private System.Windows.Forms.DateTimePicker FechaTurno;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guardarT;
        private System.Windows.Forms.ListBox listaHorarios;
        private System.Windows.Forms.Label lblCronometro;
        private Guna.UI2.WinForms.Guna2Button BotonTemporizador;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuotaMensual;
        private Guna.UI2.WinForms.Guna2Button BotonPago;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MisTurnosSemanalesCBX;
        private System.Windows.Forms.TextBox IngresoRestanteT;
        private System.Windows.Forms.TextBox MiFechaVencimiento;
        private System.Windows.Forms.TextBox MiFechaAbono;
        private System.Windows.Forms.Button BotonCerrarSesion;
        private System.Windows.Forms.DataGridView dgvMuestroTurnos;
        private System.Windows.Forms.Button eliminarTurno;
        private System.Windows.Forms.Button btnRefrsh;
    }
}