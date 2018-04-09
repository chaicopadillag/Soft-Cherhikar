namespace Presentacion
{
    partial class Registro_vehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_vehiculo));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbuscarplaca = new System.Windows.Forms.Panel();
            this.txtbuscaVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grup_buscar = new System.Windows.Forms.GroupBox();
            this.btnbusc = new System.Windows.Forms.Panel();
            this.txtbusc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btnmodificar = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.grup_datos = new System.Windows.Forms.GroupBox();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscarCliente = new System.Windows.Forms.Panel();
            this.txtbuscarClient = new System.Windows.Forms.TextBox();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.cbomodelo = new System.Windows.Forms.ComboBox();
            this.cbomarcav = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbotipov = new System.Windows.Forms.ComboBox();
            this.txtdescricion = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.Validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.grup_buscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grup_datos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validar_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(12, 65);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(597, 457);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(597, 457);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.Caption = "Lista de Vehículos";
            this.tabNavigationPage1.Controls.Add(this.dgv_vehiculos);
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(579, 412);
            // 
            // dgv_vehiculos
            // 
            this.dgv_vehiculos.AllowUserToAddRows = false;
            this.dgv_vehiculos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehiculos.Location = new System.Drawing.Point(15, 93);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vehiculos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vehiculos.Size = new System.Drawing.Size(551, 306);
            this.dgv_vehiculos.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnbuscarplaca);
            this.groupBox4.Controls.Add(this.txtbuscaVehiculo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(354, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 69);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por Placa";
            // 
            // btnbuscarplaca
            // 
            this.btnbuscarplaca.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarplaca.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscarplaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarplaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarplaca.Location = new System.Drawing.Point(125, 16);
            this.btnbuscarplaca.Name = "btnbuscarplaca";
            this.btnbuscarplaca.Size = new System.Drawing.Size(37, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbuscarplaca, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Vehículo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btnbuscarplaca.TabIndex = 11;
            this.btnbuscarplaca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_MouseClick);
            this.btnbuscarplaca.MouseLeave += new System.EventHandler(this.btnbuscar_MouseLeave);
            this.btnbuscarplaca.MouseHover += new System.EventHandler(this.btnbuscar_MouseHover);
            // 
            // txtbuscaVehiculo
            // 
            this.txtbuscaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscaVehiculo.Location = new System.Drawing.Point(11, 24);
            this.txtbuscaVehiculo.MaxLength = 6;
            this.txtbuscaVehiculo.Multiline = true;
            this.txtbuscaVehiculo.Name = "txtbuscaVehiculo";
            this.txtbuscaVehiculo.Size = new System.Drawing.Size(100, 28);
            this.txtbuscaVehiculo.TabIndex = 10;
            this.txtbuscaVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscaVehiculo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista de Registros de Vehículos";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.AllowTouchScroll = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "Registrar Vehículo";
            this.tabNavigationPage2.Controls.Add(this.grup_buscar);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.grup_datos);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Image = global::Presentacion.Properties.Resources.masusu;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Size = new System.Drawing.Size(579, 412);
            // 
            // grup_buscar
            // 
            this.grup_buscar.Controls.Add(this.btnbusc);
            this.grup_buscar.Controls.Add(this.txtbusc);
            this.grup_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_buscar.Location = new System.Drawing.Point(394, 321);
            this.grup_buscar.Name = "grup_buscar";
            this.grup_buscar.Size = new System.Drawing.Size(168, 75);
            this.grup_buscar.TabIndex = 10;
            this.grup_buscar.TabStop = false;
            this.grup_buscar.Text = "Buscar vehículo";
            // 
            // btnbusc
            // 
            this.btnbusc.BackColor = System.Drawing.Color.Transparent;
            this.btnbusc.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbusc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusc.Location = new System.Drawing.Point(125, 16);
            this.btnbusc.Name = "btnbusc";
            this.btnbusc.Size = new System.Drawing.Size(37, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbusc, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar para modificar / eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(176, 21)));
            this.btnbusc.TabIndex = 11;
            this.btnbusc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbusc_MouseClick);
            this.btnbusc.MouseLeave += new System.EventHandler(this.btnbusc_MouseLeave);
            this.btnbusc.MouseHover += new System.EventHandler(this.btnbusc_MouseHover);
            // 
            // txtbusc
            // 
            this.txtbusc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusc.Location = new System.Drawing.Point(11, 24);
            this.txtbusc.MaxLength = 6;
            this.txtbusc.Multiline = true;
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(100, 28);
            this.txtbusc.TabIndex = 10;
            this.txtbusc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbusc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusc_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 88);
            this.groupBox2.TabIndex = 6;
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
            this.btncancelar.Location = new System.Drawing.Point(276, 21);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Orange, true, false, new System.Drawing.Size(60, 21)));
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
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(89, 21);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(58, 21)));
            this.btnguardar.TabIndex = 1;
            this.btnguardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseClick);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseHover += new System.EventHandler(this.btnguardar_MouseHover);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BackgroundImage = global::Presentacion.Properties.Resources.modificar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Location = new System.Drawing.Point(153, 21);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnmodificar, new DevComponents.DotNetBar.SuperTooltipInfo("Modificar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, true, false, new System.Drawing.Size(64, 21)));
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnmodificar_MouseClick);
            this.btnmodificar.MouseLeave += new System.EventHandler(this.tnmodificar_MouseLeave);
            this.btnmodificar.MouseHover += new System.EventHandler(this.tnmodificar_MouseHover);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = global::Presentacion.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(215, 21);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btneliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(58, 21)));
            this.btneliminar.TabIndex = 1;
            this.btneliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btneliminar_MouseClick);
            this.btneliminar.MouseLeave += new System.EventHandler(this.btneliminar_MouseLeave);
            this.btneliminar.MouseHover += new System.EventHandler(this.btneliminar_MouseHover);
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
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(50, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // grup_datos
            // 
            this.grup_datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_datos.Controls.Add(this.chestado);
            this.grup_datos.Controls.Add(this.groupBox3);
            this.grup_datos.Controls.Add(this.cbocliente);
            this.grup_datos.Controls.Add(this.cbomodelo);
            this.grup_datos.Controls.Add(this.cbomarcav);
            this.grup_datos.Controls.Add(this.label8);
            this.grup_datos.Controls.Add(this.txtcolor);
            this.grup_datos.Controls.Add(this.label7);
            this.grup_datos.Controls.Add(this.cbotipov);
            this.grup_datos.Controls.Add(this.txtdescricion);
            this.grup_datos.Controls.Add(this.txtplaca);
            this.grup_datos.Controls.Add(this.label1);
            this.grup_datos.Controls.Add(this.label5);
            this.grup_datos.Controls.Add(this.label2);
            this.grup_datos.Controls.Add(this.label4);
            this.grup_datos.Controls.Add(this.label3);
            this.grup_datos.Enabled = false;
            this.grup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_datos.Location = new System.Drawing.Point(6, 3);
            this.grup_datos.Name = "grup_datos";
            this.grup_datos.Size = new System.Drawing.Size(559, 299);
            this.grup_datos.TabIndex = 5;
            this.grup_datos.TabStop = false;
            this.grup_datos.Text = "Datos a Registrar";
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(363, 195);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 17;
            this.chestado.Text = "estado";
            this.chestado.UseVisualStyleBackColor = true;
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbuscarCliente);
            this.groupBox3.Controls.Add(this.txtbuscarClient);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(352, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 69);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar  cliente";
            // 
            // btnbuscarCliente
            // 
            this.btnbuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarCliente.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarCliente.Location = new System.Drawing.Point(125, 16);
            this.btnbuscarCliente.Name = "btnbuscarCliente";
            this.btnbuscarCliente.Size = new System.Drawing.Size(37, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbuscarCliente, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Cliente", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btnbuscarCliente.TabIndex = 11;
            this.btnbuscarCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscarCliente_MouseClick);
            this.btnbuscarCliente.MouseLeave += new System.EventHandler(this.btnbuscar2_MouseLeave);
            this.btnbuscarCliente.MouseHover += new System.EventHandler(this.btnbuscar2_MouseHover);
            // 
            // txtbuscarClient
            // 
            this.txtbuscarClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarClient.Location = new System.Drawing.Point(11, 24);
            this.txtbuscarClient.MaxLength = 8;
            this.txtbuscarClient.Multiline = true;
            this.txtbuscarClient.Name = "txtbuscarClient";
            this.txtbuscarClient.Size = new System.Drawing.Size(100, 28);
            this.txtbuscarClient.TabIndex = 10;
            this.txtbuscarClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscarClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarClient_KeyPress);
            // 
            // cbocliente
            // 
            this.cbocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbocliente.Enabled = false;
            this.cbocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(178, 60);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(168, 23);
            this.cbocliente.TabIndex = 15;
            this.cbocliente.Validating += new System.ComponentModel.CancelEventHandler(this.cbocliente_Validating);
            // 
            // cbomodelo
            // 
            this.cbomodelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbomodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomodelo.FormattingEnabled = true;
            this.cbomodelo.Location = new System.Drawing.Point(176, 147);
            this.cbomodelo.Name = "cbomodelo";
            this.cbomodelo.Size = new System.Drawing.Size(146, 23);
            this.cbomodelo.TabIndex = 14;
            this.cbomodelo.Validating += new System.ComponentModel.CancelEventHandler(this.cbomodelo_Validating);
            // 
            // cbomarcav
            // 
            this.cbomarcav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbomarcav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomarcav.FormattingEnabled = true;
            this.cbomarcav.Location = new System.Drawing.Point(178, 105);
            this.cbomarcav.Name = "cbomarcav";
            this.cbomarcav.Size = new System.Drawing.Size(144, 23);
            this.cbomarcav.TabIndex = 13;
            this.cbomarcav.SelectionChangeCommitted += new System.EventHandler(this.cbomarcav_SelectionChangeCommitted);
            this.cbomarcav.Validating += new System.ComponentModel.CancelEventHandler(this.cbomarcav_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Marca del Vehículo";
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(363, 124);
            this.txtcolor.MaxLength = 12;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(123, 21);
            this.txtcolor.TabIndex = 11;
            this.txtcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcolor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Color del Vehículo";
            // 
            // cbotipov
            // 
            this.cbotipov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipov.FormattingEnabled = true;
            this.cbotipov.Location = new System.Drawing.Point(176, 189);
            this.cbotipov.Name = "cbotipov";
            this.cbotipov.Size = new System.Drawing.Size(146, 23);
            this.cbotipov.TabIndex = 9;
            this.cbotipov.Validating += new System.ComponentModel.CancelEventHandler(this.cbotipov_Validating);
            // 
            // txtdescricion
            // 
            this.txtdescricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricion.Location = new System.Drawing.Point(176, 221);
            this.txtdescricion.MaxLength = 100;
            this.txtdescricion.Multiline = true;
            this.txtdescricion.Name = "txtdescricion";
            this.txtdescricion.Size = new System.Drawing.Size(359, 72);
            this.txtdescricion.TabIndex = 6;
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(178, 21);
            this.txtplaca.MaxLength = 6;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(144, 21);
            this.txtplaca.TabIndex = 5;
            this.txtplaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtplaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtplaca_KeyPress);
            this.txtplaca.Validating += new System.ComponentModel.CancelEventHandler(this.txtplaca_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa del Vehículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo del Vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente/Propietario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo de Vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
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
            this.btn_cerrar.Location = new System.Drawing.Point(587, 12);
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
            this.btn_minimizar.Location = new System.Drawing.Point(558, 12);
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
            // Validar_error
            // 
            this.Validar_error.ContainerControl = this;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(208, 2);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(224, 70);
            this.reflectionLabel1.TabIndex = 32;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    </i><font color=\"#B02B2C\"> de </font></font></b" +
    "><b><font size=\"+6\"><i>Vehículos</i><font color=\"#B02B2C\"></font></font></b>";
            // 
            // Registro_vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 546);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_vehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehículo";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Registro_vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.grup_buscar.ResumeLayout(false);
            this.grup_buscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grup_datos.ResumeLayout(false);
            this.grup_datos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraBars.Navigation.TabPane tabPane1;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel btnbuscarplaca;
        public System.Windows.Forms.TextBox txtbuscaVehiculo;
        public System.Windows.Forms.Label label6;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.GroupBox grup_datos;
        public System.Windows.Forms.ComboBox cbomodelo;
        public System.Windows.Forms.ComboBox cbomarcav;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtcolor;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbotipov;
        public System.Windows.Forms.TextBox txtdescricion;
        public System.Windows.Forms.TextBox txtplaca;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbocliente;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel btnbuscarCliente;
        public System.Windows.Forms.TextBox txtbuscarClient;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        public System.Windows.Forms.GroupBox grup_buscar;
        private System.Windows.Forms.Panel btnbusc;
        public System.Windows.Forms.TextBox txtbusc;
        private System.Windows.Forms.CheckBox chestado;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btnmodificar;
        private System.Windows.Forms.Panel btneliminar;
        private System.Windows.Forms.Panel btnnuevo;
        private System.Windows.Forms.ErrorProvider Validar_error;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}