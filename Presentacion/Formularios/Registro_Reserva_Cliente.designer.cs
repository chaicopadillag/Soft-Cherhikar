namespace Presentacion
{
    partial class Registro_Reserva_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Reserva_Cliente));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgv_listaReserva = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntbuscarPorCodigo = new System.Windows.Forms.Panel();
            this.txtbucarReservaMant = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_imprimir_fac = new DevComponents.DotNetBar.ButtonX();
            this.btn_imprimir_bol = new DevComponents.DotNetBar.ButtonX();
            this.grup_datos = new System.Windows.Forms.GroupBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cbo_placa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.DateTimePicker();
            this.cboServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscarReserva = new System.Windows.Forms.Panel();
            this.txtbuscadorCliente = new System.Windows.Forms.TextBox();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.ValidarError = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaReserva)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.grup_datos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarError)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(18, 64);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(697, 409);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(697, 409);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.dgv_listaReserva);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageText = "Lista ReservaMant Cliente";
            this.tabNavigationPage1.Size = new System.Drawing.Size(679, 364);
            // 
            // dgv_listaReserva
            // 
            this.dgv_listaReserva.AllowUserToAddRows = false;
            this.dgv_listaReserva.AllowUserToDeleteRows = false;
            this.dgv_listaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listaReserva.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_listaReserva.Location = new System.Drawing.Point(15, 83);
            this.dgv_listaReserva.Name = "dgv_listaReserva";
            this.dgv_listaReserva.ReadOnly = true;
            this.dgv_listaReserva.Size = new System.Drawing.Size(650, 267);
            this.dgv_listaReserva.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Listar Reserva Mantnimiento Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntbuscarPorCodigo);
            this.groupBox4.Controls.Add(this.txtbucarReservaMant);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 62);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por codigo";
            // 
            // bntbuscarPorCodigo
            // 
            this.bntbuscarPorCodigo.BackColor = System.Drawing.Color.Transparent;
            this.bntbuscarPorCodigo.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.bntbuscarPorCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntbuscarPorCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntbuscarPorCodigo.Location = new System.Drawing.Point(129, 11);
            this.bntbuscarPorCodigo.Name = "bntbuscarPorCodigo";
            this.bntbuscarPorCodigo.Size = new System.Drawing.Size(40, 45);
            this.bntbuscarPorCodigo.TabIndex = 12;
            this.bntbuscarPorCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bntbuscarPorCodigo_MouseClick);
            this.bntbuscarPorCodigo.MouseLeave += new System.EventHandler(this.bntbuscarPorCodigo_MouseLeave);
            this.bntbuscarPorCodigo.MouseHover += new System.EventHandler(this.bntbuscarPorCodigo_MouseHover);
            // 
            // txtbucarReservaMant
            // 
            this.txtbucarReservaMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbucarReservaMant.Location = new System.Drawing.Point(11, 24);
            this.txtbucarReservaMant.MaxLength = 5;
            this.txtbucarReservaMant.Name = "txtbucarReservaMant";
            this.txtbucarReservaMant.Size = new System.Drawing.Size(100, 22);
            this.txtbucarReservaMant.TabIndex = 10;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.btn_imprimir_fac);
            this.tabNavigationPage2.Controls.Add(this.btn_imprimir_bol);
            this.tabNavigationPage2.Controls.Add(this.grup_datos);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageText = "Reserva del Cliente";
            this.tabNavigationPage2.Size = new System.Drawing.Size(679, 364);
            this.tabNavigationPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage2_Paint);
            // 
            // btn_imprimir_fac
            // 
            this.btn_imprimir_fac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_imprimir_fac.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_imprimir_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_fac.Location = new System.Drawing.Point(204, 307);
            this.btn_imprimir_fac.Name = "btn_imprimir_fac";
            this.btn_imprimir_fac.Size = new System.Drawing.Size(94, 34);
            this.btn_imprimir_fac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_imprimir_fac, new DevComponents.DotNetBar.SuperTooltipInfo("Registrar Vehículo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(110, 21)));
            this.btn_imprimir_fac.Symbol = "";
            this.btn_imprimir_fac.SymbolColor = System.Drawing.Color.Red;
            this.btn_imprimir_fac.SymbolSize = 20F;
            this.btn_imprimir_fac.TabIndex = 89;
            this.btn_imprimir_fac.Text = "Vehículo";
            this.btn_imprimir_fac.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_imprimir_fac.TextColor = System.Drawing.Color.Blue;
            this.btn_imprimir_fac.Click += new System.EventHandler(this.btn_imprimir_fac_Click);
            // 
            // btn_imprimir_bol
            // 
            this.btn_imprimir_bol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_imprimir_bol.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_imprimir_bol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_bol.Location = new System.Drawing.Point(100, 307);
            this.btn_imprimir_bol.Name = "btn_imprimir_bol";
            this.btn_imprimir_bol.Size = new System.Drawing.Size(94, 34);
            this.btn_imprimir_bol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_imprimir_bol, new DevComponents.DotNetBar.SuperTooltipInfo("Registrar Cliente", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(102, 21)));
            this.btn_imprimir_bol.Symbol = "";
            this.btn_imprimir_bol.SymbolColor = System.Drawing.Color.Red;
            this.btn_imprimir_bol.SymbolSize = 20F;
            this.btn_imprimir_bol.TabIndex = 88;
            this.btn_imprimir_bol.Text = "Cliente";
            this.btn_imprimir_bol.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_imprimir_bol.TextColor = System.Drawing.Color.Blue;
            this.btn_imprimir_bol.Click += new System.EventHandler(this.btn_imprimir_bol_Click);
            // 
            // grup_datos
            // 
            this.grup_datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_datos.Controls.Add(this.cboCliente);
            this.grup_datos.Controls.Add(this.cbo_placa);
            this.grup_datos.Controls.Add(this.label4);
            this.grup_datos.Controls.Add(this.hora);
            this.grup_datos.Controls.Add(this.cboServicio);
            this.grup_datos.Controls.Add(this.label3);
            this.grup_datos.Controls.Add(this.label12);
            this.grup_datos.Controls.Add(this.chestado);
            this.grup_datos.Controls.Add(this.groupBox3);
            this.grup_datos.Controls.Add(this.cboNombre);
            this.grup_datos.Controls.Add(this.fecha);
            this.grup_datos.Controls.Add(this.txtReserva);
            this.grup_datos.Controls.Add(this.label1);
            this.grup_datos.Controls.Add(this.label5);
            this.grup_datos.Controls.Add(this.label2);
            this.grup_datos.Controls.Add(this.label8);
            this.grup_datos.Enabled = false;
            this.grup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_datos.Location = new System.Drawing.Point(25, 13);
            this.grup_datos.Name = "grup_datos";
            this.grup_datos.Size = new System.Drawing.Size(633, 252);
            this.grup_datos.TabIndex = 52;
            this.grup_datos.TabStop = false;
            this.grup_datos.Text = "Datos a Registrar";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCliente.Enabled = false;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(146, 72);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(171, 24);
            this.cboCliente.TabIndex = 82;
            // 
            // cbo_placa
            // 
            this.cbo_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_placa.FormattingEnabled = true;
            this.cbo_placa.Location = new System.Drawing.Point(146, 175);
            this.cbo_placa.Name = "cbo_placa";
            this.cbo_placa.Size = new System.Drawing.Size(171, 24);
            this.cbo_placa.TabIndex = 81;
            this.cbo_placa.Validating += new System.ComponentModel.CancelEventHandler(this.cbo_placa_Validating_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Hora";
            // 
            // hora
            // 
            this.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora.Location = new System.Drawing.Point(428, 183);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(81, 22);
            this.hora.TabIndex = 79;
            this.hora.Value = new System.DateTime(2016, 6, 26, 5, 5, 0, 0);
            // 
            // cboServicio
            // 
            this.cboServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServicio.FormattingEnabled = true;
            this.cboServicio.Location = new System.Drawing.Point(146, 141);
            this.cboServicio.Name = "cboServicio";
            this.cboServicio.Size = new System.Drawing.Size(171, 24);
            this.cboServicio.TabIndex = 78;
            this.cboServicio.Validating += new System.ComponentModel.CancelEventHandler(this.cboServicio_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Servicio de Mant.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 75;
            this.label12.Text = "Placa/Vehículo";
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(146, 214);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 74;
            this.chestado.Text = "estado";
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbuscarReserva);
            this.groupBox3.Controls.Add(this.txtbuscadorCliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(405, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 60);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar cliente";
            // 
            // btnbuscarReserva
            // 
            this.btnbuscarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarReserva.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarReserva.Location = new System.Drawing.Point(150, 10);
            this.btnbuscarReserva.Name = "btnbuscarReserva";
            this.btnbuscarReserva.Size = new System.Drawing.Size(34, 45);
            this.btnbuscarReserva.TabIndex = 12;
            this.btnbuscarReserva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscarporCodigo_MouseClick);
            // 
            // txtbuscadorCliente
            // 
            this.txtbuscadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscadorCliente.Location = new System.Drawing.Point(16, 23);
            this.txtbuscadorCliente.MaxLength = 8;
            this.txtbuscadorCliente.Multiline = true;
            this.txtbuscadorCliente.Name = "txtbuscadorCliente";
            this.txtbuscadorCliente.Size = new System.Drawing.Size(114, 24);
            this.txtbuscadorCliente.TabIndex = 10;
            this.txtbuscadorCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscadorCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscadorCliente_KeyPress);
            // 
            // cboNombre
            // 
            this.cboNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(146, 104);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(171, 24);
            this.cboNombre.TabIndex = 72;
            this.cboNombre.Validating += new System.ComponentModel.CancelEventHandler(this.cboNombre_Validating_1);
            // 
            // fecha
            // 
            this.fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(428, 134);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(171, 22);
            this.fecha.TabIndex = 71;
            // 
            // txtReserva
            // 
            this.txtReserva.Enabled = false;
            this.txtReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserva.ForeColor = System.Drawing.Color.Black;
            this.txtReserva.Location = new System.Drawing.Point(146, 44);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(100, 22);
            this.txtReserva.TabIndex = 67;
            this.txtReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Codigo de Reserva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nombre secretaria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = " Nombre Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 77);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::Presentacion.Properties.Resources.Cancel1;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(152, 21);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(60, 21)));
            this.btncancelar.TabIndex = 2;
            this.btncancelar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btncancelar_MouseClick);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btncancelar.MouseHover += new System.EventHandler(this.btncancelar_MouseHover);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::Presentacion.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.CausesValidation = false;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(89, 21);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(56, 21)));
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnguardar_Paint);
            this.btnguardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseClick);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseHover += new System.EventHandler(this.btnguardar_MouseHover);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnnuevo.BackgroundImage = global::Presentacion.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(27, 21);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(47, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // ValidarError
            // 
            this.ValidarError.ContainerControl = this;
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(691, 20);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_cerrar.Size = new System.Drawing.Size(22, 25);
            this.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_cerrar, new DevComponents.DotNetBar.SuperTooltipInfo("Cerrar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(48, 21)));
            this.btn_cerrar.Symbol = "";
            this.btn_cerrar.SymbolColor = System.Drawing.Color.Red;
            this.btn_cerrar.TabIndex = 32;
            this.btn_cerrar.TextColor = System.Drawing.Color.MidnightBlue;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.Location = new System.Drawing.Point(662, 20);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_minimizar.Size = new System.Drawing.Size(23, 25);
            this.btn_minimizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_minimizar, new DevComponents.DotNetBar.SuperTooltipInfo("Minimizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(64, 21)));
            this.btn_minimizar.Symbol = "57693";
            this.btn_minimizar.SymbolColor = System.Drawing.Color.Yellow;
            this.btn_minimizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_minimizar.TabIndex = 33;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(269, 4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(224, 70);
            this.reflectionLabel1.TabIndex = 34;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    </i><font color=\"#B02B2C\"> de </font></font></b" +
    "><b><font size=\"+6\"><i>Reservas   </i><font color=\"#B02B2C\"></font></font></b>";
            // 
            // Registro_Reserva_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 491);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Reserva_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Reserva_Cliente";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Registro_Reserva_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaReserva)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.grup_datos.ResumeLayout(false);
            this.grup_datos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidarError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox grup_datos;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtbuscadorCliente;
        public System.Windows.Forms.ComboBox cboNombre;
        public System.Windows.Forms.TextBox txtReserva;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboServicio;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txtbucarReservaMant;
        private System.Windows.Forms.ErrorProvider ValidarError;
        public System.Windows.Forms.ComboBox cbo_placa;
        public System.Windows.Forms.ComboBox cboCliente;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        public DevExpress.XtraBars.Navigation.TabPane tabPane1;
        public System.Windows.Forms.Panel btncancelar;
        public System.Windows.Forms.Panel btnguardar;
        public System.Windows.Forms.Panel btnnuevo;
        public System.Windows.Forms.CheckBox chestado;
        public System.Windows.Forms.DateTimePicker fecha;
        public System.Windows.Forms.DateTimePicker hora;
        public System.Windows.Forms.Panel bntbuscarPorCodigo;
        public System.Windows.Forms.DataGridView dgv_listaReserva;
        public System.Windows.Forms.Panel btnbuscarReserva;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btn_imprimir_fac;
        private DevComponents.DotNetBar.ButtonX btn_imprimir_bol;
    }
}