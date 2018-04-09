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
    public partial class frm_Servicios : Form
    {
        Servicio_En ser = new Servicio_En();
        Servicio_Neg ser_neg = new Servicio_Neg();

        public frm_Servicios()
        {
            InitializeComponent();
        }
        void cargar_cod_servcio()
        {
            int n= ser_neg.Cargar_Codigo()+1;
            txtnum_serv.Text = n.ToString();
        }
        private void Registrar_Servicios_Cliente_Load(object sender, EventArgs e)
        {
           
            cargarListaServicio();

        }
        void registrarServicio()
        {
            ser.codigo = Convert.ToInt32(txtnum_serv.Text);
            ser.precio = Convert.ToDouble(txtprecio.Text);
            ser.Nom_servicio = txtNombreServ.Text;
            ser.discripcion = txtdescricion.Text;
            ser.estado = chestado.Checked;
            if (MessageBox.Show("¿ Estas seguro que quieres guardar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ser_neg.Registar_servicios(ser) > 0)
                {
                    MessageBox.Show("El servicio de ''" + ser.Nom_servicio + "'' se ha guardado correctamente",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaServicio();
                    grup_datos.Enabled = false;
                    limpiar();
                    btnguardar.Enabled = false;
                    btncancelar.Enabled = false;
                    btnnuevo.Enabled = true;
                    gropBuscar.Enabled = true;
                    ValidarError.Clear();
                    grup_datos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al guardar codigo sericio ''" + ser.codigo + "''", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }
        void limpiar()
        {
            
            txtnum_serv.Clear();
            txtprecio.Clear();
            txtNombreServ.Clear();
            txtbuscar.Clear();
            txtdescricion.Clear();
            chestado.Checked = false;
            cargarListaServicio();


        }
        void cargarListaServicio()
        {
            dgv_servicios.DataSource = ser_neg.ListarServicio();
        }

        private void btnbuscarCliente_MouseHover(object sender, EventArgs e)
        {
            btnbuscarCliente.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnbuscarCliente.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnbuscarplaca_MouseHover(object sender, EventArgs e)
        {
            btnbuscarporCodigo.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscarplaca_MouseLeave(object sender, EventArgs e)
        {
            btnbuscarporCodigo.BackgroundImage = Properties.Resources.buca2;
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

        private void btneliminar_MouseHover(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Properties.Resources.eliminar2;
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.BackgroundImage = Properties.Resources.eliminar;
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {
            grup_datos.Enabled = true;
            nuevo();
            btnguardar.Enabled = true;
            btnnuevo.Enabled = false;
            gropBuscar.Enabled = false;
            cargar_cod_servcio();
            btncancelar.Enabled = true;
        }
        void nuevo()
        {
            txtbuscaServicio.Text = "";
            txtnum_serv.Clear();
            txtNombreServ.Text = "";
            txtprecio.Clear();
            txtdescricion.Clear();
            txtbuscar.Clear();
            cargarListaServicio();
            chestado.Checked = false;

        }
        
        private void btnbuscarCliente_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtbuscar.Text == "")
            {
                MessageBox.Show("Ingrese  un  codigo para buscar", "Soft Cherhikcar V1.0",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                buscarservicio();
            }
        }



        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNombreServ.Text != "" &&
              txtprecio.Text != "" && txtdescricion.Text != "" && chestado.Checked == true)
            {
                registrarServicio();
            }
            else
            {
                MessageBox.Show("Llena los campos correctamente para guardar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                validar();

            }
        }

        private void btneliminar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtnum_serv.Text == "")
            {
                MessageBox.Show("Ingrese un codigo para eliminar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Quieres Elimianar ?", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eliminar_servicio();
                }
                else
                {

                }
            }

        }
        void eliminar_servicio()
        {
            int n = Convert.ToInt32(txtnum_serv.Text);
            ser.codigo = n;
            if (ser_neg.Eliminar_servicio(ser) > 0)
            {
                MessageBox.Show("Se elimino correctamente", "Soft Cherhikcar V1.0",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnnuevo.Enabled = true;
                btneliminar.Enabled = false;
                btncancelar.Enabled = true;
                btnmodificar.Enabled = false;
                gropBuscar.Enabled = true;
                limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
            grup_datos.Enabled = false;
            gropBuscar.Enabled = true;
            nuevo();
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false; ;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            txtbuscar.Focus();
            btncancelar.Enabled = false;
            ValidarError.Clear();
        }
        void buscarservicio()
        { ser.codigo = Convert.ToInt32(txtbuscar.Text);
            if (ser_neg.buscar_servicio(ser) > 0)
            {
                txtnum_serv.Text = ser.codigo.ToString();
                txtprecio.Text = ser.precio.ToString();
                txtNombreServ.Text = ser.Nom_servicio.ToString();
                txtdescricion.Text = ser.discripcion.ToString();
                chestado.Checked = ser.estado;
                grup_datos.Enabled = true;
                gropBuscar.Enabled = false;
                txtbuscar.Clear();
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;btnnuevo.Enabled = false;
                btncancelar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El servicio con este codigo no existe", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                grup_datos.Enabled = false;
            }
        }
        private void btnbuscarplaca_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (txtbuscaServicio.Text != "")
            {int cod = Convert.ToInt32(txtbuscaServicio.Text);
                if (ser_neg.buscar_servicio(cod).Rows.Count > 0)
                {

                    dgv_servicios.DataSource = ser_neg.buscar_servicio(cod);
                }
                else
                {
                    MessageBox.Show("El Servicio con este codigo no existe",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscaServicio.Clear();

                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtnum_serv_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_MouseHover(object sender, EventArgs e)
        {
            btnmodificar.BackgroundImage = Properties.Resources.modific2;
        }

        private void btnmodificar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtnum_serv.Text != "" & txtprecio.Text != "" & txtNombreServ.Text !=
               "" & txtdescricion.Text != "" &
               chestado.Checked == true)
            {
                modificarveh();

            }
            else
            {
                MessageBox.Show("Ingrese datos para modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar();
            }

        }
        void modificarveh()
        {
            ser.codigo = Convert.ToInt32(txtnum_serv.Text);
            ser.Nom_servicio = txtNombreServ.Text;
            ser.precio = Convert.ToDouble(txtprecio.Text);
            ser.discripcion = txtdescricion.Text;
            ser.estado = chestado.Checked;
            if (MessageBox.Show("¿ Quieres modificar el registro ?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ser_neg.ModificarServicio(ser) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaServicio();
                    grup_datos.Enabled = false;
                    limpiar();
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                    btncancelar.Enabled = false;
                    gropBuscar.Enabled = true;
                    btnnuevo.Enabled = true;
                    ValidarError.Clear();
                }
                else
                {
                    MessageBox.Show("Error al modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                btnmodificar.Enabled = true;

            }

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtnum_serv_Validating(object sender, CancelEventArgs e)
        {

        }
        public void validar()
        {
            if (txtnum_serv.Text == "")
            {
                ValidarError.SetError(txtnum_serv, "ingrese solo numero");
            }

            if (txtNombreServ.Text == "")
            {
                ValidarError.SetError(txtNombreServ, "ingrese un nombre del servicio");
            }

            if (chestado.Checked == false)
            {
                ValidarError.SetError(chestado, "Debe estar activo para guardar");
            }

            if (txtdescricion.Text == "")
            {
                ValidarError.SetError(txtdescricion, "Ingrese la descripcion");
            }

            if (txtprecio.Text == "")
            {
                ValidarError.SetError(txtprecio, "Ingrese el precio");
            }
        }
        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if(chestado.Text=="")
            {
                ValidarError.SetError(chestado, "Debe estar activo para guardar"); 
            }
            else
            {
                ValidarError.SetError(chestado, null);
            }
        }

        private void txtNombreServ_Validating(object sender, CancelEventArgs e)
        {
            if(txtNombreServ.Text=="")
            {
                ValidarError.SetError(txtNombreServ, "ingrese un nombre del servicio");

            }
            else
            {
                ValidarError.SetError(txtNombreServ, null);
            }
        }

        private void txtprecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtprecio.Text == "")
            {
                ValidarError.SetError(txtprecio, "Ingrese el precio");
            }
            ValidarError.SetError(txtprecio, null);
        }

        private void txtdescricion_Validating(object sender, CancelEventArgs e)
        {
            if(txtdescricion.Text=="")
            {
                ValidarError.SetError(txtdescricion, "Ingrese la descripcion");
            }
            ValidarError.SetError(txtdescricion, null);
        }

        private void grup_datos_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombreServ_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }
        Validacion_texbox v = new Validacion_texbox();

        private void txtdescricion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void btnmodificar_MouseLeave(object sender, EventArgs e)
        {
            btnmodificar.BackgroundImage = Properties.Resources.modificar;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.Solo_Numeros(e);
        }

        private void txtbuscaServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }
    }
}

    
    
  

