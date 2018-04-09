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
    public partial class Registro_Usuario : Form
    {
        Usuarios_EN usua_Ent = new Usuarios_EN();
        Usuarios_Neg usua_Neg = new Usuarios_Neg();
        Validacion_texbox v = new Validacion_texbox();           

        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void btnnuevo_MouseHover(object sender, EventArgs e)
        {
            btnnuevo.BackgroundImage = Properties.Resources.nuevo2;
        }

        private void btnnuevo_MouseLeave(object sender, EventArgs e)
        {
            btnnuevo.BackgroundImage = Properties.Resources.nuevo;
        }
        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            btnguardar.BackgroundImage = Properties.Resources.guardar2;
        }

        private void btnguardar_MouseLeave(object sender, EventArgs e)
        {
            btnguardar.BackgroundImage = Properties.Resources.guardar;
        }

        private void tnmodificar_MouseHover(object sender, EventArgs e)
        {
            btnmodificar.BackgroundImage = Properties.Resources.modific2;
        }

        private void tnmodificar_MouseLeave(object sender, EventArgs e)
        {
            btnmodificar.BackgroundImage = Properties.Resources.modificar;
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Properties.Resources.eliminar2;
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Properties.Resources.eliminar;
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            btnbuscar.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar.BackgroundImage = Properties.Resources.buca2;
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            cargar_tipo_usuario();
            cbotipo_usu.Text = "<<Seleccione>>";
            cargar_lista_usuarios();
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

        void cargar_lista_usuarios()
        {
            dgv_usuarios.DataSource = usua_Neg.ListarUsuario();
        }
      
        void cargar_tipo_usuario()
        {
            cbotipo_usu.DataSource = usua_Neg.listatipoUsuario();
            cbotipo_usu.DisplayMember = "nombre";
            cbotipo_usu.ValueMember = "codigo";
           
                        
        }
        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {
           
            grup_datos.Enabled = true;
            nuevo();
            grup_buscar.Enabled = false;         
            txtdni.Focus();
            btncancelar.Enabled = true;
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btnnuevo.Enabled = false;
        }
        void nuevo()
        {
            txtbuscar.Clear();
            txtconfircontra.Clear();
            txtcontraseña.Clear();
            txtcorreo.Clear();
            txtdni.Clear();
            txtusu.Clear();
            txtbusc.Clear();
            cargar_tipo_usuario();
            cbotipo_usu.Text = "<<Seleccione>>";
            chestado.Checked = false; 
            
        }
        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtdni.TextLength==8&txtusu.TextLength>=4&txtcontraseña.TextLength>=6 
                &txtcorreo.Text!=""&ValidarCoorrreo(txtcorreo.Text)==true&
                cbotipo_usu.Text != "<<Seleccione>>" & chestado.Checked== true )
            {
                if (txtconfircontra.Text == txtcontraseña.Text)
                {
                    registar_usuario();                                                         
                }
                else
                {
                    MessageBox.Show("la Contraseña no cuencide", 
                        "Soft Cherhikcar V1.0",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    validar_error.SetError(txtconfircontra, "la contraseña no cuencide");
                }
            
            }
            else
            {
                MessageBox.Show("Llenar los campos correctamente para guardar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campos();
            }            
        }
        void validar_campos()
        {
            if (txtdni.TextLength<8)
                {
                    validar_error.SetError(txtdni, "Minimo ocho caracteres");
                }
                if (txtusu.Text == "")
                {
                    validar_error.SetError(txtusu, "Debe ingresar al menos un nombre");
                }
                if (txtcontraseña.TextLength<6)
                {
                    validar_error.SetError(txtcontraseña, "Minimo seis caracteres");
                }
                if (txtconfircontra.Text != txtcontraseña.Text)
                {
                    validar_error.SetError(txtconfircontra, "la contraseña no cuencide");
                }
               if (ValidarCoorrreo(txtcorreo.Text) == false)
                {
                validar_error.SetError(txtcorreo, "correo no valido");
                }
              
               if (cbotipo_usu.Text == "<<Seleccione>>")
                {
                    validar_error.SetError(cbotipo_usu, "Debe eligir un perfil");
                }
                if (chestado.Checked == false)
                {
                    validar_error.SetError(chestado, "Para crear debe estar activo");
                }

        }
      public  void registar_usuario()
        { usua_Ent.Codigo  = txtdni.Text;
            usua_Ent.Nombre = txtusu.Text;
            usua_Ent.Contraseña = txtconfircontra.Text;
            usua_Ent.correo = txtcorreo.Text;
            usua_Ent.tipo_usu =Convert.ToInt32( cbotipo_usu.SelectedValue);
            usua_Ent.estado = chestado.Checked;
            if(MessageBox.Show("¿Estas seguro que quieres guardar?",
                "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
               if(usua_Neg.insertarUsuario(usua_Ent) > 0)
                {
                    MessageBox.Show("El usuario ''"+usua_Ent.Nombre+"'' se ha guardado correctamente",
                        "Soft Cherhikcar V1.0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargar_lista_usuarios();
                    grup_buscar.Enabled = true;                   
                    grup_datos.Enabled = false;
                    cargar_lista_usuarios();
                    nuevo();
                    validar_error.Clear();
                    btncancelar.Enabled = false;
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;
                    //tabNavigationPage2.Select();
                }
                else
                {
                   
                    MessageBox.Show("Error al guardar",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }           

        }

        private void btnmodificar_MouseClick(object sender, MouseEventArgs e)
        {
            if(grup_datos.Enabled==false)
            {
                MessageBox.Show("Debe buscar un registro para modificar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtdni.TextLength == 8 && txtusu.TextLength >= 4 && txtcontraseña.TextLength >= 6
                && cbotipo_usu.Text != "<<Seleccione>>" && chestado.Checked == true)
            {
                if(txtconfircontra.Text == txtcontraseña.Text)
                {
                    modificar_Usuario();
                   
                }
                else
                {
                    MessageBox.Show("la Contraseña no coencide",
                       "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
           
                
            }
            else
            {
                MessageBox.Show("Antes de modificar debes ingresar datos validos", 
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campos();               
            }
           
            
        }   
        
        public void modificar_Usuario()
        { usua_Ent.Codigo = txtdni.Text;
            usua_Ent.Nombre = txtusu.Text;
            usua_Ent.Contraseña = txtconfircontra.Text;
            usua_Ent.correo = txtcorreo.Text;
            usua_Ent.tipo_usu = Convert.ToInt32(cbotipo_usu.SelectedValue);
            usua_Ent.estado = chestado.Checked;
            if (MessageBox.Show("¿Estas seguro de modificar?", "Soft Cherhikcar V1.0", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (usua_Neg.ActualizarUsuario(usua_Ent) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_lista_usuarios();
                    grup_datos.Enabled = false;
                    nuevo();
                    btncancelar.Enabled = false;
                    btnmodificar.Enabled = false;
                    grup_buscar.Enabled = true;
                    btneliminar.Enabled = false;
                    btnnuevo.Enabled = true;

                    //tabNavigationPage2.Select();
                }
                else
                {

                    MessageBox.Show("Error al modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo();

                }
            }
            else
            {
                validar_error.Clear();
            }

        }        
        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {                
                 
            grup_datos.Enabled = false;
            validar_error.Clear();            
            grup_buscar.Enabled = true;
            nuevo();
            txtbusc.Focus();           
            btnguardar.Enabled = false;
            btnnuevo.Enabled = true;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
           
        }

        private void btneliminar_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtdni.TextLength==8)            {
                eliminar_usuario();
                
               
            }
            else {
                MessageBox.Show("Debe buscar un codigo para eliminar", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        

        }
        public void eliminar_usuario()
        { usua_Ent.Codigo = txtdni.Text;
           
            if (MessageBox.Show("¿Estas seguro de eliminar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (usua_Neg.eliminarUsuario(usua_Ent) > 0)
                {
                    MessageBox.Show("Se ha eliminado correctamente", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_lista_usuarios();                   
                    grup_datos.Enabled = false;
                    validar_error.Clear();
                    nuevo();
                    btncancelar.Enabled = false;
                    btneliminar.Enabled = false;
                    grup_buscar.Enabled = true;
                    btnmodificar.Enabled = false;
                    btnnuevo.Enabled = true;
                }
                else
                {

                    MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                
                validar_error.Clear();
            }

        }
        private void btnbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
            { usua_Ent.Codigo = txtbuscar.Text;
                if (usua_Neg.BuscarUsuario(usua_Ent).Rows.Count > 0)
                {
                    dgv_usuarios.DataSource= usua_Neg.BuscarUsuario(usua_Ent);
                validar_error.Clear();
                
                }
                else
                { MessageBox.Show("El usuario que busca no existe", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscar.Clear();
                return;
                }

               
            }
           
        }
       

        private void txtdni_Validating(object sender, CancelEventArgs e)
        {
            if (txtdni.TextLength<8)
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
            if (txtcontraseña.TextLength<6)
            {
               validar_error.SetError(txtcontraseña, "Minimo seis caracteres");
                
            }
            else
            {
                validar_error.SetError(txtcontraseña,null);
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

        private void btnbusc_MouseHover(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbusc_MouseLeave(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnbusc_MouseClick(object sender, MouseEventArgs e)
        {
            usua_Ent.Codigo = txtbusc.Text;
            if (txtbusc.Text !="") {
                if (usua_Neg.Buscar_Usuario(usua_Ent) == true)
                {
                    cargar_tipo_usuario();
                    txtdni.Text = usua_Ent.Codigo.ToString();
                    txtusu.Text = usua_Ent.Nombre.ToString();
                    txtcontraseña.Text = usua_Ent.Contraseña.ToString();
                    txtconfircontra.Text= usua_Ent.Contraseña.ToString();
                    txtcorreo.Text = usua_Ent.correo.ToString();
                    cbotipo_usu.SelectedValue =  usua_Ent.tipo_usu;
                    chestado.Checked = usua_Ent.estado;
                    grup_datos.Enabled = true;
                    btnmodificar.Enabled = true;
                    validar_error.Clear();
                    btncancelar.Enabled = true;
                    btneliminar.Enabled = true;
                    btnnuevo.Enabled = false;
                    grup_buscar.Enabled = false;
                    txtbusc.Clear();

                }
                else
                {
                    MessageBox.Show("El Usuario que busca no existe", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    grup_datos.Enabled = false;
                    txtbusc.Clear();
                    validar_error.Clear();
                       }
            }
            else
            {
                MessageBox.Show("Ingresa un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbotipo_usu_Validating_1(object sender, CancelEventArgs e)
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

        private void txtbusc_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.Solo_Numeros(e);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            v.Solo_Numeros(e);
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            if (ValidarCoorrreo(txtcorreo.Text) == false)
            {
                validar_error.SetError(txtcorreo, "correo no valido");
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
                validar_error.SetError(txtcorreo, "correo no valido");
            }
            else
            {
                validar_error.SetError(txtcorreo, null);
            }
        }
    }
}
