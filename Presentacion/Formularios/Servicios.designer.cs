namespace Presentacion
{
    partial class frm_Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Servicios));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbuscarporCodigo = new System.Windows.Forms.Panel();
            this.txtbuscaServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmodificar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.grup_datos = new System.Windows.Forms.GroupBox();
            this.txtNombreServ = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnum_serv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescricion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gropBuscar = new System.Windows.Forms.GroupBox();
            this.btnbuscarCliente = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.ValidarError = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grup_datos.SuspendLayout();
            this.gropBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarError)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(12, 71);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(638, 406);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(638, 406);
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
            this.tabNavigationPage1.Controls.Add(this.dgv_servicios);
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageText = "Lista de Servicios";
            this.tabNavigationPage1.Size = new System.Drawing.Size(620, 361);
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.AllowUserToAddRows = false;
            this.dgv_servicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_servicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_servicios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.Location = new System.Drawing.Point(12, 70);
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_servicios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_servicios.Size = new System.Drawing.Size(595, 276);
            this.dgv_servicios.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnbuscarporCodigo);
            this.groupBox4.Controls.Add(this.txtbuscaServicio);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(398, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 69);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por Codigo";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnbuscarporCodigo
            // 
            this.btnbuscarporCodigo.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarporCodigo.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscarporCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarporCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarporCodigo.Location = new System.Drawing.Point(117, 21);
            this.btnbuscarporCodigo.Name = "btnbuscarporCodigo";
            this.btnbuscarporCodigo.Size = new System.Drawing.Size(37, 40);
            this.btnbuscarporCodigo.TabIndex = 11;
            this.btnbuscarporCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscarplaca_MouseClick);
            this.btnbuscarporCodigo.MouseLeave += new System.EventHandler(this.btnbuscarplaca_MouseLeave);
            this.btnbuscarporCodigo.MouseHover += new System.EventHandler(this.btnbuscarplaca_MouseHover);
            // 
            // txtbuscaServicio
            // 
            this.txtbuscaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscaServicio.Location = new System.Drawing.Point(11, 24);
            this.txtbuscaServicio.MaxLength = 6;
            this.txtbuscaServicio.Multiline = true;
            this.txtbuscaServicio.Name = "txtbuscaServicio";
            this.txtbuscaServicio.Size = new System.Drawing.Size(100, 26);
            this.txtbuscaServicio.TabIndex = 10;
            this.txtbuscaServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscaServicio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lista de Registros de Servicios";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.grup_datos);
            this.tabNavigationPage2.Controls.Add(this.gropBuscar);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageText = "Registro de Servicios";
            this.tabNavigationPage2.Size = new System.Drawing.Size(620, 361);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BackgroundImage = global::Presentacion.Properties.Resources.modificar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Location = new System.Drawing.Point(154, 21);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnmodificar, new DevComponents.DotNetBar.SuperTooltipInfo("Actualizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(65, 21)));
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnmodificar_MouseClick);
            this.btnmodificar.MouseLeave += new System.EventHandler(this.btnmodificar_MouseLeave);
            this.btnmodificar.MouseHover += new System.EventHandler(this.btnmodificar_MouseHover);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::Presentacion.Properties.Resources.Cancel1;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(281, 21);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(61, 21)));
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
            this.btnguardar.Location = new System.Drawing.Point(91, 21);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(56, 21)));
            this.btnguardar.TabIndex = 1;
            this.btnguardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseClick);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseHover += new System.EventHandler(this.btnguardar_MouseHover);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = global::Presentacion.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(217, 21);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btneliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(56, 21)));
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
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(48, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // grup_datos
            // 
            this.grup_datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_datos.Controls.Add(this.txtNombreServ);
            this.grup_datos.Controls.Add(this.txtprecio);
            this.grup_datos.Controls.Add(this.chestado);
            this.grup_datos.Controls.Add(this.label8);
            this.grup_datos.Controls.Add(this.txtnum_serv);
            this.grup_datos.Controls.Add(this.label1);
            this.grup_datos.Controls.Add(this.txtdescricion);
            this.grup_datos.Controls.Add(this.label2);
            this.grup_datos.Controls.Add(this.label3);
            this.grup_datos.Enabled = false;
            this.grup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_datos.Location = new System.Drawing.Point(15, 30);
            this.grup_datos.Name = "grup_datos";
            this.grup_datos.Size = new System.Drawing.Size(594, 225);
            this.grup_datos.TabIndex = 6;
            this.grup_datos.TabStop = false;
            this.grup_datos.Text = "Datos a Registrar";
            this.grup_datos.Enter += new System.EventHandler(this.grup_datos_Enter);
            // 
            // txtNombreServ
            // 
            this.txtNombreServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServ.Location = new System.Drawing.Point(152, 68);
            this.txtNombreServ.MaxLength = 50;
            this.txtNombreServ.Name = "txtNombreServ";
            this.txtNombreServ.Size = new System.Drawing.Size(290, 22);
            this.txtNombreServ.TabIndex = 31;
            this.txtNombreServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreServ_KeyPress);
            this.txtNombreServ.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreServ_Validating);
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(152, 96);
            this.txtprecio.MaxLength = 6;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(129, 22);
            this.txtprecio.TabIndex = 30;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            this.txtprecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecio_Validating);
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(287, 37);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 27;
            this.chestado.Text = "estado";
            this.chestado.UseVisualStyleBackColor = true;
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio del Servicio";
            // 
            // txtnum_serv
            // 
            this.txtnum_serv.Enabled = false;
            this.txtnum_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_serv.ForeColor = System.Drawing.Color.Black;
            this.txtnum_serv.Location = new System.Drawing.Point(152, 37);
            this.txtnum_serv.Name = "txtnum_serv";
            this.txtnum_serv.Size = new System.Drawing.Size(129, 22);
            this.txtnum_serv.TabIndex = 26;
            this.txtnum_serv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum_serv.MouseCaptureChanged += new System.EventHandler(this.txtnum_serv_MouseCaptureChanged);
            this.txtnum_serv.Validating += new System.ComponentModel.CancelEventHandler(this.txtnum_serv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Codigo de Servicio";
            // 
            // txtdescricion
            // 
            this.txtdescricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricion.Location = new System.Drawing.Point(152, 124);
            this.txtdescricion.MaxLength = 100;
            this.txtdescricion.Multiline = true;
            this.txtdescricion.Name = "txtdescricion";
            this.txtdescricion.Size = new System.Drawing.Size(414, 90);
            this.txtdescricion.TabIndex = 6;
            this.txtdescricion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescricion_KeyPress);
            this.txtdescricion.Validating += new System.ComponentModel.CancelEventHandler(this.txtdescricion_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // gropBuscar
            // 
            this.gropBuscar.Controls.Add(this.btnbuscarCliente);
            this.gropBuscar.Controls.Add(this.txtbuscar);
            this.gropBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropBuscar.Location = new System.Drawing.Point(387, 268);
            this.gropBuscar.Name = "gropBuscar";
            this.gropBuscar.Size = new System.Drawing.Size(190, 68);
            this.gropBuscar.TabIndex = 16;
            this.gropBuscar.TabStop = false;
            this.gropBuscar.Text = "Buscar  Servicio";
            // 
            // btnbuscarCliente
            // 
            this.btnbuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscarCliente.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarCliente.Location = new System.Drawing.Point(139, 16);
            this.btnbuscarCliente.Name = "btnbuscarCliente";
            this.btnbuscarCliente.Size = new System.Drawing.Size(45, 46);
            this.btnbuscarCliente.TabIndex = 11;
            this.btnbuscarCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscarCliente_MouseClick);
            this.btnbuscarCliente.MouseLeave += new System.EventHandler(this.btnbuscarCliente_MouseLeave);
            this.btnbuscarCliente.MouseHover += new System.EventHandler(this.btnbuscarCliente_MouseHover);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(17, 29);
            this.txtbuscar.MaxLength = 5;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(116, 22);
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
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
            this.btn_cerrar.Location = new System.Drawing.Point(628, 23);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_cerrar.Size = new System.Drawing.Size(22, 25);
            this.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_cerrar, new DevComponents.DotNetBar.SuperTooltipInfo("Cerrar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(48, 21)));
            this.btn_cerrar.Symbol = "";
            this.btn_cerrar.SymbolColor = System.Drawing.Color.Red;
            this.btn_cerrar.TabIndex = 19;
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
            this.btn_minimizar.Location = new System.Drawing.Point(599, 23);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_minimizar.Size = new System.Drawing.Size(23, 25);
            this.btn_minimizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_minimizar, new DevComponents.DotNetBar.SuperTooltipInfo("Minimizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(64, 21)));
            this.btn_minimizar.Symbol = "57693";
            this.btn_minimizar.SymbolColor = System.Drawing.Color.Yellow;
            this.btn_minimizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_minimizar.TabIndex = 20;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(193, 9);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(263, 70);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro  de </i><font color=\"#B02B2C\">    Servicios</font>" +
    "</font></b>";
            // 
            // frm_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 493);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_Servicios_Cliente";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Registrar_Servicios_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grup_datos.ResumeLayout(false);
            this.grup_datos.PerformLayout();
            this.gropBuscar.ResumeLayout(false);
            this.gropBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.GroupBox grup_datos;
        public System.Windows.Forms.GroupBox gropBuscar;
        private System.Windows.Forms.Panel btnbuscarCliente;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtdescricion;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chestado;
        public System.Windows.Forms.TextBox txtnum_serv;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btneliminar;
        private System.Windows.Forms.Panel btnnuevo;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel btnbuscarporCodigo;
        public System.Windows.Forms.TextBox txtbuscaServicio;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_servicios;
        public System.Windows.Forms.TextBox txtNombreServ;
        private System.Windows.Forms.Panel btnmodificar;
        private System.Windows.Forms.ErrorProvider ValidarError;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
    }
}