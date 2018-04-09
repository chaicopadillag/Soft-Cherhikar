namespace Presentacion
{
    partial class Comprobante_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante_Pago));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbocomprobante = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dglistafacturas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_imprimir_fac = new DevComponents.DotNetBar.ButtonX();
            this.btn_imprimir_bol = new DevComponents.DotNetBar.ButtonX();
            this.btncalcular = new DevComponents.DotNetBar.ButtonX();
            this.grupbuscapedido = new System.Windows.Forms.GroupBox();
            this.btnbuscardetallepedido = new DevComponents.DotNetBar.ButtonX();
            this.txtnumpedido = new System.Windows.Forms.TextBox();
            this.grupbuscarservicio = new System.Windows.Forms.GroupBox();
            this.btnbuscardetalleservicio = new DevComponents.DotNetBar.ButtonX();
            this.txtnumservicio = new System.Windows.Forms.TextBox();
            this.grupcomprobante = new System.Windows.Forms.GroupBox();
            this.rboboleta = new System.Windows.Forms.RadioButton();
            this.rbofactura = new System.Windows.Forms.RadioButton();
            this.grup_Datos = new System.Windows.Forms.GroupBox();
            this.txtnum_comprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.grup_buscar = new System.Windows.Forms.GroupBox();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbopersonal = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cboclientes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.grupdatos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgservicios = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgpedidos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.grupbuscapedido.SuspendLayout();
            this.grupbuscarservicio.SuspendLayout();
            this.grupcomprobante.SuspendLayout();
            this.grup_Datos.SuspendLayout();
            this.grup_buscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupdatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgservicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(28, 52);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(835, 615);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(835, 615);
            this.tabPane1.TabIndex = 3;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.AllowTouchScroll = true;
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.AutoScroll = true;
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage1.Caption = "Lista de Comprobantes de Pago";
            this.tabNavigationPage1.Controls.Add(this.cbocomprobante);
            this.tabNavigationPage1.Controls.Add(this.label15);
            this.tabNavigationPage1.Controls.Add(this.dglistafacturas);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(817, 570);
            // 
            // cbocomprobante
            // 
            this.cbocomprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocomprobante.FormattingEnabled = true;
            this.cbocomprobante.Items.AddRange(new object[] {
            "Factura",
            "Boleta"});
            this.cbocomprobante.Location = new System.Drawing.Point(220, 17);
            this.cbocomprobante.Name = "cbocomprobante";
            this.cbocomprobante.Size = new System.Drawing.Size(149, 24);
            this.superTooltip1.SetSuperTooltip(this.cbocomprobante, new DevComponents.DotNetBar.SuperTooltipInfo("Elegir Comprobante de Pago", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, true, false, new System.Drawing.Size(163, 21)));
            this.cbocomprobante.TabIndex = 38;
            this.cbocomprobante.SelectedIndexChanged += new System.EventHandler(this.cbocomprobante_SelectedIndexChanged);
            this.cbocomprobante.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            this.cbocomprobante.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox4_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Lista de Comprobantes de Pago";
            // 
            // dglistafacturas
            // 
            this.dglistafacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglistafacturas.BackgroundColor = System.Drawing.Color.White;
            this.dglistafacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistafacturas.Location = new System.Drawing.Point(15, 78);
            this.dglistafacturas.Name = "dglistafacturas";
            this.dglistafacturas.Size = new System.Drawing.Size(781, 469);
            this.dglistafacturas.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista de Facturas / Boletas";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.AllowTouchScroll = true;
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.AutoScroll = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "Cuadre de Caja";
            this.tabNavigationPage2.Controls.Add(this.btn_imprimir_fac);
            this.tabNavigationPage2.Controls.Add(this.btn_imprimir_bol);
            this.tabNavigationPage2.Controls.Add(this.btncalcular);
            this.tabNavigationPage2.Controls.Add(this.grupbuscapedido);
            this.tabNavigationPage2.Controls.Add(this.grupbuscarservicio);
            this.tabNavigationPage2.Controls.Add(this.grupcomprobante);
            this.tabNavigationPage2.Controls.Add(this.grup_Datos);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.grupdatos);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Image = global::Presentacion.Properties.Resources.nuevo_usu;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Size = new System.Drawing.Size(817, 570);
            this.tabNavigationPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage2_Paint);
            // 
            // btn_imprimir_fac
            // 
            this.btn_imprimir_fac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_imprimir_fac.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_imprimir_fac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_fac.Location = new System.Drawing.Point(700, 11);
            this.btn_imprimir_fac.Name = "btn_imprimir_fac";
            this.btn_imprimir_fac.Size = new System.Drawing.Size(87, 31);
            this.btn_imprimir_fac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_imprimir_fac, new DevComponents.DotNetBar.SuperTooltipInfo("Imprimir Factura", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btn_imprimir_fac.Symbol = "59565";
            this.btn_imprimir_fac.SymbolColor = System.Drawing.Color.Black;
            this.btn_imprimir_fac.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_imprimir_fac.SymbolSize = 20F;
            this.btn_imprimir_fac.TabIndex = 87;
            this.btn_imprimir_fac.Text = "Factura";
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
            this.btn_imprimir_bol.Location = new System.Drawing.Point(608, 11);
            this.btn_imprimir_bol.Name = "btn_imprimir_bol";
            this.btn_imprimir_bol.Size = new System.Drawing.Size(86, 31);
            this.btn_imprimir_bol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_imprimir_bol, new DevComponents.DotNetBar.SuperTooltipInfo("Imprimir Boleta", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btn_imprimir_bol.Symbol = "58709";
            this.btn_imprimir_bol.SymbolColor = System.Drawing.Color.Black;
            this.btn_imprimir_bol.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_imprimir_bol.SymbolSize = 20F;
            this.btn_imprimir_bol.TabIndex = 86;
            this.btn_imprimir_bol.Text = "Boleta";
            this.btn_imprimir_bol.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_imprimir_bol.TextColor = System.Drawing.Color.Blue;
            this.btn_imprimir_bol.Click += new System.EventHandler(this.btn_imprimir_bol_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.Enabled = false;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(472, 169);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(93, 42);
            this.btncalcular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btncalcular, new DevComponents.DotNetBar.SuperTooltipInfo("Calcular Monto Total", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(122, 21)));
            this.btncalcular.Symbol = "";
            this.btncalcular.SymbolColor = System.Drawing.Color.Navy;
            this.btncalcular.SymbolSize = 20F;
            this.btncalcular.TabIndex = 83;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btncalcular.TextColor = System.Drawing.Color.Navy;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // grupbuscapedido
            // 
            this.grupbuscapedido.Controls.Add(this.btnbuscardetallepedido);
            this.grupbuscapedido.Controls.Add(this.txtnumpedido);
            this.grupbuscapedido.Enabled = false;
            this.grupbuscapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupbuscapedido.Location = new System.Drawing.Point(7, 156);
            this.grupbuscapedido.Name = "grupbuscapedido";
            this.grupbuscapedido.Size = new System.Drawing.Size(217, 63);
            this.grupbuscapedido.TabIndex = 82;
            this.grupbuscapedido.TabStop = false;
            this.grupbuscapedido.Text = "Buscar pedido";
            // 
            // btnbuscardetallepedido
            // 
            this.btnbuscardetallepedido.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbuscardetallepedido.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnbuscardetallepedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscardetallepedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardetallepedido.Location = new System.Drawing.Point(115, 19);
            this.btnbuscardetallepedido.Name = "btnbuscardetallepedido";
            this.btnbuscardetallepedido.Size = new System.Drawing.Size(93, 31);
            this.btnbuscardetallepedido.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btnbuscardetallepedido, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Pedido", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(90, 21)));
            this.btnbuscardetallepedido.Symbol = "";
            this.btnbuscardetallepedido.SymbolColor = System.Drawing.Color.Blue;
            this.btnbuscardetallepedido.SymbolSize = 20F;
            this.btnbuscardetallepedido.TabIndex = 84;
            this.btnbuscardetallepedido.Text = "Buscar";
            this.btnbuscardetallepedido.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnbuscardetallepedido.TextColor = System.Drawing.Color.Blue;
            this.btnbuscardetallepedido.Click += new System.EventHandler(this.btnbuscardetallepedido_Click);
            // 
            // txtnumpedido
            // 
            this.txtnumpedido.Location = new System.Drawing.Point(9, 24);
            this.txtnumpedido.Name = "txtnumpedido";
            this.txtnumpedido.Size = new System.Drawing.Size(100, 20);
            this.txtnumpedido.TabIndex = 81;
            this.txtnumpedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumpedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumpedido_KeyPress);
            this.txtnumpedido.Validating += new System.ComponentModel.CancelEventHandler(this.txtnumpedido_Validating);
            // 
            // grupbuscarservicio
            // 
            this.grupbuscarservicio.Controls.Add(this.btnbuscardetalleservicio);
            this.grupbuscarservicio.Controls.Add(this.txtnumservicio);
            this.grupbuscarservicio.Enabled = false;
            this.grupbuscarservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupbuscarservicio.Location = new System.Drawing.Point(230, 156);
            this.grupbuscarservicio.Name = "grupbuscarservicio";
            this.grupbuscarservicio.Size = new System.Drawing.Size(224, 63);
            this.grupbuscarservicio.TabIndex = 43;
            this.grupbuscarservicio.TabStop = false;
            this.grupbuscarservicio.Text = "Buscar Servicio";
            // 
            // btnbuscardetalleservicio
            // 
            this.btnbuscardetalleservicio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnbuscardetalleservicio.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnbuscardetalleservicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscardetalleservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardetalleservicio.Location = new System.Drawing.Point(123, 21);
            this.btnbuscardetalleservicio.Name = "btnbuscardetalleservicio";
            this.btnbuscardetalleservicio.Size = new System.Drawing.Size(88, 29);
            this.btnbuscardetalleservicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btnbuscardetalleservicio, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Servicio", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(96, 21)));
            this.btnbuscardetalleservicio.Symbol = "";
            this.btnbuscardetalleservicio.SymbolColor = System.Drawing.Color.Blue;
            this.btnbuscardetalleservicio.SymbolSize = 20F;
            this.btnbuscardetalleservicio.TabIndex = 85;
            this.btnbuscardetalleservicio.Text = "Buscar";
            this.btnbuscardetalleservicio.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnbuscardetalleservicio.TextColor = System.Drawing.Color.Blue;
            this.btnbuscardetalleservicio.Click += new System.EventHandler(this.btnbuscardetalleservicio_Click);
            // 
            // txtnumservicio
            // 
            this.txtnumservicio.Location = new System.Drawing.Point(6, 24);
            this.txtnumservicio.Name = "txtnumservicio";
            this.txtnumservicio.Size = new System.Drawing.Size(111, 20);
            this.txtnumservicio.TabIndex = 79;
            this.txtnumservicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumservicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumservicio_KeyPress_1);
            this.txtnumservicio.Validating += new System.ComponentModel.CancelEventHandler(this.txtnumservicio_Validating);
            // 
            // grupcomprobante
            // 
            this.grupcomprobante.BackColor = System.Drawing.Color.Transparent;
            this.grupcomprobante.Controls.Add(this.rboboleta);
            this.grupcomprobante.Controls.Add(this.rbofactura);
            this.grupcomprobante.Enabled = false;
            this.grupcomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupcomprobante.Location = new System.Drawing.Point(571, 159);
            this.grupcomprobante.Name = "grupcomprobante";
            this.grupcomprobante.Size = new System.Drawing.Size(216, 63);
            this.grupcomprobante.TabIndex = 42;
            this.grupcomprobante.TabStop = false;
            this.grupcomprobante.Text = "Tipo de Comprobante";
            // 
            // rboboleta
            // 
            this.rboboleta.AutoSize = true;
            this.rboboleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rboboleta.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboboleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rboboleta.Location = new System.Drawing.Point(14, 23);
            this.rboboleta.Name = "rboboleta";
            this.rboboleta.Size = new System.Drawing.Size(69, 24);
            this.superTooltip1.SetSuperTooltip(this.rboboleta, new DevComponents.DotNetBar.SuperTooltipInfo("Boleta", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(47, 21)));
            this.rboboleta.TabIndex = 31;
            this.rboboleta.TabStop = true;
            this.rboboleta.Text = "Boleta";
            this.rboboleta.UseVisualStyleBackColor = true;
            this.rboboleta.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbofactura
            // 
            this.rbofactura.AutoSize = true;
            this.rbofactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbofactura.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbofactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbofactura.Location = new System.Drawing.Point(109, 23);
            this.rbofactura.Name = "rbofactura";
            this.rbofactura.Size = new System.Drawing.Size(76, 24);
            this.superTooltip1.SetSuperTooltip(this.rbofactura, new DevComponents.DotNetBar.SuperTooltipInfo("Factura", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(56, 21)));
            this.rbofactura.TabIndex = 32;
            this.rbofactura.TabStop = true;
            this.rbofactura.Text = "Factura";
            this.rbofactura.UseVisualStyleBackColor = true;
            this.rbofactura.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // grup_Datos
            // 
            this.grup_Datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_Datos.Controls.Add(this.txtnum_comprobante);
            this.grup_Datos.Controls.Add(this.label2);
            this.grup_Datos.Controls.Add(this.label5);
            this.grup_Datos.Controls.Add(this.label9);
            this.grup_Datos.Controls.Add(this.chestado);
            this.grup_Datos.Controls.Add(this.txtruc);
            this.grup_Datos.Controls.Add(this.grup_buscar);
            this.grup_Datos.Controls.Add(this.label13);
            this.grup_Datos.Controls.Add(this.label1);
            this.grup_Datos.Controls.Add(this.cbopersonal);
            this.grup_Datos.Controls.Add(this.fecha);
            this.grup_Datos.Controls.Add(this.cboclientes);
            this.grup_Datos.Enabled = false;
            this.grup_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_Datos.Location = new System.Drawing.Point(7, 7);
            this.grup_Datos.Name = "grup_Datos";
            this.grup_Datos.Size = new System.Drawing.Size(595, 143);
            this.grup_Datos.TabIndex = 4;
            this.grup_Datos.TabStop = false;
            this.grup_Datos.Text = "Datos de Comprobante pago";
            // 
            // txtnum_comprobante
            // 
            this.txtnum_comprobante.Enabled = false;
            this.txtnum_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_comprobante.ForeColor = System.Drawing.Color.Black;
            this.txtnum_comprobante.Location = new System.Drawing.Point(132, 21);
            this.txtnum_comprobante.Name = "txtnum_comprobante";
            this.txtnum_comprobante.Size = new System.Drawing.Size(128, 22);
            this.txtnum_comprobante.TabIndex = 50;
            this.txtnum_comprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre del Cajero";
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(320, 21);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 77;
            this.chestado.Text = "estado";
            this.chestado.UseVisualStyleBackColor = true;
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating);
            // 
            // txtruc
            // 
            this.txtruc.Enabled = false;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(132, 63);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(128, 22);
            this.txtruc.TabIndex = 30;
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtruc_KeyPress);
            this.txtruc.Validating += new System.ComponentModel.CancelEventHandler(this.txtruc_Validating);
            // 
            // grup_buscar
            // 
            this.grup_buscar.BackColor = System.Drawing.Color.Transparent;
            this.grup_buscar.Controls.Add(this.txtbuscarcliente);
            this.grup_buscar.Controls.Add(this.btnbuscar);
            this.grup_buscar.Enabled = false;
            this.grup_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_buscar.Location = new System.Drawing.Point(397, 4);
            this.grup_buscar.Name = "grup_buscar";
            this.grup_buscar.Size = new System.Drawing.Size(170, 58);
            this.grup_buscar.TabIndex = 7;
            this.grup_buscar.TabStop = false;
            this.grup_buscar.Text = "Buscar cliente";
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarcliente.Location = new System.Drawing.Point(13, 21);
            this.txtbuscarcliente.MaxLength = 8;
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(110, 22);
            this.txtbuscarcliente.TabIndex = 10;
            this.txtbuscarcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscarcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarcliente_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(129, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbuscar, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Cliente", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnbuscar_Paint);
            this.btnbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_MouseClick);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.btnbuscar_MouseLeave);
            this.btnbuscar.MouseHover += new System.EventHandler(this.btnbuscar_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Numero de RUC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nº Comprobante";
            // 
            // cbopersonal
            // 
            this.cbopersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbopersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopersonal.FormattingEnabled = true;
            this.cbopersonal.Location = new System.Drawing.Point(132, 100);
            this.cbopersonal.Name = "cbopersonal";
            this.cbopersonal.Size = new System.Drawing.Size(128, 24);
            this.cbopersonal.TabIndex = 14;
            this.cbopersonal.SelectedIndexChanged += new System.EventHandler(this.cbopersonal_SelectedIndexChanged);
            this.cbopersonal.Validating += new System.ComponentModel.CancelEventHandler(this.cbopersonal_Validating);
            // 
            // fecha
            // 
            this.fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(397, 113);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(161, 22);
            this.fecha.TabIndex = 15;
            this.fecha.Validating += new System.ComponentModel.CancelEventHandler(this.fecha_Validating);
            // 
            // cboclientes
            // 
            this.cboclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboclientes.Enabled = false;
            this.cboclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclientes.FormattingEnabled = true;
            this.cboclientes.Location = new System.Drawing.Point(397, 68);
            this.cboclientes.Name = "cboclientes";
            this.cboclientes.Size = new System.Drawing.Size(161, 24);
            this.cboclientes.TabIndex = 16;
            this.cboclientes.SelectedIndexChanged += new System.EventHandler(this.cboclientes_SelectedIndexChanged);
            this.cboclientes.SelectionChangeCommitted += new System.EventHandler(this.cboclientes_SelectionChangeCommitted);
            this.cboclientes.Validating += new System.ComponentModel.CancelEventHandler(this.cboclientes_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 97);
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
            this.btnguardar.Location = new System.Drawing.Point(68, 26);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(45, 55);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(56, 21)));
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
            this.btncancelar.Location = new System.Drawing.Point(119, 26);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(45, 55);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Tan, true, false, new System.Drawing.Size(60, 21)));
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
            this.btnnuevo.Location = new System.Drawing.Point(15, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 54);
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(48, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnnuevo_Paint);
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // grupdatos
            // 
            this.grupdatos.BackColor = System.Drawing.Color.Transparent;
            this.grupdatos.Controls.Add(this.groupBox1);
            this.grupdatos.Controls.Add(this.label3);
            this.grupdatos.Controls.Add(this.label10);
            this.grupdatos.Controls.Add(this.dgservicios);
            this.grupdatos.Controls.Add(this.dgpedidos);
            this.grupdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupdatos.Location = new System.Drawing.Point(7, 219);
            this.grupdatos.Name = "grupdatos";
            this.grupdatos.Size = new System.Drawing.Size(780, 598);
            this.grupdatos.TabIndex = 5;
            this.grupdatos.TabStop = false;
            this.grupdatos.Enter += new System.EventHandler(this.grupdatos_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtigv);
            this.groupBox1.Controls.Add(this.txtmontototal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(542, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigv.Location = new System.Drawing.Point(100, 14);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(117, 22);
            this.txtigv.TabIndex = 40;
            this.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmontototal
            // 
            this.txtmontototal.Enabled = false;
            this.txtmontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontototal.ForeColor = System.Drawing.Color.Black;
            this.txtmontototal.Location = new System.Drawing.Point(100, 69);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(117, 22);
            this.txtmontototal.TabIndex = 18;
            this.txtmontototal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "IGV 18%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(100, 42);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(117, 22);
            this.txtsubtotal.TabIndex = 29;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Monto Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Lista de Pedido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Lista de Servicio";
            // 
            // dgservicios
            // 
            this.dgservicios.AllowUserToDeleteRows = false;
            this.dgservicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgservicios.BackgroundColor = System.Drawing.Color.White;
            this.dgservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgservicios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgservicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgservicios.Location = new System.Drawing.Point(11, 261);
            this.dgservicios.Name = "dgservicios";
            this.dgservicios.ReadOnly = true;
            this.dgservicios.Size = new System.Drawing.Size(750, 223);
            this.dgservicios.TabIndex = 70;
            // 
            // dgpedidos
            // 
            this.dgpedidos.AllowUserToOrderColumns = true;
            this.dgpedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgpedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgpedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgpedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgpedidos.Location = new System.Drawing.Point(11, 28);
            this.dgpedidos.Name = "dgpedidos";
            this.dgpedidos.Size = new System.Drawing.Size(747, 211);
            this.dgpedidos.TabIndex = 23;
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
            this.btn_cerrar.Location = new System.Drawing.Point(839, 21);
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
            this.btn_minimizar.Location = new System.Drawing.Point(810, 21);
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
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(327, -4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(270, 70);
            this.reflectionLabel1.TabIndex = 21;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Proceso   de  </i><font color=\"#B02B2C\">      Facturación</" +
    "font></font></b>";
            // 
            // Comprobante_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 698);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comprobante_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Comprobante_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistafacturas)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.grupbuscapedido.ResumeLayout(false);
            this.grupbuscapedido.PerformLayout();
            this.grupbuscarservicio.ResumeLayout(false);
            this.grupbuscarservicio.PerformLayout();
            this.grupcomprobante.ResumeLayout(false);
            this.grupcomprobante.PerformLayout();
            this.grup_Datos.ResumeLayout(false);
            this.grup_Datos.PerformLayout();
            this.grup_buscar.ResumeLayout(false);
            this.grup_buscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grupdatos.ResumeLayout(false);
            this.grupdatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgservicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraBars.Navigation.TabPane tabPane1;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.DataGridView dglistafacturas;
        public System.Windows.Forms.Label label6;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.Panel btnnuevo;
        public System.Windows.Forms.GroupBox grupdatos;
        public System.Windows.Forms.TextBox txtigv;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbofactura;
        private System.Windows.Forms.RadioButton rboboleta;
        public System.Windows.Forms.TextBox txtruc;
        public System.Windows.Forms.TextBox txtsubtotal;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgpedidos;
        public System.Windows.Forms.TextBox txtmontototal;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox grup_buscar;
        private System.Windows.Forms.Panel btnbuscar;
        public System.Windows.Forms.TextBox txtbuscarcliente;
        public System.Windows.Forms.ComboBox cboclientes;
        private System.Windows.Forms.DateTimePicker fecha;
        public System.Windows.Forms.ComboBox cbopersonal;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbocomprobante;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtnum_comprobante;
        public System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgservicios;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grupcomprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chestado;
        private System.Windows.Forms.GroupBox grup_Datos;
        private System.Windows.Forms.ErrorProvider validar_error;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private System.Windows.Forms.TextBox txtnumpedido;
        private System.Windows.Forms.TextBox txtnumservicio;
        private System.Windows.Forms.GroupBox grupbuscapedido;
        private System.Windows.Forms.GroupBox grupbuscarservicio;
        private DevComponents.DotNetBar.ButtonX btncalcular;
        private DevComponents.DotNetBar.ButtonX btnbuscardetallepedido;
        private DevComponents.DotNetBar.ButtonX btnbuscardetalleservicio;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btn_imprimir_fac;
        private DevComponents.DotNetBar.ButtonX btn_imprimir_bol;
    }
}