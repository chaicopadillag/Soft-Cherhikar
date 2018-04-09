namespace Presentacion
{
    partial class frm_Carga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Carga));
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lbl_ide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfoto = new System.Windows.Forms.PictureBox();
            this.lblfuncion = new DevComponents.DotNetBar.LabelX();
            this.lblapellido = new DevComponents.DotNetBar.LabelX();
            this.lblnombre = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btm_auto = new DevComponents.DotNetBar.ButtonX();
            this.btnrepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnllave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.AnimationAcceleration = 10F;
            this.progressPanel1.AnimationElementCount = 8;
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseBorderColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.Appearance.Options.UseForeColor = true;
            this.progressPanel1.Appearance.Options.UseTextOptions = true;
            this.progressPanel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressPanel1.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceCaption.BorderColor = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.progressPanel1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressPanel1.AppearanceCaption.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseBorderColor = true;
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
            this.progressPanel1.AppearanceDescription.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceDescription.BackColor2 = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceDescription.BorderColor = System.Drawing.Color.Transparent;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.AppearanceDescription.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.progressPanel1.AppearanceDescription.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressPanel1.AppearanceDescription.Options.UseBackColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseBorderColor = true;
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
            this.progressPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.progressPanel1.Caption = "";
            this.progressPanel1.ContentAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.progressPanel1.Description = "Cargando sistema... 0 %";
            this.progressPanel1.LineAnimationElementHeight = 16;
            this.progressPanel1.Location = new System.Drawing.Point(0, 44);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(333, 114);
            this.progressPanel1.TabIndex = 1;
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // progressBarX1
            // 
            this.progressBarX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(81, 28);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(176, 10);
            this.progressBarX1.TabIndex = 4;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.Visible = false;
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(6, 10);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(325, 61);
            this.reflectionLabel1.TabIndex = 6;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Soft </i><font color=\"#B02B2C\">  Cherhikcar </font></font><" +
    "/b><b><font size=\"+6\"><i>V1.</i><font color=\"#B02B2C\">0</font></font></b>";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(74, 65);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Black;
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Nombre :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(100, 103);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Black;
            this.labelX3.Size = new System.Drawing.Size(31, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Rol :";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(67, 84);
            this.labelX4.Name = "labelX4";
            this.labelX4.SingleLineColor = System.Drawing.Color.Black;
            this.labelX4.Size = new System.Drawing.Size(66, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Apellidos :";
            // 
            // lbl_ide
            // 
            this.lbl_ide.AutoSize = true;
            this.lbl_ide.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ide.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ide.ForeColor = System.Drawing.Color.Black;
            this.lbl_ide.Location = new System.Drawing.Point(-1, 7);
            this.lbl_ide.Name = "lbl_ide";
            this.lbl_ide.Size = new System.Drawing.Size(0, 25);
            this.lbl_ide.TabIndex = 16;
            this.lbl_ide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desarrolladores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnfoto
            // 
            this.btnfoto.BackColor = System.Drawing.Color.Transparent;
            this.btnfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfoto.Location = new System.Drawing.Point(9, 60);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(55, 76);
            this.btnfoto.TabIndex = 14;
            this.btnfoto.TabStop = false;
            // 
            // lblfuncion
            // 
            this.lblfuncion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblfuncion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfuncion.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncion.ForeColor = System.Drawing.Color.Navy;
            this.lblfuncion.Location = new System.Drawing.Point(131, 104);
            this.lblfuncion.Name = "lblfuncion";
            this.lblfuncion.Size = new System.Drawing.Size(169, 23);
            this.lblfuncion.TabIndex = 13;
            // 
            // lblapellido
            // 
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblapellido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblapellido.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.Color.Navy;
            this.lblapellido.Location = new System.Drawing.Point(131, 84);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(169, 23);
            this.lblapellido.TabIndex = 12;
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblnombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Navy;
            this.lblnombre.Location = new System.Drawing.Point(131, 64);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(112, 23);
            this.lblnombre.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Presentacion.Properties.Resources.fondocontroles;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblapellido);
            this.panel1.Controls.Add(this.lbl_ide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.btnfoto);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.lblfuncion);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Location = new System.Drawing.Point(14, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 143);
            this.panel1.TabIndex = 13;
            // 
            // btm_auto
            // 
            this.btm_auto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btm_auto.BackColor = System.Drawing.Color.Transparent;
            this.btm_auto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_auto.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btm_auto.Enabled = false;
            this.btm_auto.Location = new System.Drawing.Point(143, 67);
            this.btm_auto.Name = "btm_auto";
            this.btm_auto.Size = new System.Drawing.Size(45, 43);
            this.btm_auto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btm_auto.Symbol = "";
            this.btm_auto.SymbolColor = System.Drawing.Color.Red;
            this.btm_auto.SymbolSize = 30F;
            this.btm_auto.TabIndex = 14;
            // 
            // btnrepuesto
            // 
            this.btnrepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrepuesto.BackColor = System.Drawing.Color.Transparent;
            this.btnrepuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrepuesto.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnrepuesto.Enabled = false;
            this.btnrepuesto.Location = new System.Drawing.Point(198, 67);
            this.btnrepuesto.Name = "btnrepuesto";
            this.btnrepuesto.Size = new System.Drawing.Size(45, 43);
            this.btnrepuesto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrepuesto.Symbol = "";
            this.btnrepuesto.SymbolColor = System.Drawing.Color.Black;
            this.btnrepuesto.SymbolSize = 30F;
            this.btnrepuesto.TabIndex = 15;
            // 
            // btnllave
            // 
            this.btnllave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnllave.BackColor = System.Drawing.Color.Transparent;
            this.btnllave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnllave.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnllave.Enabled = false;
            this.btnllave.Location = new System.Drawing.Point(92, 67);
            this.btnllave.Name = "btnllave";
            this.btnllave.Size = new System.Drawing.Size(45, 43);
            this.btnllave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnllave.Symbol = "";
            this.btnllave.SymbolColor = System.Drawing.Color.ForestGreen;
            this.btnllave.SymbolSize = 30F;
            this.btnllave.TabIndex = 16;
            // 
            // frm_Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = global::Presentacion.Properties.Resources.tema_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 312);
            this.Controls.Add(this.btnllave);
            this.Controls.Add(this.btnrepuesto);
            this.Controls.Add(this.btm_auto);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.progressBarX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de carga";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.frm_progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.Timer tiempo;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblfuncion;
        private DevComponents.DotNetBar.LabelX lblapellido;
        private DevComponents.DotNetBar.LabelX lblnombre;
        private System.Windows.Forms.PictureBox btnfoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ide;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btm_auto;
        private DevComponents.DotNetBar.ButtonX btnrepuesto;
        private DevComponents.DotNetBar.ButtonX btnllave;
    }
}