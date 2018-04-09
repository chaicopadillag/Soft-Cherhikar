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

namespace Presentacion
{
    public partial class Registro_del_personal : Form
    {
        Personal_EN pers_Ent = new Personal_EN();
        Personal_Neg per_Neg = new Personal_Neg();
        
        Validacion_texbox v = new Validacion_texbox(); 

        public Registro_del_personal()
        {
            InitializeComponent();
        }
        void cargarcargo()
        {
            cnbcargo.DataSource = per_Neg.listarCargo();
            cnbcargo.DisplayMember = "nombre";
            cnbcargo.ValueMember = "codigo";           
        }
        void cargardistrito()
        {
            cnbdistrito.DataSource = per_Neg.listaDistrito();
            cnbdistrito.DisplayMember = "distrito";
            cnbdistrito.ValueMember = "codigo";           
        }
        void listarpersonal()
        {
            dgv_personal.DataSource = per_Neg.ListarPersonal();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        private void button6_Click(object sender, EventArgs e)
        {
            
        }


        private void Registro_del_personal_Load(object sender, EventArgs e)
        {
            cargarcargo();
            cnbcargo.Text = "<<Seleccione>>";
            cargardistrito();
            cnbdistrito.Text = "<<Seleccione>>";
            listarpersonal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtidentificacion.TextLength==8)            {
                eliminar_Personal();
                
               
            }
            else {
                MessageBox.Show("Debe buscar un codigo para eliminar", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        

        }

        public void eliminar_Personal()
        { pers_Ent.Codigo = txtidentificacion.Text;
           
            if (MessageBox.Show("¿Estas seguro de eliminar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (per_Neg.eliminarPersonal(pers_Ent) > 0)
                {
                    MessageBox.Show("Se ha eliminado correctamente", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupdatos.Enabled = false;
                    nuevo();
                    btncancelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                    groupbuscar.Enabled = true;
                    listarpersonal();               
                }
                else
                {

                    MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnbusc_Click(object sender, EventArgs e)
        {
             if (txtbusc.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else
             {
                 pers_Ent.Codigo = txtbusc.Text;
                 if (per_Neg.BuscarPersonal_tabla(pers_Ent).Rows.Count > 0)
                {
                    dgv_personal.DataSource = per_Neg.BuscarPersonal_tabla(pers_Ent);
            
                
                }
                else
                { MessageBox.Show("El Personal que busca no existe", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscar.Clear();
                return;
                }

               
            }
           }

        private void btnNuevo_MouseClick(object sender, MouseEventArgs e)
        {
            groupdatos.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevo();
            groupbuscar.Enabled = false;
            txtidentificacion.Focus();
            btncancelar.Enabled = true;
            //btnGuardar.Enabled = true;
            //btnModificar.Enabled = true;
            //btnEliminar.Enabled = true;
            btnNuevo.Enabled = false;          
        }
        void nuevo()
        {
            txtbuscar.Clear();
            txtidentificacion.Clear();
            txtnombres.Clear();
            txtapellidopa.Clear();
            txtapellidoma.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            checestado.Checked = false;
            cargarcargo();
            cnbcargo.Text = "<<Seleccione>>";
            cargardistrito();
            cnbdistrito.Text = "<<Seleccione>>";
            //txtbusc.Clear();
            //cnbcargo();
            //cnbdistrito();

        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtidentificacion.TextLength == 8 && txtnombres.TextLength > 3 &&
                txtapellidopa.TextLength > 3
                               && txtapellidoma.TextLength > 3 && txtdireccion.TextLength > 4
                               && txttelefono.Text != ""
               && cnbdistrito.Text != "<<Seleccione>>" && cnbcargo.Text != "<<Seleccione>>" &&
               checestado.Checked == true)
            {
                registar_personal();
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
            if (txtidentificacion.TextLength < 8)
            {
                validar_error.SetError(txtidentificacion, "Debes ingresar un DNI");
            }
            if (txtnombres.TextLength <3)
            {
                validar_error.SetError(txtnombres, "Debes ingresar un nombre");
            }
            if (txtapellidopa.TextLength < 3)
            {
                validar_error.SetError(txtapellidopa, "Debes ingresar un apellido paterno");
            }
            if (txtapellidoma.TextLength < 3)
            {
                validar_error.SetError(txtapellidoma, "Debes ingresar un apellido materno");
            }
            if (txtdireccion.TextLength < 3)
            {
                validar_error.SetError(txtdireccion, "Debes ingresar una direccion");
            }
            if (txttelefono.TextLength <9)
            {
                validar_error.SetError(txttelefono, "Debes ingresar un numero telefonico");
            }

            if (cnbdistrito.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbdistrito, "Debe eligir un distrito");
            }
            if (cnbcargo.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbcargo, "Debe eligir un Cargo");
            }

            if (checestado.Checked == false)
            {
                validar_error.SetError(checestado, "Para crear debe estar activo");
            }

        }
        public void registar_personal()
        {
            pers_Ent.Codigo = txtidentificacion.Text;
            pers_Ent.Nombre = txtnombres.Text;
            pers_Ent.Nombrepaterno = txtapellidopa.Text;
            pers_Ent.Nombrematerno = txtapellidoma.Text;
            pers_Ent.Direccion = txtdireccion.Text;
            pers_Ent.Telefono = Convert.ToInt32(txttelefono.Text);
            pers_Ent.Distrito = Convert.ToInt32(cnbdistrito.SelectedValue);
            pers_Ent.Cargo = Convert.ToInt32(cnbcargo.SelectedValue);
            pers_Ent.Estado = checestado.Checked;

            if (MessageBox.Show("¿Estas seguro que quieres guardar?",
                "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (per_Neg.insertarPersonal(pers_Ent) > 0)
                {
                    MessageBox.Show("El personal ''" + pers_Ent.Nombre + "'' se ha guardado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupdatos.Enabled = false;
                    groupbuscar.Enabled = true;
                    btncancelar.Enabled = false;
                    btnGuardar.Enabled = false;
                    nuevo();
                    btnNuevo.Enabled = true;
                    listarpersonal();
                    validar_error.Clear();                   //tabNavigationPage2.Select();
                }
                else
                {

                    MessageBox.Show("Error al guardar",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnModificar_CursorChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            if (groupdatos.Enabled == false)
            {
                MessageBox.Show("Debe buscar un registro para modificar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtidentificacion.TextLength == 8 && txtnombres.TextLength >3 &&
                txtapellidopa.TextLength > 3
                               && txtapellidoma.TextLength > 3 && txtdireccion.TextLength > 3
                               && txttelefono.Text != ""
               && cnbdistrito.Text != "<<Seleccione>>" && cnbcargo.Text != "<<Seleccione>>" && 
               checestado.Checked == true)
            {

                modificar_Personal();
              


            }
            else
            {
                MessageBox.Show("Antes de modificar debes ingresar datos validos",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campos();
            }


        }

        public void modificar_Personal()
        {
            pers_Ent.Codigo = txtidentificacion.Text;
            pers_Ent.Nombre = txtnombres.Text;
            pers_Ent.Nombrepaterno = txtapellidopa.Text;
            pers_Ent.Nombrematerno = txtapellidoma.Text;
            pers_Ent.Direccion = txtdireccion.Text;
            pers_Ent.Telefono = Convert.ToInt32(txttelefono.Text);
            pers_Ent.Distrito = Convert.ToInt32(cnbdistrito.SelectedValue);
            pers_Ent.Cargo = Convert.ToInt32(cnbcargo.SelectedValue);
            pers_Ent.Estado = checestado.Checked;

            if (MessageBox.Show("¿Estas seguro de modificar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (per_Neg.ActualizarPersonal(pers_Ent) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupdatos.Enabled = false;
                    nuevo();
                    btncancelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                    groupbuscar.Enabled = true;
                    listarpersonal();
                    //tabNavigationPage2.Select();
                }
                else
                {

                    MessageBox.Show("Error al modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo();

                }
            }

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (txtbuscar.Text != "")
            {
                pers_Ent.Codigo = txtbuscar.Text;

                if (per_Neg.Buscar_Personal(pers_Ent) == true)                   
                {
                    cargarcargo();
                    cargardistrito();
                    txtidentificacion.Text = pers_Ent.Codigo.ToString();
                    txtnombres.Text = pers_Ent.Nombre.ToString();
                    txtapellidopa.Text = pers_Ent.Nombrepaterno.ToString();
                    txtapellidoma.Text = pers_Ent.Nombrematerno.ToString();
                    txtdireccion.Text = pers_Ent.Direccion.ToString();
                    txttelefono.Text = pers_Ent.Telefono.ToString();
                    cnbdistrito.SelectedValue = pers_Ent.Distrito;
                    cnbcargo.SelectedValue = pers_Ent.Cargo;
                    checestado.Checked = pers_Ent.Estado;
                    groupdatos.Enabled = true;
                    btnModificar.Enabled = true;
                    btncancelar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnNuevo.Enabled = false;
                    txtbuscar.Clear();
                    validar_error.Clear();
                    groupbuscar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El Personal no existe", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    groupdatos.Enabled = true;
                    txtbuscar.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingresa un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
            groupdatos.Enabled = false;
            groupbuscar.Enabled = true;
            nuevo();
            txtbuscar.Focus();
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btncancelar.Enabled = false;            
            validar_error.Clear();            
        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtapellidopa_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtapellidoma_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtbusc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.nuevo2;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.guardar2;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.guardar;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Properties.Resources.modific2;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Properties.Resources.modificar;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.eliminar2;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.busc;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnbusc_MouseHover(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbusc_MouseLeave(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.buca2;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtidentificacion_Validating(object sender, CancelEventArgs e)
        {
            if (txtidentificacion.TextLength < 8)
            {
                validar_error.SetError(txtidentificacion, "Debes ingresar un DNI");
            }
            else
            {
                validar_error.SetError(txtidentificacion, null);
            }
        }

        private void txtapellidopa_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellidopa.TextLength < 3)
            {
                validar_error.SetError(txtapellidopa, "Debes ingresar un apellido");
            }
            else
            {
                validar_error.SetError(txtapellidopa, null);
            }
        }

        private void cnbcargo_Validating(object sender, CancelEventArgs e)
        {
            if (cnbcargo.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbcargo, "Debe eligir un Cargo");
            }
            else
            {
                validar_error.SetError(cnbcargo, null);
            }
            
        }

        private void txtnombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombres.TextLength < 3)
            {
                validar_error.SetError(txtnombres, "Debes ingresar un nombre");
            }
            else
            {
                validar_error.SetError(txtnombres, null);
            }
        }

        private void txtapellidoma_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtapellidoma.TextLength < 3)
            {
                validar_error.SetError(txtapellidoma, "Debes ingresar un apellido materno");
            }
            else
            {
                validar_error.SetError(txtapellidoma, null);
            }
          
        }

        private void txtdireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtdireccion.TextLength < 3)
            {
                validar_error.SetError(txtdireccion, "Debes ingresar una direccion");
            }
            else
            {
                validar_error.SetError(txtdireccion, null);
            }
        }

        private void txttelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txttelefono.TextLength <9)
            {
                validar_error.SetError(txttelefono, "Debes ingresar un numero telefonico");
            }
            else
            {
                validar_error.SetError(txttelefono, null);
            }
           
        }

        private void cnbdistrito_Validating(object sender, CancelEventArgs e)
        {
            if (cnbdistrito.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbdistrito, "Debe eligir un distrito");
            }
            else
            {
                validar_error.SetError(cnbdistrito, null);
            }
        }

        private void checestado_Validating(object sender, CancelEventArgs e)
        {
            if (checestado.Checked == false)
            {
                validar_error.SetError(checestado, "Para crear debe estar activo");
            }
            else
            {
                validar_error.SetError(checestado, null);
            }
        }
    }
}

       
        


