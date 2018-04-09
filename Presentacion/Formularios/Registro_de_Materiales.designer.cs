namespace Presentacion
{
    partial class Registro_de_Materiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_de_Materiales));
            this.groupbuscar = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupopciones = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btncacelar = new System.Windows.Forms.Button();
            this.groupdatos = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cnbcategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.checkestado = new System.Windows.Forms.CheckBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbusc = new System.Windows.Forms.TextBox();
            this.btnbusc = new System.Windows.Forms.Button();
            this.dgv_materiales = new System.Windows.Forms.DataGridView();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupbuscar.SuspendLayout();
            this.groupopciones.SuspendLayout();
            this.groupdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbuscar
            // 
            this.groupbuscar.Controls.Add(this.txtbuscar);
            this.groupbuscar.Controls.Add(this.btnBuscar);
            this.groupbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbuscar.Location = new System.Drawing.Point(370, 336);
            this.groupbuscar.Name = "groupbuscar";
            this.groupbuscar.Size = new System.Drawing.Size(200, 87);
            this.groupbuscar.TabIndex = 25;
            this.groupbuscar.TabStop = false;
            this.groupbuscar.Text = "Buscar Repuesto";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(19, 37);
            this.txtbuscar.MaxLength = 5;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(90, 22);
            this.txtbuscar.TabIndex = 16;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(126, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 59);
            this.superTooltip1.SetSuperTooltip(this.btnBuscar, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar para modificar/eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(171, 21)));
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // groupopciones
            // 
            this.groupopciones.Controls.Add(this.btnNuevo);
            this.groupopciones.Controls.Add(this.btnEliminar);
            this.groupopciones.Controls.Add(this.btnGuardar);
            this.groupopciones.Controls.Add(this.btnModificar);
            this.groupopciones.Controls.Add(this.btncacelar);
            this.groupopciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupopciones.Location = new System.Drawing.Point(16, 336);
            this.groupopciones.Name = "groupopciones";
            this.groupopciones.Size = new System.Drawing.Size(348, 87);
            this.groupopciones.TabIndex = 24;
            this.groupopciones.TabStop = false;
            this.groupopciones.Text = "Opciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::Presentacion.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(13, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(47, 59);
            this.superTooltip1.SetSuperTooltip(this.btnNuevo, new DevComponents.DotNetBar.SuperTooltipInfo("Nuevo", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(60, 0)));
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseHover += new System.EventHandler(this.btnNuevo_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Presentacion.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(210, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 59);
            this.superTooltip1.SetSuperTooltip(this.btnEliminar, new DevComponents.DotNetBar.SuperTooltipInfo("Eliminar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(65, 0)));
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::Presentacion.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(79, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 59);
            this.superTooltip1.SetSuperTooltip(this.btnGuardar, new DevComponents.DotNetBar.SuperTooltipInfo("Guardar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(60, 0)));
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseHover += new System.EventHandler(this.btnGuardar_MouseHover);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Presentacion.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(144, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(48, 59);
            this.superTooltip1.SetSuperTooltip(this.btnModificar, new DevComponents.DotNetBar.SuperTooltipInfo("Modificar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(65, 0)));
            this.btnModificar.TabIndex = 19;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnModificar.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // btncacelar
            // 
            this.btncacelar.BackgroundImage = global::Presentacion.Properties.Resources.Cancel;
            this.btncacelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncacelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncacelar.Enabled = false;
            this.btncacelar.FlatAppearance.BorderSize = 0;
            this.btncacelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncacelar.Location = new System.Drawing.Point(277, 19);
            this.btncacelar.Name = "btncacelar";
            this.btncacelar.Size = new System.Drawing.Size(47, 59);
            this.superTooltip1.SetSuperTooltip(this.btncacelar, new DevComponents.DotNetBar.SuperTooltipInfo("Cancelar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Tan, true, false, new System.Drawing.Size(60, 0)));
            this.btncacelar.TabIndex = 21;
            this.btncacelar.UseVisualStyleBackColor = true;
            this.btncacelar.Click += new System.EventHandler(this.btncacelar_Click);
            this.btncacelar.MouseLeave += new System.EventHandler(this.btncacelar_MouseLeave);
            this.btncacelar.MouseHover += new System.EventHandler(this.btncacelar_MouseHover);
            // 
            // groupdatos
            // 
            this.groupdatos.Controls.Add(this.txtcodigo);
            this.groupdatos.Controls.Add(this.cnbcategoria);
            this.groupdatos.Controls.Add(this.label6);
            this.groupdatos.Controls.Add(this.txtmarca);
            this.groupdatos.Controls.Add(this.checkestado);
            this.groupdatos.Controls.Add(this.txtcantidad);
            this.groupdatos.Controls.Add(this.txtprecio);
            this.groupdatos.Controls.Add(this.label8);
            this.groupdatos.Controls.Add(this.label7);
            this.groupdatos.Controls.Add(this.label5);
            this.groupdatos.Controls.Add(this.label4);
            this.groupdatos.Controls.Add(this.label3);
            this.groupdatos.Controls.Add(this.label2);
            this.groupdatos.Controls.Add(this.txtnombres);
            this.groupdatos.Enabled = false;
            this.groupdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupdatos.Location = new System.Drawing.Point(15, 16);
            this.groupdatos.Name = "groupdatos";
            this.groupdatos.Size = new System.Drawing.Size(554, 292);
            this.groupdatos.TabIndex = 0;
            this.groupdatos.TabStop = false;
            this.groupdatos.Text = "Datos a Registrar";
            this.groupdatos.Enter += new System.EventHandler(this.groupdatos_Enter);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(158, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(124, 22);
            this.txtcodigo.TabIndex = 21;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnbcategoria
            // 
            this.cnbcategoria.FormattingEnabled = true;
            this.cnbcategoria.Location = new System.Drawing.Point(161, 208);
            this.cnbcategoria.Name = "cnbcategoria";
            this.cnbcategoria.Size = new System.Drawing.Size(185, 24);
            this.cnbcategoria.TabIndex = 20;
            this.cnbcategoria.Validating += new System.ComponentModel.CancelEventHandler(this.cnbcategoria_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Codigo de repuesto";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(161, 173);
            this.txtmarca.MaxLength = 50;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(185, 22);
            this.txtmarca.TabIndex = 17;
            this.txtmarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmarca_KeyPress);
            this.txtmarca.Validating += new System.ComponentModel.CancelEventHandler(this.txtmarca_Validating);
            // 
            // checkestado
            // 
            this.checkestado.AutoSize = true;
            this.checkestado.Location = new System.Drawing.Point(161, 254);
            this.checkestado.Name = "checkestado";
            this.checkestado.Size = new System.Drawing.Size(15, 14);
            this.checkestado.TabIndex = 1;
            this.checkestado.UseVisualStyleBackColor = true;
            this.checkestado.Validating += new System.ComponentModel.CancelEventHandler(this.checkestado_Validating);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(161, 138);
            this.txtcantidad.MaxLength = 10;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(121, 22);
            this.txtcantidad.TabIndex = 15;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            this.txtcantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtcantidad_Validating);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(161, 101);
            this.txtprecio.MaxLength = 6;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(121, 22);
            this.txtprecio.TabIndex = 14;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            this.txtprecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecio_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad existente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio del repuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado del repuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria del repuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca del repuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del repuesto";
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(161, 66);
            this.txtnombres.MaxLength = 50;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(280, 22);
            this.txtnombres.TabIndex = 1;
            this.txtnombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            this.txtnombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombres_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lista de Repuestos";
            // 
            // txtbusc
            // 
            this.txtbusc.Location = new System.Drawing.Point(17, 21);
            this.txtbusc.MaxLength = 5;
            this.txtbusc.Name = "txtbusc";
            this.txtbusc.Size = new System.Drawing.Size(100, 20);
            this.txtbusc.TabIndex = 6;
            this.txtbusc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbusc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusc_KeyPress);
            // 
            // btnbusc
            // 
            this.btnbusc.BackgroundImage = global::Presentacion.Properties.Resources.buca2;
            this.btnbusc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusc.FlatAppearance.BorderSize = 0;
            this.btnbusc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusc.Location = new System.Drawing.Point(133, 10);
            this.btnbusc.Name = "btnbusc";
            this.btnbusc.Size = new System.Drawing.Size(37, 45);
            this.superTooltip1.SetSuperTooltip(this.btnbusc, new DevComponents.DotNetBar.SuperTooltipInfo("Buscar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(60, 0)));
            this.btnbusc.TabIndex = 5;
            this.btnbusc.UseVisualStyleBackColor = true;
            this.btnbusc.Click += new System.EventHandler(this.btnbusc_Click);
            this.btnbusc.MouseLeave += new System.EventHandler(this.btnbusc_MouseLeave);
            this.btnbusc.MouseHover += new System.EventHandler(this.btnbusc_MouseHover);
            // 
            // dgv_materiales
            // 
            this.dgv_materiales.AllowUserToAddRows = false;
            this.dgv_materiales.AllowUserToDeleteRows = false;
            this.dgv_materiales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_materiales.BackgroundColor = System.Drawing.Color.White;
            this.dgv_materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiales.Location = new System.Drawing.Point(3, 85);
            this.dgv_materiales.Name = "dgv_materiales";
            this.dgv_materiales.ReadOnly = true;
            this.dgv_materiales.Size = new System.Drawing.Size(571, 337);
            this.dgv_materiales.TabIndex = 0;
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
            this.btn_cerrar.Location = new System.Drawing.Point(602, 21);
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
            this.btn_minimizar.Location = new System.Drawing.Point(573, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbusc);
            this.groupBox1.Controls.Add(this.txtbusc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(374, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por codigo";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(20, 72);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(604, 485);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(604, 485);
            this.tabPane1.TabIndex = 2;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage1.Caption = "Lista de Registros";
            this.tabNavigationPage1.Controls.Add(this.dgv_materiales);
            this.tabNavigationPage1.Controls.Add(this.label9);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(586, 440);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.Caption = "Registro de Repuestos";
            this.tabNavigationPage2.Controls.Add(this.groupbuscar);
            this.tabNavigationPage2.Controls.Add(this.groupdatos);
            this.tabNavigationPage2.Controls.Add(this.groupopciones);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(586, 440);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(202, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(248, 70);
            this.reflectionLabel1.TabIndex = 32;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    </i><font color=\"#B02B2C\"> de </font></font></b" +
    "><b><font size=\"+6\"><i>Repuestos    </i><font color=\"#B02B2C\"></font></font></b>" +
    "";
            // 
            // Registro_de_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 574);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_de_Materiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_de_Materiales";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Registro_de_Materiales_Load);
            this.groupbuscar.ResumeLayout(false);
            this.groupbuscar.PerformLayout();
            this.groupopciones.ResumeLayout(false);
            this.groupdatos.ResumeLayout(false);
            this.groupdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider validar_error;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        public System.Windows.Forms.GroupBox groupbuscar;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.GroupBox groupopciones;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btncacelar;
        public System.Windows.Forms.GroupBox groupdatos;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnombres;
        public System.Windows.Forms.DataGridView dgv_materiales;
        public System.Windows.Forms.CheckBox checkestado;
        public System.Windows.Forms.TextBox txtmarca;
        public System.Windows.Forms.ComboBox cnbcategoria;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtbusc;
        public System.Windows.Forms.Button btnbusc;
        public System.Windows.Forms.TextBox txtcodigo;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}