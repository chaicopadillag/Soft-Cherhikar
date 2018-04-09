namespace PRESENTACION
{
    partial class Mantenimiento_Registro_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Registro_Clientes));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grupdatos = new System.Windows.Forms.GroupBox();
            this.txtdni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chEstado = new System.Windows.Forms.CheckBox();
            this.cbopersonal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtdireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbotipocliente = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbodistrito = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtnombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txttelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtapellidopaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtapellidomaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Panel();
            this.btnnuevo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntbuscarPorCodigo = new System.Windows.Forms.Panel();
            this.txtBuscarClientes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip2 = new DevComponents.DotNetBar.SuperTooltip();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.grupdatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(28, 77);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(683, 506);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(683, 506);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Registro de clientes";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage1.Caption = "Lista de Clientes";
            this.tabNavigationPage1.Controls.Add(this.labelX11);
            this.tabNavigationPage1.Controls.Add(this.dgListaClientes);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(665, 461);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX11.Location = new System.Drawing.Point(270, 38);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(188, 36);
            this.labelX11.TabIndex = 85;
            this.labelX11.Text = "Lista de Clientes";
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToAddRows = false;
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgListaClientes.Location = new System.Drawing.Point(9, 80);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.ReadOnly = true;
            this.dgListaClientes.Size = new System.Drawing.Size(650, 365);
            this.dgListaClientes.TabIndex = 12;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "Registro de Clientes";
            this.tabNavigationPage2.Controls.Add(this.grupdatos);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Controls.Add(this.groupBox3);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(665, 461);
            // 
            // grupdatos
            // 
            this.grupdatos.BackColor = System.Drawing.Color.Transparent;
            this.grupdatos.Controls.Add(this.txtdni);
            this.grupdatos.Controls.Add(this.chEstado);
            this.grupdatos.Controls.Add(this.cbopersonal);
            this.grupdatos.Controls.Add(this.txtdireccion);
            this.grupdatos.Controls.Add(this.cbotipocliente);
            this.grupdatos.Controls.Add(this.labelX5);
            this.grupdatos.Controls.Add(this.cbodistrito);
            this.grupdatos.Controls.Add(this.labelX10);
            this.grupdatos.Controls.Add(this.labelX8);
            this.grupdatos.Controls.Add(this.labelX7);
            this.grupdatos.Controls.Add(this.labelX1);
            this.grupdatos.Controls.Add(this.txtnombre);
            this.grupdatos.Controls.Add(this.labelX2);
            this.grupdatos.Controls.Add(this.txttelefono);
            this.grupdatos.Controls.Add(this.txtapellidopaterno);
            this.grupdatos.Controls.Add(this.labelX6);
            this.grupdatos.Controls.Add(this.txtapellidomaterno);
            this.grupdatos.Controls.Add(this.txtMontoTotal);
            this.grupdatos.Controls.Add(this.label7);
            this.grupdatos.Controls.Add(this.labelX4);
            this.grupdatos.Controls.Add(this.labelX3);
            this.grupdatos.Controls.Add(this.labelX9);
            this.grupdatos.Enabled = false;
            this.grupdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupdatos.Location = new System.Drawing.Point(8, 33);
            this.grupdatos.Name = "grupdatos";
            this.grupdatos.Size = new System.Drawing.Size(638, 254);
            this.grupdatos.TabIndex = 86;
            this.grupdatos.TabStop = false;
            this.grupdatos.Text = "Datos a Registrar";
            this.grupdatos.Enter += new System.EventHandler(this.grupdatos_Enter);
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdni.Border.Class = "TextBoxBorder";
            this.txtdni.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdni.DisabledBackColor = System.Drawing.Color.White;
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.Color.Black;
            this.txtdni.Location = new System.Drawing.Point(115, 36);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.PreventEnterBeep = true;
            this.txtdni.Size = new System.Drawing.Size(169, 22);
            this.txtdni.TabIndex = 103;
            this.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            this.txtdni.Validating += new System.ComponentModel.CancelEventHandler(this.txtdni_Validating);
            // 
            // chEstado
            // 
            this.chEstado.AutoSize = true;
            this.chEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEstado.Location = new System.Drawing.Point(594, 169);
            this.chEstado.Name = "chEstado";
            this.chEstado.Size = new System.Drawing.Size(15, 14);
            this.chEstado.TabIndex = 102;
            this.chEstado.UseVisualStyleBackColor = true;
            this.chEstado.Validating += new System.ComponentModel.CancelEventHandler(this.chEstado_Validating);
            // 
            // cbopersonal
            // 
            this.cbopersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbopersonal.DisplayMember = "Text";
            this.cbopersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbopersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopersonal.ForeColor = System.Drawing.Color.Black;
            this.cbopersonal.FormattingEnabled = true;
            this.cbopersonal.ItemHeight = 16;
            this.cbopersonal.Location = new System.Drawing.Point(416, 119);
            this.cbopersonal.Name = "cbopersonal";
            this.cbopersonal.Size = new System.Drawing.Size(193, 22);
            this.cbopersonal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbopersonal.TabIndex = 101;
            this.cbopersonal.Validating += new System.ComponentModel.CancelEventHandler(this.cbopersonal_Validating);
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdireccion.Border.Class = "TextBoxBorder";
            this.txtdireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdireccion.DisabledBackColor = System.Drawing.Color.White;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Location = new System.Drawing.Point(115, 161);
            this.txtdireccion.MaxLength = 30;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PreventEnterBeep = true;
            this.txtdireccion.Size = new System.Drawing.Size(320, 22);
            this.txtdireccion.TabIndex = 93;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtdireccion_Validating);
            // 
            // cbotipocliente
            // 
            this.cbotipocliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipocliente.DisplayMember = "Text";
            this.cbotipocliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotipocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipocliente.ForeColor = System.Drawing.Color.Black;
            this.cbotipocliente.FormattingEnabled = true;
            this.cbotipocliente.ItemHeight = 16;
            this.cbotipocliente.Location = new System.Drawing.Point(115, 119);
            this.cbotipocliente.Name = "cbotipocliente";
            this.cbotipocliente.Size = new System.Drawing.Size(169, 22);
            this.cbotipocliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbotipocliente.TabIndex = 100;
            this.cbotipocliente.Validating += new System.ComponentModel.CancelEventHandler(this.cbotipocliente_Validating);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX5.Location = new System.Drawing.Point(51, 160);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(58, 23);
            this.labelX5.TabIndex = 88;
            this.labelX5.Text = "Direccion";
            // 
            // cbodistrito
            // 
            this.cbodistrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodistrito.DisplayMember = "Text";
            this.cbodistrito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodistrito.ForeColor = System.Drawing.Color.Black;
            this.cbodistrito.FormattingEnabled = true;
            this.cbodistrito.ItemHeight = 16;
            this.cbodistrito.Location = new System.Drawing.Point(416, 209);
            this.cbodistrito.Name = "cbodistrito";
            this.cbodistrito.Size = new System.Drawing.Size(193, 22);
            this.cbodistrito.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodistrito.TabIndex = 99;
            this.cbodistrito.Validating += new System.ComponentModel.CancelEventHandler(this.cbodistrito_Validating);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX10.Location = new System.Drawing.Point(525, 164);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(54, 23);
            this.labelX10.TabIndex = 98;
            this.labelX10.Text = "Estado";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(38, 117);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(79, 23);
            this.labelX8.TabIndex = 96;
            this.labelX8.Text = "Tipo Cliente";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX7.Location = new System.Drawing.Point(360, 209);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(45, 23);
            this.labelX7.TabIndex = 95;
            this.labelX7.Text = "Distrito";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(30, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 84;
            this.labelX1.Text = "Identificacion";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnombre.Border.Class = "TextBoxBorder";
            this.txtnombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnombre.DisabledBackColor = System.Drawing.Color.White;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(416, 36);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PreventEnterBeep = true;
            this.txtnombre.Size = new System.Drawing.Size(193, 22);
            this.txtnombre.TabIndex = 90;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombre_Validating);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(356, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 85;
            this.labelX2.Text = "Nombre";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttelefono.Border.Class = "TextBoxBorder";
            this.txttelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttelefono.DisabledBackColor = System.Drawing.Color.White;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.Black;
            this.txttelefono.Location = new System.Drawing.Point(115, 209);
            this.txttelefono.MaxLength = 9;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PreventEnterBeep = true;
            this.txttelefono.Size = new System.Drawing.Size(134, 22);
            this.txttelefono.TabIndex = 94;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            this.txttelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txttelefono_Validating);
            // 
            // txtapellidopaterno
            // 
            this.txtapellidopaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtapellidopaterno.Border.Class = "TextBoxBorder";
            this.txtapellidopaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtapellidopaterno.DisabledBackColor = System.Drawing.Color.White;
            this.txtapellidopaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidopaterno.ForeColor = System.Drawing.Color.Black;
            this.txtapellidopaterno.Location = new System.Drawing.Point(115, 76);
            this.txtapellidopaterno.MaxLength = 30;
            this.txtapellidopaterno.Name = "txtapellidopaterno";
            this.txtapellidopaterno.PreventEnterBeep = true;
            this.txtapellidopaterno.Size = new System.Drawing.Size(169, 22);
            this.txtapellidopaterno.TabIndex = 91;
            this.txtapellidopaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtapellidopaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidopaterno_KeyPress);
            this.txtapellidopaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtapellidopaterno_Validating);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX6.Location = new System.Drawing.Point(53, 209);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(56, 23);
            this.labelX6.TabIndex = 89;
            this.labelX6.Text = "Telefono";
            // 
            // txtapellidomaterno
            // 
            this.txtapellidomaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtapellidomaterno.Border.Class = "TextBoxBorder";
            this.txtapellidomaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtapellidomaterno.DisabledBackColor = System.Drawing.Color.White;
            this.txtapellidomaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidomaterno.ForeColor = System.Drawing.Color.Black;
            this.txtapellidomaterno.Location = new System.Drawing.Point(416, 76);
            this.txtapellidomaterno.MaxLength = 30;
            this.txtapellidomaterno.Name = "txtapellidomaterno";
            this.txtapellidomaterno.PreventEnterBeep = true;
            this.txtapellidomaterno.Size = new System.Drawing.Size(193, 22);
            this.txtapellidomaterno.TabIndex = 92;
            this.txtapellidomaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtapellidomaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidomaterno_KeyPress);
            this.txtapellidomaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtapellidomaterno_Validating);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtMontoTotal.Location = new System.Drawing.Point(502, 412);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(155, 22);
            this.txtMontoTotal.TabIndex = 18;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Importe Total ";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(316, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(150, 20);
            this.labelX4.TabIndex = 87;
            this.labelX4.Text = "Apellido Materno";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(15, 72);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(146, 23);
            this.labelX3.TabIndex = 86;
            this.labelX3.Text = "Apellido Paterno";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX9.Location = new System.Drawing.Point(306, 119);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(115, 23);
            this.labelX9.TabIndex = 97;
            this.labelX9.Text = "Nombre secretaria";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 100);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::Presentacion.Properties.Resources.modificar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(157, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 54);
            this.superTooltip1.SetSuperTooltip(this.btnEditar, new DevComponents.DotNetBar.SuperTooltipInfo("Actualizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, true, false, new System.Drawing.Size(69, 21)));
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseClick);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            this.btnEditar.MouseHover += new System.EventHandler(this.btnEditar_MouseHover);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::Presentacion.Properties.Resources.Cancel;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(284, 21);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 54);
            this.superTooltip1.SetSuperTooltip(this.btncancelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(68, 21)));
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
            this.btnguardar.Size = new System.Drawing.Size(48, 54);
            this.superTooltip1.SetSuperTooltip(this.btnguardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(57, 21)));
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnguardar_Paint);
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
            this.btneliminar.Location = new System.Drawing.Point(221, 21);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 54);
            this.superTooltip1.SetSuperTooltip(this.btneliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Orange, true, false, new System.Drawing.Size(59, 21)));
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
            this.btnnuevo.Size = new System.Drawing.Size(46, 54);
            this.superTooltip1.SetSuperTooltip(this.btnnuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(47, 21)));
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnnuevo_MouseClick);
            this.btnnuevo.MouseLeave += new System.EventHandler(this.btnnuevo_MouseLeave);
            this.btnnuevo.MouseHover += new System.EventHandler(this.btnnuevo_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.bntbuscarPorCodigo);
            this.groupBox3.Controls.Add(this.txtBuscarClientes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(434, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 78);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador Cliente";
            // 
            // bntbuscarPorCodigo
            // 
            this.bntbuscarPorCodigo.BackColor = System.Drawing.Color.Transparent;
            this.bntbuscarPorCodigo.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.bntbuscarPorCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntbuscarPorCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntbuscarPorCodigo.Location = new System.Drawing.Point(137, 21);
            this.bntbuscarPorCodigo.Name = "bntbuscarPorCodigo";
            this.bntbuscarPorCodigo.Size = new System.Drawing.Size(40, 45);
            this.superTooltip1.SetSuperTooltip(this.bntbuscarPorCodigo, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(52, 21)));
            this.bntbuscarPorCodigo.TabIndex = 85;
            this.bntbuscarPorCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bntbuscarPorCodigo_MouseClick);
            this.bntbuscarPorCodigo.MouseLeave += new System.EventHandler(this.bntbuscarPorCodigo_MouseLeave);
            this.bntbuscarPorCodigo.MouseHover += new System.EventHandler(this.bntbuscarPorCodigo_MouseHover);
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBuscarClientes.Border.Class = "TextBoxBorder";
            this.txtBuscarClientes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuscarClientes.DisabledBackColor = System.Drawing.Color.White;
            this.txtBuscarClientes.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarClientes.Location = new System.Drawing.Point(15, 33);
            this.txtBuscarClientes.MaxLength = 8;
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.PreventEnterBeep = true;
            this.txtBuscarClientes.Size = new System.Drawing.Size(115, 22);
            this.txtBuscarClientes.TabIndex = 65;
            this.txtBuscarClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarClientes_KeyPress);
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
            this.btn_cerrar.Location = new System.Drawing.Point(689, 27);
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
            this.btn_minimizar.Location = new System.Drawing.Point(660, 27);
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
            // validar_error
            // 
            this.validar_error.ContainerControl = this;
            // 
            // superTooltip2
            // 
            this.superTooltip2.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel1.Location = new System.Drawing.Point(246, 6);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(249, 73);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    de   </i><font color=\"#B02B2C\">   Clientes</fon" +
    "t></font></b>";
            // 
            // Mantenimiento_Registro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 605);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento_Registro_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_Registro_Clientes";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Mantenimiento_Registro_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.grupdatos.ResumeLayout(false);
            this.grupdatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBuscarClientes;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel btncancelar;
        private System.Windows.Forms.Panel btnguardar;
        private System.Windows.Forms.Panel btneliminar;
        private System.Windows.Forms.Panel btnnuevo;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Panel bntbuscarPorCodigo;
        private System.Windows.Forms.Panel btnEditar;
        public System.Windows.Forms.GroupBox grupdatos;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdni;
        private System.Windows.Forms.CheckBox chEstado;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbopersonal;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbotipocliente;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodistrito;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombre;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttelefono;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtapellidopaterno;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtapellidomaterno;
        public System.Windows.Forms.TextBox txtMontoTotal;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private System.Windows.Forms.ErrorProvider validar_error;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdireccion;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.SuperTooltip superTooltip2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
    }
}