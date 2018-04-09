namespace Presentacion
{
    partial class Loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbotipousurio = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.login = new System.Windows.Forms.Panel();
            this.btnregistrarse = new System.Windows.Forms.Panel();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.lblminimizar = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtcontraseña = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelX1.Location = new System.Drawing.Point(116, 141);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(42, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Perfil";
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.Border.BorderBottomColor = System.Drawing.Color.Black;
            this.txtusuario.Border.Class = "TextBoxBorder";
            this.txtusuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusuario.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(166, 82);
            this.txtusuario.MaxLength = 8;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(152, 22);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // cbotipousurio
            // 
            this.cbotipousurio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipousurio.DisplayMember = "Text";
            this.cbotipousurio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotipousurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipousurio.FormattingEnabled = true;
            this.cbotipousurio.ItemHeight = 16;
            this.cbotipousurio.Location = new System.Drawing.Point(166, 143);
            this.cbotipousurio.Name = "cbotipousurio";
            this.cbotipousurio.Size = new System.Drawing.Size(152, 22);
            this.cbotipousurio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbotipousurio.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelX2.Location = new System.Drawing.Point(97, 84);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Usuario";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelX3.Location = new System.Drawing.Point(73, 112);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(89, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Contraseña";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = global::Presentacion.Properties.Resources.login;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Controls.Add(this.btnregistrarse);
            this.login.Controls.Add(this.lblcerrar);
            this.login.Controls.Add(this.lblminimizar);
            this.login.Controls.Add(this.btniniciar);
            this.login.Controls.Add(this.lblhora);
            this.login.Controls.Add(this.lblfecha);
            this.login.Controls.Add(this.txtusuario);
            this.login.Controls.Add(this.cbotipousurio);
            this.login.Controls.Add(this.labelX3);
            this.login.Controls.Add(this.txtcontraseña);
            this.login.Controls.Add(this.labelX1);
            this.login.Controls.Add(this.labelX2);
            this.login.Controls.Add(this.reflectionLabel1);
            this.login.Location = new System.Drawing.Point(3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(467, 245);
            this.login.TabIndex = 10;
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.BackgroundImage = global::Presentacion.Properties.Resources.masusu;
            this.btnregistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarse.Location = new System.Drawing.Point(324, 131);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(23, 34);
            this.superTooltip1.SetSuperTooltip(this.btnregistrarse, new DevComponents.DotNetBar.SuperTooltipInfo("Registrarse", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Lemon, true, false, new System.Drawing.Size(73, 21)));
            this.btnregistrarse.TabIndex = 7;
            this.btnregistrarse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnregistrarse_MouseClick);
            this.btnregistrarse.MouseLeave += new System.EventHandler(this.btnregistrarse_MouseLeave);
            this.btnregistrarse.MouseHover += new System.EventHandler(this.btnregistrarse_MouseHover);
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.Red;
            this.lblcerrar.Location = new System.Drawing.Point(428, 14);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(21, 22);
            this.superTooltip1.SetSuperTooltip(this.lblcerrar, new DevComponents.DotNetBar.SuperTooltipInfo("Cerrar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Red, true, false, new System.Drawing.Size(48, 21)));
            this.lblcerrar.TabIndex = 9;
            this.lblcerrar.Text = "X";
            this.lblcerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblcerrar_MouseClick);
            // 
            // lblminimizar
            // 
            this.lblminimizar.AutoSize = true;
            this.lblminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblminimizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminimizar.ForeColor = System.Drawing.Color.Yellow;
            this.lblminimizar.Location = new System.Drawing.Point(411, 12);
            this.lblminimizar.Name = "lblminimizar";
            this.lblminimizar.Size = new System.Drawing.Size(22, 22);
            this.superTooltip1.SetSuperTooltip(this.lblminimizar, new DevComponents.DotNetBar.SuperTooltipInfo("Minimizar", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, true, false, new System.Drawing.Size(64, 18)));
            this.lblminimizar.TabIndex = 10;
            this.lblminimizar.Text = "--";
            this.lblminimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblminimizar_MouseClick);
            // 
            // btniniciar
            // 
            this.btniniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btniniciar.BackgroundImage")));
            this.btniniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btniniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciar.Location = new System.Drawing.Point(371, 84);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(62, 80);
            this.superTooltip1.SetSuperTooltip(this.btniniciar, new DevComponents.DotNetBar.SuperTooltipInfo("Iniciar Sesión", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Apple, true, false, new System.Drawing.Size(83, 21)));
            this.btniniciar.TabIndex = 6;
            this.btniniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btniniciar_MouseClick);
            this.btniniciar.MouseLeave += new System.EventHandler(this.btniniciar_MouseLeave);
            this.btniniciar.MouseHover += new System.EventHandler(this.btniniciar_MouseHover);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(358, 182);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(45, 18);
            this.lblhora.TabIndex = 8;
            this.lblhora.Text = "Hora";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfecha.Location = new System.Drawing.Point(46, 182);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(54, 18);
            this.lblfecha.TabIndex = 7;
            this.lblfecha.Text = "Fecha";
            // 
            // txtcontraseña
            // 
            // 
            // 
            // 
            this.txtcontraseña.Border.BorderBottomColor = System.Drawing.Color.Black;
            this.txtcontraseña.Border.Class = "TextBoxBorder";
            this.txtcontraseña.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcontraseña.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(166, 113);
            this.txtcontraseña.MaxLength = 12;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PreventEnterBeep = true;
            this.txtcontraseña.Size = new System.Drawing.Size(152, 22);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(164, 159);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(160, 68);
            this.reflectionLabel1.TabIndex = 12;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Soft   </i><font color=\"#B02B2C\">   Cherhikcar</font></font" +
    "></b><b><font size=\"+6\"><i> V1. </i><font color=\"#B02B2C\">  0</font></font></b>";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 255);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loguin";
            this.Text = "Inicio de Sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Loguin_Load);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbotipousurio;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcontraseña;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        public System.Windows.Forms.Panel login;
        private System.Windows.Forms.Panel btniniciar;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label lblminimizar;
        private System.Windows.Forms.Panel btnregistrarse;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}