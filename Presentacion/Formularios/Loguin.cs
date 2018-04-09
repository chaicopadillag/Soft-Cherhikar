using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class Loguin : Form
    {
        Usuarios_EN Usu_Ent = new Usuarios_EN();
        Usuarios_Neg Usu_Neg = new Usuarios_Neg();
        int n = 0;
        public Loguin()
        {
            InitializeComponent();
        }
        public void lista_tipo_usuario()
        {
            cbotipousurio.DataSource = Usu_Neg.listatipoUsuario();
            cbotipousurio.DisplayMember = "nombre";
            cbotipousurio.ValueMember = "codigo";
            cbotipousurio.Text ="<<Seleccionar Perfil>>";
               }
        private void Loguin_Load(object sender, EventArgs e)
        {
            cargarPrevias();
            lista_tipo_usuario();
        }

        public void cargarPrevias()
        {
           //centrar Panel
            Size tamaño_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alto = (tamaño_monitor.Height - (-150)) / 2;
            int ancho = (tamaño_monitor.Width - 660) / 2;
            login.Location = new Point(alto, ancho);

            //mostrar fecha y hora

            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToShortTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //actualizando hora a cada segundo
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btniniciar_MouseHover(object sender, EventArgs e)
        {
            btniniciar.BackgroundImage = Properties.Resources.llave;
        }

        private void btniniciar_MouseLeave(object sender, EventArgs e)
        {
           btniniciar.BackgroundImage = Properties.Resources.candado;
        }


        private void lblcerrar_MouseClick(object sender, MouseEventArgs e)
        {
        
          this.Close();
        }

        private void lblminimizar_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnregistrarse_MouseHover(object sender, EventArgs e)
        {
             btnregistrarse.BackgroundImage = Properties.Resources.nuevo_usu;
        }

        private void btnregistrarse_MouseLeave(object sender, EventArgs e)
        {
           btnregistrarse.BackgroundImage = Properties.Resources.masusu;
                
        }

        private void btniniciar_MouseClick(object sender, MouseEventArgs e)
        {      

            if (txtusuario.Text=="")
            {
                MessageBox.Show("Ingrese su identificacion de usuario",
                    "Soft Cherhikcar V1.0",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;                
            }
            else if (txtcontraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña",
                   "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbotipousurio.Text == "<<Seleccionar Perfil>>")
            {
                MessageBox.Show("Debe seleccionar un perfil",
                   "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else{

                iniciarSesion();

                }
        }
        public void iniciarSesion(){
                Usu_Ent.Nombre = txtusuario.Text;
                Usu_Ent.Contraseña = txtcontraseña.Text;
                Usu_Ent.tipo_usu = Convert.ToInt32(cbotipousurio.SelectedValue);

           
               if(Usu_Neg.Logueo(Usu_Ent)>0)
            {
                string usu = Usu_Neg.ColocarNombreUsuario(txtusuario.Text).ToString();
                Program.Usuario = usu;
                Program.Perfil = cbotipousurio.Text; 
                      if (Usu_Ent.tipo_usu==2)
                         {
                          Program.Usuario = txtusuario.Text; ;
                          this.Hide();
                          Validar_Cargo v = new Validar_Cargo();
                         v.Show();
                          }
                      else
                          {
                          this.Hide();
                          Menu men = new Menu();
                          men.Show();
                          }
             }                                                             
                else
                {
                n = n + 1;
                    MessageBox.Show("Acceso denegado, datos incorrectos",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   limpiar();  
                if (n >= 3)
                {
                   if( MessageBox.Show("Lo sentimos, ha superado el límite de intentos",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                     this.Close();
                    }
                   
                }
                                  
                }

            }
        private void btnregistrarse_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
            frm_registrarse_loguin reg_usu = new frm_registrarse_loguin();
            reg_usu.ShowDialog();
        }
        void limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
            lista_tipo_usuario();         
            txtusuario.Focus();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }
    }
}
