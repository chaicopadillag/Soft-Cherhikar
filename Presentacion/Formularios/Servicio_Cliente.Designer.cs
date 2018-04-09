namespace Presentacion
{
    partial class Servicio_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicio_Cliente));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_lista_detalle_serv = new System.Windows.Forms.DataGridView();
            this.dgv_lista_Servicios = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntbuscar = new System.Windows.Forms.Panel();
            this.txtbuscarservicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnagregar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.grupdatos = new System.Windows.Forms.GroupBox();
            this.cboplaca = new System.Windows.Forms.ComboBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.dgv_Detalle_servico = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscar_cliente = new System.Windows.Forms.Panel();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.cboservicios = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cbopersonal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.txtnum_serv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btn_imprimir_bol = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_detalle_serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_Servicios)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_servico)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(16, 59);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(734, 490);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(734, 490);
            this.tabPane1.TabIndex = 2;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.AllowTouchScroll = true;
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.AutoScroll = true;
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage1.Caption = "Lista de Servicios de Mantenimiento de los Vehículos";
            this.tabNavigationPage1.Controls.Add(this.buttonX1);
            this.tabNavigationPage1.Controls.Add(this.label11);
            this.tabNavigationPage1.Controls.Add(this.dgv_lista_detalle_serv);
            this.tabNavigationPage1.Controls.Add(this.dgv_lista_Servicios);
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(716, 445);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX1.Location = new System.Drawing.Point(516, 28);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(168, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.buttonX1, new DevComponents.DotNetBar.SuperTooltipInfo("Seleccione un Servicio  para dar de baja", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(221, 21)));
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Dar de baja al Servicio";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(240, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Detalle del Mantemiento del Vehículo";
            // 
            // dgv_lista_detalle_serv
            // 
            this.dgv_lista_detalle_serv.AllowUserToAddRows = false;
            this.dgv_lista_detalle_serv.AllowUserToDeleteRows = false;
            this.dgv_lista_detalle_serv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lista_detalle_serv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lista_detalle_serv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_detalle_serv.Location = new System.Drawing.Point(105, 478);
            this.dgv_lista_detalle_serv.Name = "dgv_lista_detalle_serv";
            this.dgv_lista_detalle_serv.ReadOnly = true;
            this.dgv_lista_detalle_serv.Size = new System.Drawing.Size(487, 334);
            this.dgv_lista_detalle_serv.TabIndex = 10;
            // 
            // dgv_lista_Servicios
            // 
            this.dgv_lista_Servicios.AllowUserToAddRows = false;
            this.dgv_lista_Servicios.AllowUserToDeleteRows = false;
            this.dgv_lista_Servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lista_Servicios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lista_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_Servicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_lista_Servicios.Location = new System.Drawing.Point(15, 93);
            this.dgv_lista_Servicios.Name = "dgv_lista_Servicios";
            this.dgv_lista_Servicios.ReadOnly = true;
            this.dgv_lista_Servicios.Size = new System.Drawing.Size(669, 347);
            this.superTooltip1.SetSuperTooltip(this.dgv_lista_Servicios, new DevComponents.DotNetBar.SuperTooltipInfo("Doble click para ver detalle del servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(0, 0)));
            this.dgv_lista_Servicios.TabIndex = 9;
            this.dgv_lista_Servicios.DoubleClick += new System.EventHandler(this.dgv_lista_Servicios_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.bntbuscar);
            this.groupBox4.Controls.Add(this.txtbuscarservicio);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 62);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por Codigo";
            // 
            // bntbuscar
            // 
            this.bntbuscar.BackColor = System.Drawing.Color.Transparent;
            this.bntbuscar.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.bntbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntbuscar.Location = new System.Drawing.Point(129, 11);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(40, 45);
            this.superTooltip1.SetSuperTooltip(this.bntbuscar, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar registro de servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(151, 21)));
            this.bntbuscar.TabIndex = 12;
            this.bntbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bntbuscar_MouseClick);
            this.bntbuscar.MouseLeave += new System.EventHandler(this.bntbuscar_MouseLeave);
            this.bntbuscar.MouseHover += new System.EventHandler(this.bntbuscar_MouseHover);
            // 
            // txtbuscarservicio
            // 
            this.txtbuscarservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarservicio.Location = new System.Drawing.Point(11, 24);
            this.txtbuscarservicio.MaxLength = 5;
            this.txtbuscarservicio.Name = "txtbuscarservicio";
            this.txtbuscarservicio.Size = new System.Drawing.Size(100, 22);
            this.txtbuscarservicio.TabIndex = 10;
            this.txtbuscarservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarservicio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(165, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista de Registros de Mantenimiento al Vehículo";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.AllowTouchScroll = true;
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.AutoScroll = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.Caption = "Registrar el  Servicio de Mantenimiento al Vehículo";
            this.tabNavigationPage2.Controls.Add(this.btn_imprimir_bol);
            this.tabNavigationPage2.Controls.Add(this.groupBox1);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.grupdatos);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Image = global::Presentacion.Properties.Resources.nuevo_usu;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Size = new System.Drawing.Size(716, 445);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(616, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btneliminar
            // 
            this.btneliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btneliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(24, 86);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btneliminar.Size = new System.Drawing.Size(46, 48);
            this.btneliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btneliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Quitar servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(88, 21)));
            this.btneliminar.Symbol = "59657";
            this.btneliminar.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btneliminar.SymbolSize = 40F;
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnagregar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(24, 32);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.btnagregar.Size = new System.Drawing.Size(46, 48);
            this.btnagregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btnagregar, new DevComponents.DotNetBar.SuperTooltipInfo("Agregar servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(100, 21)));
            this.btnagregar.Symbol = "57670";
            this.btnagregar.SymbolColor = System.Drawing.Color.Green;
            this.btnagregar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnagregar.SymbolSize = 40F;
            this.btnagregar.TabIndex = 32;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(616, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 201);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.BackgroundImage = global::Presentacion.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(24, 86);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(56, 22)));
            this.btnguardar.TabIndex = 1;
            this.btnguardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseClick);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseHover += new System.EventHandler(this.btnguardar_MouseHover);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::Presentacion.Properties.Resources.Cancel1;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(24, 141);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Orange, true, false, new System.Drawing.Size(60, 23)));
            this.btncancelar.TabIndex = 2;
            this.btncancelar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btncancelar_MouseClick);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btncancelar.MouseHover += new System.EventHandler(this.btncancelar_MouseHover);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnnuevo.BackgroundImage = global::Presentacion.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(24, 26);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(47, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // grupdatos
            // 
            this.grupdatos.Controls.Add(this.cboplaca);
            this.grupdatos.Controls.Add(this.txtprecio);
            this.grupdatos.Controls.Add(this.chestado);
            this.grupdatos.Controls.Add(this.dgv_Detalle_servico);
            this.grupdatos.Controls.Add(this.txtimporte);
            this.grupdatos.Controls.Add(this.label7);
            this.grupdatos.Controls.Add(this.groupBox3);
            this.grupdatos.Controls.Add(this.cboservicios);
            this.grupdatos.Controls.Add(this.fecha);
            this.grupdatos.Controls.Add(this.cbopersonal);
            this.grupdatos.Controls.Add(this.label9);
            this.grupdatos.Controls.Add(this.cbocliente);
            this.grupdatos.Controls.Add(this.txtnum_serv);
            this.grupdatos.Controls.Add(this.label1);
            this.grupdatos.Controls.Add(this.label5);
            this.grupdatos.Controls.Add(this.label2);
            this.grupdatos.Controls.Add(this.label4);
            this.grupdatos.Controls.Add(this.label8);
            this.grupdatos.Controls.Add(this.label12);
            this.grupdatos.Enabled = false;
            this.grupdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupdatos.Location = new System.Drawing.Point(3, 0);
            this.grupdatos.Name = "grupdatos";
            this.grupdatos.Size = new System.Drawing.Size(607, 440);
            this.grupdatos.TabIndex = 5;
            this.grupdatos.TabStop = false;
            this.grupdatos.Text = "Datos a Registrar";
            // 
            // cboplaca
            // 
            this.cboplaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboplaca.FormattingEnabled = true;
            this.cboplaca.Location = new System.Drawing.Point(459, 110);
            this.cboplaca.Name = "cboplaca";
            this.cboplaca.Size = new System.Drawing.Size(132, 24);
            this.cboplaca.TabIndex = 30;
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(459, 151);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(89, 24);
            this.txtprecio.TabIndex = 29;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(290, 41);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 24;
            this.chestado.Text = "estado";
            this.chestado.UseVisualStyleBackColor = true;
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating);
            // 
            // dgv_Detalle_servico
            // 
            this.dgv_Detalle_servico.AllowUserToOrderColumns = true;
            this.dgv_Detalle_servico.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Detalle_servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle_servico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Detalle_servico.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Detalle_servico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Detalle_servico.Location = new System.Drawing.Point(14, 185);
            this.dgv_Detalle_servico.Name = "dgv_Detalle_servico";
            this.dgv_Detalle_servico.Size = new System.Drawing.Size(577, 221);
            this.dgv_Detalle_servico.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Servicio de Mantenimiento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.Width = 78;
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.ForeColor = System.Drawing.Color.Black;
            this.txtimporte.Location = new System.Drawing.Point(436, 412);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(155, 24);
            this.txtimporte.TabIndex = 18;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Importe Total ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbuscar_cliente);
            this.groupBox3.Controls.Add(this.txtbuscarcliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(408, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Cliente";
            // 
            // btnbuscar_cliente
            // 
            this.btnbuscar_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar_cliente.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar_cliente.Location = new System.Drawing.Point(137, 10);
            this.btnbuscar_cliente.Name = "btnbuscar_cliente";
            this.btnbuscar_cliente.Size = new System.Drawing.Size(40, 45);
            this.btnbuscar_cliente.TabIndex = 11;
            this.btnbuscar_cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_cliente_MouseClick);
            this.btnbuscar_cliente.MouseLeave += new System.EventHandler(this.btnbuscar_cliente_MouseLeave);
            this.btnbuscar_cliente.MouseHover += new System.EventHandler(this.btnbuscar_cliente_MouseHover);
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcliente.Location = new System.Drawing.Point(11, 24);
            this.txtbuscarcliente.MaxLength = 8;
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(117, 22);
            this.txtbuscarcliente.TabIndex = 10;
            this.txtbuscarcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscarcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarcliente_KeyPress);
            // 
            // cboservicios
            // 
            this.cboservicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboservicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboservicios.FormattingEnabled = true;
            this.cboservicios.Location = new System.Drawing.Point(184, 145);
            this.cboservicios.Name = "cboservicios";
            this.cboservicios.Size = new System.Drawing.Size(171, 24);
            this.cboservicios.TabIndex = 16;
            this.cboservicios.SelectionChangeCommitted += new System.EventHandler(this.cboservicios_SelectionChangeCommitted);
            this.cboservicios.Validating += new System.ComponentModel.CancelEventHandler(this.cboservicios_Validating);
            // 
            // fecha
            // 
            this.fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(184, 112);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(112, 22);
            this.fecha.TabIndex = 15;
            // 
            // cbopersonal
            // 
            this.cbopersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbopersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopersonal.FormattingEnabled = true;
            this.cbopersonal.Location = new System.Drawing.Point(184, 73);
            this.cbopersonal.Name = "cbopersonal";
            this.cbopersonal.Size = new System.Drawing.Size(171, 24);
            this.cbopersonal.TabIndex = 14;
            this.cbopersonal.Validating += new System.ComponentModel.CancelEventHandler(this.cbopersonal_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Personal  Mecánico";
            // 
            // cbocliente
            // 
            this.cbocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbocliente.Enabled = false;
            this.cbocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocliente.ForeColor = System.Drawing.Color.Black;
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(420, 73);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(171, 24);
            this.cbocliente.TabIndex = 9;
            this.cbocliente.SelectionChangeCommitted += new System.EventHandler(this.cbocliente_SelectionChangeCommitted);
            this.cbocliente.Validating += new System.ComponentModel.CancelEventHandler(this.cbocliente_Validating);
            // 
            // txtnum_serv
            // 
            this.txtnum_serv.Enabled = false;
            this.txtnum_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_serv.ForeColor = System.Drawing.Color.Black;
            this.txtnum_serv.Location = new System.Drawing.Point(184, 39);
            this.txtnum_serv.Name = "txtnum_serv";
            this.txtnum_serv.Size = new System.Drawing.Size(100, 22);
            this.txtnum_serv.TabIndex = 5;
            this.txtnum_serv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servicios de Mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = " Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(354, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Placa/Vehículo";
            // 
            // validar_error
            // 
            this.validar_error.ContainerControl = this;
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
            this.btn_cerrar.Location = new System.Drawing.Point(733, 11);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_cerrar.Size = new System.Drawing.Size(22, 25);
            this.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_cerrar, new DevComponents.DotNetBar.SuperTooltipInfo("Cerrar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(48, 21)));
            this.btn_cerrar.Symbol = "";
            this.btn_cerrar.SymbolColor = System.Drawing.Color.Red;
            this.btn_cerrar.TabIndex = 17;
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
            this.btn_minimizar.Location = new System.Drawing.Point(707, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_minimizar.Size = new System.Drawing.Size(23, 25);
            this.btn_minimizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_minimizar, new DevComponents.DotNetBar.SuperTooltipInfo("Minimizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(64, 21)));
            this.btn_minimizar.Symbol = "57693";
            this.btn_minimizar.SymbolColor = System.Drawing.Color.Yellow;
            this.btn_minimizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_minimizar.TabIndex = 18;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(169, -2);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(429, 70);
            this.reflectionLabel1.TabIndex = 19;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Servicios   de </i><font color=\"#B02B2C\"> Mantenimiento </f" +
    "ont></font></b><b><font size=\"+6\"><i>al  </i><font color=\"#B02B2C\">    Vehículo<" +
    "/font></font></b>";
            // 
            // btn_imprimir_bol
            // 
            this.btn_imprimir_bol.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_imprimir_bol.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_imprimir_bol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_bol.Location = new System.Drawing.Point(615, 396);
            this.btn_imprimir_bol.Name = "btn_imprimir_bol";
            this.btn_imprimir_bol.Size = new System.Drawing.Size(90, 40);
            this.btn_imprimir_bol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_imprimir_bol, new DevComponents.DotNetBar.SuperTooltipInfo("Imprimir Servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(102, 21)));
            this.btn_imprimir_bol.Symbol = "58709";
            this.btn_imprimir_bol.SymbolColor = System.Drawing.Color.Black;
            this.btn_imprimir_bol.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_imprimir_bol.SymbolSize = 20F;
            this.btn_imprimir_bol.TabIndex = 88;
            this.btn_imprimir_bol.Text = "Imprimir";
            this.btn_imprimir_bol.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_imprimir_bol.TextColor = System.Drawing.Color.Blue;
            this.btn_imprimir_bol.Click += new System.EventHandler(this.btn_imprimir_bol_Click);
            // 
            // Servicio_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 567);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicio_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de Cliente";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Servicio_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_detalle_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_Servicios)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grupdatos.ResumeLayout(false);
            this.grupdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_servico)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraBars.Navigation.TabPane tabPane1;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_lista_detalle_serv;
        private System.Windows.Forms.DataGridView dgv_lista_Servicios;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel bntbuscar;
        public System.Windows.Forms.TextBox txtbuscarservicio;
        public System.Windows.Forms.Label label6;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.Panel btnnuevo;
        public System.Windows.Forms.GroupBox grupdatos;
        public System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.CheckBox chestado;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Detalle_servico;
        public System.Windows.Forms.TextBox txtimporte;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel btnbuscar_cliente;
        public System.Windows.Forms.TextBox txtbuscarcliente;
        public System.Windows.Forms.ComboBox cboservicios;
        private System.Windows.Forms.DateTimePicker fecha;
        public System.Windows.Forms.ComboBox cbopersonal;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbocliente;
        public System.Windows.Forms.TextBox txtnum_serv;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider validar_error;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        public System.Windows.Forms.ComboBox cboplaca;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btneliminar;
        private DevComponents.DotNetBar.ButtonX btnagregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.ButtonX btn_imprimir_bol;
    }
}