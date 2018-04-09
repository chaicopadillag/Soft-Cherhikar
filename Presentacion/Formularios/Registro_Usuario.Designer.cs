namespace Presentacion
{
    partial class Registro_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Usuario));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
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
            this.cbotipo_usu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chestado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtconfircontra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe Ingresar NDI");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.rangeValidator1 = new DevComponents.DotNetBar.Validator.RangeValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.grup_buscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grup_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
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
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(17, 63);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(545, 438);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(545, 438);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.Caption = "Lista de Usuarios";
            this.tabNavigationPage1.Controls.Add(this.dgv_usuarios);
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(527, 393);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(3, 93);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(519, 297);
            this.dgv_usuarios.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnbuscar);
            this.groupBox4.Controls.Add(this.txtbuscar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(354, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 69);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por codigo";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(125, 16);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbuscar, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar Registro", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(100, 21)));
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_MouseClick);
            this.btnbuscar.MouseLeave += new System.EventHandler(this.btnbuscar_MouseLeave);
            this.btnbuscar.MouseHover += new System.EventHandler(this.btnbuscar_MouseHover);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(11, 24);
            this.txtbuscar.MaxLength = 8;
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 28);
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista de Registros de Usuarios";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.AllowTouchScroll = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.Caption = "Registrar Usuarios";
            this.tabNavigationPage2.Controls.Add(this.grup_buscar);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.grup_datos);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Image = global::Presentacion.Properties.Resources.masusu;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNavigationPage2.Size = new System.Drawing.Size(527, 393);
            // 
            // grup_buscar
            // 
            this.grup_buscar.Controls.Add(this.btnbusc);
            this.grup_buscar.Controls.Add(this.txtbusc);
            this.grup_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_buscar.Location = new System.Drawing.Point(350, 301);
            this.grup_buscar.Name = "grup_buscar";
            this.grup_buscar.Size = new System.Drawing.Size(168, 75);
            this.grup_buscar.TabIndex = 9;
            this.grup_buscar.TabStop = false;
            this.grup_buscar.Text = "Buscar usuario";
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
            this.txtbusc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusc.Location = new System.Drawing.Point(11, 24);
            this.txtbusc.MaxLength = 8;
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
            this.groupBox2.Location = new System.Drawing.Point(5, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 88);
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
            this.btncancelar.Location = new System.Drawing.Point(269, 21);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Orange, true, false, new System.Drawing.Size(60, 22)));
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
            this.btnguardar.Location = new System.Drawing.Point(82, 21);
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
            this.btnmodificar.Location = new System.Drawing.Point(146, 21);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnmodificar, new DevComponents.DotNetBar.SuperTooltipInfo("Modificar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, true, false, new System.Drawing.Size(62, 20)));
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
            this.btneliminar.Location = new System.Drawing.Point(208, 21);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btneliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(56, 22)));
            this.btneliminar.TabIndex = 1;
            this.btneliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btneliminar_MouseClick_1);
            this.btneliminar.MouseLeave += new System.EventHandler(this.btneliminar_MouseLeave);
            this.btneliminar.MouseHover += new System.EventHandler(this.btneliminar_MouseHover);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnnuevo.BackgroundImage = global::Presentacion.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevo.Location = new System.Drawing.Point(20, 21);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 49);
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(50, 20)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // grup_datos
            // 
            this.grup_datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_datos.Controls.Add(this.cbotipo_usu);
            this.grup_datos.Controls.Add(this.chestado);
            this.grup_datos.Controls.Add(this.label8);
            this.grup_datos.Controls.Add(this.txtconfircontra);
            this.grup_datos.Controls.Add(this.label7);
            this.grup_datos.Controls.Add(this.txtcorreo);
            this.grup_datos.Controls.Add(this.txtusu);
            this.grup_datos.Controls.Add(this.txtcontraseña);
            this.grup_datos.Controls.Add(this.txtdni);
            this.grup_datos.Controls.Add(this.label1);
            this.grup_datos.Controls.Add(this.label5);
            this.grup_datos.Controls.Add(this.label2);
            this.grup_datos.Controls.Add(this.label4);
            this.grup_datos.Controls.Add(this.label3);
            this.grup_datos.Enabled = false;
            this.grup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_datos.Location = new System.Drawing.Point(3, 3);
            this.grup_datos.Name = "grup_datos";
            this.grup_datos.Size = new System.Drawing.Size(515, 279);
            this.grup_datos.TabIndex = 5;
            this.grup_datos.TabStop = false;
            this.grup_datos.Text = "Datos a Registrar";
            // 
            // cbotipo_usu
            // 
            this.cbotipo_usu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipo_usu.DisplayMember = "Text";
            this.cbotipo_usu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotipo_usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo_usu.FormattingEnabled = true;
            this.cbotipo_usu.ItemHeight = 16;
            this.cbotipo_usu.Location = new System.Drawing.Point(185, 210);
            this.cbotipo_usu.Name = "cbotipo_usu";
            this.cbotipo_usu.Size = new System.Drawing.Size(151, 22);
            this.cbotipo_usu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbotipo_usu.TabIndex = 14;
            this.cbotipo_usu.Validating += new System.ComponentModel.CancelEventHandler(this.cbotipo_usu_Validating_1);
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(185, 249);
            this.chestado.Name = "chestado";
            this.chestado.Size = new System.Drawing.Size(69, 20);
            this.chestado.TabIndex = 13;
            this.chestado.Text = "estado";
            this.chestado.UseVisualStyleBackColor = true;
            this.chestado.Validating += new System.ComponentModel.CancelEventHandler(this.chestado_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado del perfil";
            // 
            // txtconfircontra
            // 
            this.txtconfircontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfircontra.Location = new System.Drawing.Point(186, 139);
            this.txtconfircontra.MaxLength = 12;
            this.txtconfircontra.Name = "txtconfircontra";
            this.txtconfircontra.PasswordChar = '♦';
            this.txtconfircontra.Size = new System.Drawing.Size(133, 22);
            this.txtconfircontra.TabIndex = 11;
            this.txtconfircontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconfircontra.Validating += new System.ComponentModel.CancelEventHandler(this.txtconfircontra_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(186, 176);
            this.txtcorreo.MaxLength = 30;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(197, 22);
            this.txtcorreo.TabIndex = 8;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            // 
            // txtusu
            // 
            this.txtusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusu.Location = new System.Drawing.Point(186, 65);
            this.txtusu.MaxLength = 12;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(197, 22);
            this.txtusu.TabIndex = 7;
            this.txtusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusu_KeyPress);
            this.txtusu.Validating += new System.ComponentModel.CancelEventHandler(this.txtusu_Validating);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(186, 98);
            this.txtcontraseña.MaxLength = 12;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '♦';
            this.txtcontraseña.Size = new System.Drawing.Size(133, 22);
            this.txtcontraseña.TabIndex = 6;
            this.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtcontraseña_Validating);
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(186, 33);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(121, 22);
            this.txtdni.TabIndex = 5;
            this.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            this.txtdni.Validating += new System.ComponentModel.CancelEventHandler(this.txtdni_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo Electrónico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Debe Ingresar NDI";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.txtcontraseña;
            this.compareValidator1.ErrorMessage = "La contraseña no cuencide";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.ErrorMessage = "Your error message here.";
            this.rangeValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
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
            this.btn_cerrar.Location = new System.Drawing.Point(540, 13);
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
            this.btn_minimizar.Location = new System.Drawing.Point(511, 13);
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
            // validar_error
            // 
            this.validar_error.ContainerControl = this;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(180, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(224, 70);
            this.reflectionLabel1.TabIndex = 31;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    </i><font color=\"#B02B2C\"> de </font></font></b" +
    "><b><font size=\"+6\"><i>Usuarios    </i><font color=\"#B02B2C\"></font></font></b>";
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(587, 527);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Registro_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.grup_buscar.ResumeLayout(false);
            this.grup_buscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grup_datos.ResumeLayout(false);
            this.grup_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraBars.Navigation.TabPane tabPane1;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        public DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox grup_datos;
        public System.Windows.Forms.TextBox txtcorreo;
        public System.Windows.Forms.TextBox txtusu;
        public System.Windows.Forms.TextBox txtcontraseña;
        public System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Panel btnbuscar;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btnmodificar;
        private System.Windows.Forms.Panel btneliminar;
        private System.Windows.Forms.Panel btnnuevo;
        public System.Windows.Forms.TextBox txtconfircontra;
        public System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.RangeValidator rangeValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.CheckBox chestado;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.ErrorProvider validar_error;
        public System.Windows.Forms.GroupBox grup_buscar;
        private System.Windows.Forms.Panel btnbusc;
        public System.Windows.Forms.TextBox txtbusc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbotipo_usu;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}