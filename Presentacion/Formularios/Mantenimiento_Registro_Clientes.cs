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

namespace PRESENTACION
{
    public partial class Mantenimiento_Registro_Clientes : Form
    {
        public Mantenimiento_Registro_Clientes()
        {
            InitializeComponent();
        }
        Cliente_Neg Pro = new Cliente_Neg();
        Cliente_EN Ent = new Cliente_EN();
        //creacion de metodos para la lista de datos para los combos
        public void ListaDistrito()
        {
            cbodistrito.DataSource = Pro.ListaDistritoR();
            cbodistrito.DisplayMember = "nombre_distrito";
            cbodistrito.ValueMember = "id_distrito";           
        }
        public void ListaTipoCliente()
        {
            cbotipocliente.DataSource = Pro.ListaTipoClienteR();
            cbotipocliente.DisplayMember = "nombre_tipocliente";
            cbotipocliente.ValueMember = "id_tipocliente";
          
        }

        public void ListaPersonale()
        {
                cbopersonal.DataSource = Pro.ListaPersonalR();
                cbopersonal.DisplayMember = "nombre";
                cbopersonal.ValueMember = "codigo";            
        }
        public void ListaClientes()
        {
            dgListaClientes.DataSource = Pro.ListaClienteR();
        }



        private void Mantenimiento_Registro_Clientes_Load(object sender, EventArgs e)
        {
            ListaClientes();
            ListaDistrito();
            cbodistrito.Text = "<<Seleccionar>>";
            ListaPersonale();
            cbopersonal.Text = "<<Seleccionar>>";
            ListaTipoCliente();
            cbotipocliente.Text = "<<Seleccionar>>";
        }

        private void btnguardar_Paint(object sender, PaintEventArgs e)
        {

            //if (txtBuscarClientes.Text == "" & txtnombre.Text == "" & txtapellidopaterno.Text == "" & txtapellidomaterno.Text == "" &
            //   txtdireccion.Text == "" & txttelefono.Text == "" & cbodistrito.Text == "<<Seleccionar>>" &
            //   cbopersonal.Text == "<<Seleccionar>>" & cbotipocliente.Text == "<<Seleccionar>>")
            //{
            //    MessageBox.Show("Llena correctamente los campos guardar", "Soft Cherhikcar V1.0",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else {
            //    DialogResult R = MessageBox.Show("Desea guardar", "Soft Cherhikcar V1.0",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (R == DialogResult.Yes)
            //    {

            //        Ent.Codigo = txtBuscarClientes.Text;
            //        Ent.Nombre = txtnombre.Text;
            //        Ent.ApellidoPaterno = txtapellidopaterno.Text;
            //        Ent.ApellidoMaterno = txtapellidomaterno.Text;
            //        Ent.Direccion = txtdireccion.Text;
            //        Ent.Telefono = txttelefono.Text;
            //        Ent.Distrito = Convert.ToInt32(cbodistrito.SelectedValue);
            //        Ent.TipoCliente = Convert.ToInt32(cbotipocliente.SelectedValue);
            //        Ent.Personal = Convert.ToString(47875537);
            //        Ent.ESTADO = Convert.ToBoolean(chEstado.Checked);

            //        bool resul = new ClienteR().InsertarClienteR(Ent);
            //        if (resul == true)
            //        {
            //            MessageBox.Show("El cliente se  registrado correctamente");

            //        }
            //        else
            //        {
            //            MessageBox.Show("Debe llenar todo los datos pedidos y/o ya existe el cliente");
            //        }

            //    }
            //}
        }






        private void bntbuscarPorCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarClientes.Text == "")
            {
                MessageBox.Show("Ingresa un Identificacion",
                    "Soft Cherhikcar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                Ent.Codigo = txtBuscarClientes.Text;
                if (Pro.BuscarCliente(Ent) > 0)
                {
                    ListaPersonale();
                    ListaTipoCliente();
                    ListaDistrito();
                    txtBuscarClientes.Text = Ent.Codigo;
                    txtdni.Text = Ent.Codigo;
                    txtnombre.Text = Ent.Nombre;
                    txtapellidopaterno.Text = Ent.ApellidoPaterno;
                    txtapellidomaterno.Text = Ent.ApellidoMaterno;
                    txtdireccion.Text = Ent.Direccion;
                    txttelefono.Text = Ent.Telefono;
                    cbodistrito.SelectedValue = Ent.Distrito;
                    cbotipocliente.SelectedValue = Ent.TipoCliente;
                    cbopersonal.SelectedValue = Ent.Personal;

                    chEstado.Checked = Ent.ESTADO;

                    btncancelar.Enabled = true;
                    btnEditar.Enabled = true;
                    btneliminar.Enabled = true;
                    btnnuevo.Enabled = false;
                    grupdatos.Enabled = true;
                    txtBuscarClientes.Clear();
                    groupBox3.Enabled = false;
                    validar_error.Clear();
                }


                else
                {
                    MessageBox.Show("El cliente que buscas no existe",
                        "Soft Cherhikcar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {

            Limpiar();
            btnguardar.Enabled = true;
            grupdatos.Enabled = true;
            btnnuevo.Enabled = false;
            groupBox3.Enabled = false;
            btncancelar.Enabled = true;
            txtdni.Focus();
            validar_error.Clear();



        }
        void Limpiar()
        {
            txtBuscarClientes.Text = "";
            txtdni.Clear();
            txtnombre.Text = "";
            txtapellidopaterno.Text = "";
            txtapellidomaterno.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";

            ListaDistrito();
            cbodistrito.Text = "<<Seleccionar>>";
            ListaTipoCliente();
            cbotipocliente.Text = "<<Seleccionar>>";
            ListaPersonale();
            cbopersonal.Text = "<<Seleccionar>>";
            chEstado.Checked = false;

        }

        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtdni.TextLength < 8 || txtnombre.TextLength < 3 || txtapellidopaterno.TextLength < 4 ||
              txtapellidomaterno.TextLength < 4 || txtdireccion.Text == "" || txttelefono.Text == ""
             || cbodistrito.Text == "<<Seleccionar>>" || cbopersonal.Text == "<<Seleccionar>>"
             || cbotipocliente.Text == "<<Seleccionar>>" || chEstado.Checked == false)
            {
                MessageBox.Show("Llena correctamente los campos",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validartexbox();
            }
            else
            {
                DialogResult R = MessageBox.Show(" ¿ Desea guardar ? ", "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {

                    Ent.Codigo = txtdni.Text;
                    Ent.Nombre = txtnombre.Text;
                    Ent.ApellidoPaterno = txtapellidopaterno.Text;
                    Ent.ApellidoMaterno = txtapellidomaterno.Text;
                    Ent.Direccion = txtdireccion.Text;
                    Ent.Telefono = txttelefono.Text;
                    Ent.Distrito = Convert.ToInt32(cbodistrito.SelectedValue);
                    Ent.TipoCliente = Convert.ToInt32(cbotipocliente.SelectedValue);
                    Ent.Personal = cbopersonal.SelectedValue.ToString();
                    Ent.ESTADO = chEstado.Checked;

                    bool resul = Pro.InsertarClienteR(Ent);
                    if (resul == true)
                    {
                        MessageBox.Show("El cliente se  registrado correctamente", "Soft Cherhikcar V1.0",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        groupBox3.Enabled = true;
                        Limpiar();                       
                        btnnuevo.Enabled = true;
                        ListaClientes();
                        grupdatos.Enabled = false;                
                        btncancelar.Enabled = false;
                        btneliminar.Enabled = false;
                        btnEditar.Enabled = false;
                        validar_error.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Error al guardar", "Soft Cherhikcar V1.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

        }
        void EliminarClientes()
        {


            if (MessageBox.Show("¿ Desea eliminar ?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ent.Codigo = txtdni.Text;

                if (Pro.EliminarClienteR(Ent) > 0)

                {
                    MessageBox.Show("Se elimino correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaClientes();
                    btneliminar.Enabled = true;
                    btnEditar.Enabled = true;                  
                    Limpiar();
                    groupBox3.Enabled = true;
                    Limpiar();                
                    btnnuevo.Enabled = true;                 
                    grupdatos.Enabled = false;
                    btncancelar.Enabled = false;
                    validar_error.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        }

        private void btneliminar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtdni.TextLength < 8)
            {
                MessageBox.Show("Ingrese una identificacion para eliminar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EliminarClientes();
            }

        }

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
            grupdatos.Enabled = false;
            btnEditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            btnnuevo.Enabled = true;
            Limpiar();    
            txtdni.Clear();
            validar_error.Clear();
            groupBox3.Enabled = true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


        }
        void validartexbox()
        {
            if (chEstado.Checked == false)
            {
                validar_error.SetError(chEstado, "Activa el estado para guardar pedido");
            }
            if (cbodistrito.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbodistrito, "Seleccione un distrito");
            }
            if (cbotipocliente.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbotipocliente, "Seleccione un tipocliente");
            }
            if (cbopersonal.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbopersonal, "Seleccione un personal");
            }
            if (txttelefono.Text == "")
            {
                validar_error.SetError(txttelefono, "Ingrese telefono");
            }
            if (txtdireccion.Text == "")
            {
                validar_error.SetError(txtdireccion, "Ingrese direccion");
            }
            if (txtapellidopaterno.TextLength < 4)
            {
                validar_error.SetError(txtapellidopaterno, "Ingrese apellido");
            }
            if (txtapellidomaterno.TextLength < 4)
            {
                validar_error.SetError(txtapellidomaterno, "Ingrese apellido");
            }
            if (txtdni.TextLength < 8)
            {
                validar_error.SetError(txtdni, "Minimio ocho carácteres");

            }
            if (txtnombre.TextLength < 3)
            {
                validar_error.SetError(txtnombre, "Ingrese un nombre");
            }
        }


        private void chEstado_Validating(object sender, CancelEventArgs e)
        {
            if (chEstado.Checked == false)
            {
                validar_error.SetError(chEstado, "Activa el estado para guardar pedido");
            }
            else
            {
                validar_error.SetError(chEstado, null);
            }
        }

        private void cbodistrito_Validating(object sender, CancelEventArgs e)
        {
            if (cbodistrito.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbodistrito, "Seleccione un distrito");
            }
            else
            {
                validar_error.SetError(cbodistrito, null);
            }
        }

        private void cbotipocliente_Validating(object sender, CancelEventArgs e)
        {
            if (cbotipocliente.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbotipocliente, "Seleccione un tipocliente");
            }
            else
            {
                validar_error.SetError(cbotipocliente, null);
            }
        }

        private void cbopersonal_Validating(object sender, CancelEventArgs e)
        {
            if (cbopersonal.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbopersonal, "Seleccione un personal");
            }
            else
            {
                validar_error.SetError(cbopersonal, null);
            }
        }



        private void btnEditar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtdni.TextLength < 8 || txtnombre.TextLength < 3 || txtapellidopaterno.TextLength < 4 ||
              txtapellidomaterno.TextLength < 4 || txtdireccion.Text == "" || txttelefono.Text == ""
             || cbodistrito.Text == "<<Seleccionar>>" || cbopersonal.Text == "<<Seleccionar>>"
             || cbotipocliente.Text == "<<Seleccionar>>" || chEstado.Checked == false)
            {
                MessageBox.Show("Llena correctamente los campos", "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validartexbox();
            }

            else
            {
                DialogResult R = MessageBox.Show("¿ Desea Actualizar ?", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {

                    Ent.Codigo = txtdni.Text;
                    Ent.Nombre = txtnombre.Text;
                    Ent.ApellidoPaterno = txtapellidopaterno.Text;
                    Ent.ApellidoMaterno = txtapellidomaterno.Text;
                    Ent.Direccion = txtdireccion.Text;
                    Ent.Telefono = txttelefono.Text;
                    Ent.Distrito = Convert.ToInt32(cbodistrito.SelectedValue);
                    Ent.TipoCliente = Convert.ToInt32(cbotipocliente.SelectedValue);
                    Ent.Personal = cbopersonal.SelectedValue.ToString();
                    Ent.ESTADO = chEstado.Checked;

                    if (Pro.ActualizarClienteR(Ent) > 0)
                    {
                        MessageBox.Show("Se actualizo correctamente",
                            "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                        groupBox3.Enabled = true;
                        ListaClientes();
                        Limpiar();
                        groupBox3.Enabled = true;             
                        btnnuevo.Enabled = true;                     
                        grupdatos.Enabled = false;
                        btncancelar.Enabled = false;
                        btneliminar.Enabled = false;
                        btnEditar.Enabled = false;
                        validar_error.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnnuevo_MouseHover(object sender, EventArgs e)
        {
            btnnuevo.BackgroundImage = Presentacion.Properties.Resources.nuevo2;
        }



        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

                return;

            }
        }


        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;


            }
        }

        private void txtapellidopaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

                return;

            }
        }

        private void txtapellidomaterno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;


                return;

            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;


                return;


            }
        }

        private void txtBuscarClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;


                return;


            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdni_Validating(object sender, CancelEventArgs e)
        {
            if (txtdni.TextLength < 8)
            {
                validar_error.SetError(txtdni, "Minimio ocho carácteres");

            }
            else
            {
                validar_error.SetError(txtdni, null);
            }
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombre.TextLength < 3)
            {
                validar_error.SetError(txtnombre, "Ingrese un nombre");
            }
            else
            {
                validar_error.SetError(txtnombre, null);
            }

        }

        private void txtapellidopaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellidopaterno.TextLength < 4)
            {
                validar_error.SetError(txtapellidopaterno, "Ingrese apellido");
            }
            else
            {
                validar_error.SetError(txtapellidopaterno, null);
            }
        }

        private void txtapellidomaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtapellidomaterno.TextLength < 4)
            {
                validar_error.SetError(txtapellidomaterno, "Ingrese apellido");
            }
            else
            {
                validar_error.SetError(txtapellidomaterno, null);
            }
        }

        private void txttelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txttelefono.Text == "")
            {
                validar_error.SetError(txttelefono, "Ingrese telefono");
            }
            else
            {
                validar_error.SetError(txttelefono, null);
            }

        }

        private void txtdireccion_Validating(object sender, CancelEventArgs e)
        {

            if (txtdireccion.Text == "")
            {
                validar_error.SetError(txtdireccion, "Ingrese direccion");
            }
            else
            {
                validar_error.SetError(txtdireccion, null);
            }

        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Presentacion.Properties.Resources.Cancel1;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Presentacion.Properties.Resources.Cancel;
        }

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Presentacion.Properties.Resources.eliminar2;
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Presentacion.Properties.Resources.eliminar;
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackgroundImage = Presentacion.Properties.Resources.modific2;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackgroundImage = Presentacion.Properties.Resources.modificar;
        }

        private void btnguardar_MouseHover(object sender, EventArgs e)
        {
            btnguardar.BackgroundImage = Presentacion.Properties.Resources.guardar2;
        }

        private void btnguardar_MouseLeave(object sender, EventArgs e)
        {
            btnguardar.BackgroundImage = Presentacion.Properties.Resources.guardar;
        }

        private void btnnuevo_MouseLeave(object sender, EventArgs e)
        {
            btnnuevo.BackgroundImage = Presentacion.Properties.Resources.nuevo;
        }

        private void grupdatos_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bntbuscarPorCodigo_MouseHover(object sender, EventArgs e)
        {
            bntbuscarPorCodigo.BackgroundImage = Presentacion.Properties.Resources.busc;
        }

        private void bntbuscarPorCodigo_MouseLeave(object sender, EventArgs e)
        {
            bntbuscarPorCodigo.BackgroundImage = Presentacion.Properties.Resources.buca2;
        }
    }
}
