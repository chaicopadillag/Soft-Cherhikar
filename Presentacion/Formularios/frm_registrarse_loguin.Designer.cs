namespace Presentacion
{
    partial class frm_registrarse_loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrarse_loguin));
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnregresar = new DevComponents.DotNetBar.ButtonX();
            this.tbniniciar = new DevComponents.DotNetBar.ButtonX();
            this.validar_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cerrar = new DevComponents.DotNetBar.ButtonX();
            this.btn_minimizar = new DevComponents.DotNetBar.ButtonX();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.grup_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).BeginInit();
            this.SuspendLayout();
            // 
            // grup_datos
            // 
            this.grup_datos.BackColor = System.Drawing.Color.Transparent;
            this.grup_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.grup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_datos.Location = new System.Drawing.Point(43, 3);
            this.grup_datos.Name = "grup_datos";
            this.grup_datos.Size = new System.Drawing.Size(351, 279);
            this.grup_datos.TabIndex = 6;
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
            this.cbotipo_usu.Location = new System.Drawing.Point(146, 203);
            this.cbotipo_usu.Name = "cbotipo_usu";
            this.cbotipo_usu.Size = new System.Drawing.Size(147, 22);
            this.cbotipo_usu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbotipo_usu.TabIndex = 14;
            this.cbotipo_usu.Validating += new System.ComponentModel.CancelEventHandler(this.cbotipo_usu_Validating);
            // 
            // chestado
            // 
            this.chestado.AutoSize = true;
            this.chestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestado.Location = new System.Drawing.Point(146, 242);
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
            this.label8.Location = new System.Drawing.Point(7, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado del perfil";
            // 
            // txtconfircontra
            // 
            this.txtconfircontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfircontra.Location = new System.Drawing.Point(147, 132);
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
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(147, 169);
            this.txtcorreo.MaxLength = 30;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(177, 22);
            this.txtcorreo.TabIndex = 8;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            // 
            // txtusu
            // 
            this.txtusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusu.Location = new System.Drawing.Point(147, 58);
            this.txtusu.MaxLength = 12;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(177, 22);
            this.txtusu.TabIndex = 7;
            this.txtusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusu_KeyPress);
            this.txtusu.Validating += new System.ComponentModel.CancelEventHandler(this.txtusu_Validating);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(147, 91);
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
            this.txtdni.Location = new System.Drawing.Point(147, 26);
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
            this.label1.Location = new System.Drawing.Point(6, 29);
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
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 169);
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
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.AppearanceButton.Hovered.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(12, 49);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(449, 425);
            this.tabPane1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.tabPane1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(449, 425);
            this.tabPane1.TabIndex = 7;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.tabNavigationPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabNavigationPage2.Caption = "Registro de Usuario";
            this.tabNavigationPage2.Controls.Add(this.groupBox1);
            this.tabNavigationPage2.Controls.Add(this.grup_datos);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(431, 380);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnregresar);
            this.groupBox1.Controls.Add(this.tbniniciar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(166, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnregresar
            // 
            this.btnregresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnregresar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnregresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregresar.Location = new System.Drawing.Point(6, 19);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(42, 39);
            this.btnregresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnregresar.Symbol = "";
            this.btnregresar.SymbolColor = System.Drawing.Color.Maroon;
            this.btnregresar.SymbolSize = 20F;
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // tbniniciar
            // 
            this.tbniniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbniniciar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbniniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbniniciar.Location = new System.Drawing.Point(69, 19);
            this.tbniniciar.Name = "tbniniciar";
            this.tbniniciar.Size = new System.Drawing.Size(42, 39);
            this.tbniniciar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbniniciar.Symbol = "57697";
            this.tbniniciar.SymbolColor = System.Drawing.Color.Navy;
            this.tbniniciar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.tbniniciar.SymbolSize = 20F;
            this.tbniniciar.TabIndex = 4;
            this.tbniniciar.Click += new System.EventHandler(this.tbniniciar_Click);
            // 
            // validar_error
            // 
            this.validar_error.ContainerControl = this;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(439, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_cerrar.Size = new System.Drawing.Size(22, 25);
            this.btn_cerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_cerrar, new DevComponents.DotNetBar.SuperTooltipInfo("Cerrar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(50, 21)));
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
            this.btn_minimizar.Location = new System.Drawing.Point(410, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_minimizar.Size = new System.Drawing.Size(23, 25);
            this.btn_minimizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btn_minimizar, new DevComponents.DotNetBar.SuperTooltipInfo("Minimizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(66, 21)));
            this.btn_minimizar.Symbol = "57693";
            this.btn_minimizar.SymbolColor = System.Drawing.Color.Yellow;
            this.btn_minimizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_minimizar.TabIndex = 18;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(141, -9);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(224, 70);
            this.reflectionLabel1.TabIndex = 32;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Registro    </i><font color=\"#B02B2C\"> de </font></font></b" +
    "><b><font size=\"+6\"><i>Usuarios    </i><font color=\"#B02B2C\"></font></font></b>";
            // 
            // frm_registrarse_loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 492);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrarse_loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.frm_registrarse_loguin_Load);
            this.grup_datos.ResumeLayout(false);
            this.grup_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validar_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grup_datos;
        private System.Windows.Forms.CheckBox chestado;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtconfircontra;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtcorreo;
        public System.Windows.Forms.TextBox txtusu;
        public System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnregresar;
        private DevComponents.DotNetBar.ButtonX tbniniciar;
        private System.Windows.Forms.ErrorProvider validar_error;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbotipo_usu;
        private DevComponents.DotNetBar.ButtonX btn_cerrar;
        private DevComponents.DotNetBar.ButtonX btn_minimizar;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}