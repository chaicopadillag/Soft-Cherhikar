using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frm_registrarse_loguin : Form
    {
        Usuarios_EN e = new Usuarios_EN();
        Usuarios_Neg n = new Usuarios_Neg();
        Validacion_texbox v = new Validacion_texbox();
        public frm_registrarse_loguin()
        {
            InitializeComponent();
        }

        private void frm_registrarse_loguin_Load(object sender, EventArgs e)
        {
            cargar_pefil();
            tbniniciar.Focus();
        }
        public void cargar_pefil()
        {
            cbotipo_usu.DataSource = n.listatipoUsuario();
            cbotipo_usu.DisplayMember = "nombre";
            cbotipo_usu.ValueMember = "codigo";
            cbotipo_usu.Text ="<<Seleccione>>";
        }
        public void registar_usuario()
        {
            e.Codigo = txtdni.Text;
            e.Nombre = txtusu.Text;
            e.Contraseña = txtconfircontra.Text;
            e.correo = txtcorreo.Text;
            e.tipo_usu = Convert.ToInt32(cbotipo_usu.SelectedValue);
            e.estado = chestado.Checked;
            if (MessageBox.Show("¿Estas seguro que quieres guardar?",
                "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (n.insertarUsuario(e) > 0)
                {
                    MessageBox.Show("Se ha guardado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                                              
                  
                    nuevo();
                    validar_error.Clear();
                    //tabNavigationPage2.Select();
                }
                else
                {
                    MessageBox.Show("Error al guardar",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        void nuevo()
        {
            
            txtconfircontra.Clear();
            txtcontraseña.Clear();
            txtcorreo.Clear();
            txtdni.Clear();
            txtusu.Clear();           
            cargar_pefil();
            chestado.Checked = false;

        }
        private void tbniniciar_Click(object sender, EventArgs e)
        {

            if ( cbotipo_usu.Text=="<<Seleccione>>" || txtdni.TextLength<8 || txtusu.TextLength<4
                || txtconfircontra.Text ==""|| txtcontraseña.TextLength<6||txtcorreo.Text==""||
                ValidarCoorrreo(txtcorreo.Text) == false|| chestado.Checked == false)
            {
                MessageBox.Show("Llena los capos correctamente para guardar",
                "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtdni.TextLength < 8 )
                {validar_error.SetError(txtdni, "Minimo ocho caracteres");
                }
                if( txtusu.TextLength < 4)
                { validar_error.SetError(txtusu, "Debe ingresar al menos un nombre");
                }
                if (txtcontraseña.TextLength<6)
                { validar_error.SetError(txtcontraseña, "Minimo seis caracteres");
                }
                if (txtconfircontra.Text != txtcontraseña.Text)
                {validar_error.SetError(txtconfircontra, "la contraseña no cuencide");  
                }
                if (ValidarCoorrreo(txtcorreo.Text) == false)
                {
                    validar_error.SetError(txtcorreo, "Correo no valido");
                }
                if (cbotipo_usu.Text=="<<Seleccione>>")
                {validar_error.SetError(cbotipo_usu, "Debe eligir un perfil");
                }
                if (chestado.Checked == false)
                { validar_error.SetError(chestado, "Para crear debe estar activo");
                }       
                return;
                          
                 }
            else
            {
                if (txtconfircontra.Text == txtcontraseña.Text)
                {
                 registar_usuario();
                }
                else
                {
                    MessageBox.Show("La contraseña no cuencide",
                "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   validar_error.SetError(txtconfircontra, "la contraseña no cuencide");
                    
                }
               
            }
        }
        public static bool ValidarCoorrreo(string correo)
        {
            String Formato_Coreo;
            Formato_Coreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, Formato_Coreo))
            {
                if (Regex.Replace(correo, Formato_Coreo, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void txtdni_Validating(object sender, CancelEventArgs e)
        {           
            if (txtdni.TextLength < 8)
            {
                validar_error.SetError(txtdni, "Minimo ocho caracteres");
            }
            else
            {
                validar_error.SetError(txtdni, null);
            }
        }

        private void txtusu_Validating(object sender, CancelEventArgs e)
        {
            if (txtusu.TextLength<4)
            {
                validar_error.SetError(txtusu, "Debe ingresar al menos un nombre");

            }
            else
            {
                validar_error.SetError(txtusu, null);
            }
        }

        private void txtcontraseña_Validating(object sender, CancelEventArgs e)
        {          
            if (txtcontraseña.TextLength < 6)
            {
                validar_error.SetError(txtcontraseña, "Minimo seis caracteres");
            }
            else
            {
                validar_error.SetError(txtcontraseña, null);
            }
        }

        private void txtconfircontra_Validating(object sender, CancelEventArgs e)
        {
            if (txtconfircontra.Text != txtcontraseña.Text)
            {
                validar_error.SetError(txtconfircontra, "la contraseña no cuencide");

            }
            else
            {
                validar_error.SetError(txtconfircontra, null);
            }
        }     

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {

                validar_error.SetError(chestado, "Para crear la cuenta debe estar activo");

            }
            else
            {
                validar_error.SetError(chestado, null);
            }
        }    

        private void btnregresar_Click(object sender, EventArgs e)
        {
            validar_error.Clear();
            this.Close();
        }

        private void cbotipo_usu_Validating(object sender, CancelEventArgs e)
        {
            if (cbotipo_usu.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cbotipo_usu, "Debe eligir un perfil");

            }
            else
            {
                validar_error.SetError(cbotipo_usu, null);
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarCoorrreo(txtcorreo.Text) == false)
            {
                validar_error.SetError(txtcorreo, "Correo no valido");
            }
            else
            {
                validar_error.SetError(txtcorreo, null);
            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarCoorrreo(txtcorreo.Text) == false)
            {
                validar_error.SetError(txtcorreo, "Correo no valido");
            }
            else
            {
                validar_error.SetError(txtcorreo, null);
            }
        }
    }
}
