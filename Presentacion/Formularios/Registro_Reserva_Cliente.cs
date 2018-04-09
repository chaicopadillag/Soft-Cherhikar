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
    public partial class Registro_Reserva_Cliente : Form
    {
        Reserva_Cliente_En reser_ent = new Reserva_Cliente_En();
        Reserva_Cliente_Neg reser_neg = new Reserva_Cliente_Neg();
        public Registro_Reserva_Cliente()
        {
            InitializeComponent();
        }
        //private void btnbusca_Reserva_MouseHover(object sender, EventArgs e)
        //{
        //    btnbuscador_Cliente.BackgroundImage = Properties.Resources.bus_car1;
        //}

        private void bntbuscarPorCodigo_MouseHover(object sender, EventArgs e)
        {
            bntbuscarPorCodigo.BackgroundImage = Properties.Resources.bus_car2;
        }
        private void bntbuscarPorCodigo_MouseLeave(object sender, EventArgs e)
        {
            bntbuscarPorCodigo.BackgroundImage = Properties.Resources.bus_car2;
        }

        //private void btnbusca_Reserva_MouseLeave(object sender, EventArgs e)
        //{
        //    btnbuscador_Cliente.BackgroundImage = Properties.Resources.bus_car2;
        //}

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

       
        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void Registro_Reserva_Cliente_Load(object sender, EventArgs e)
        {
            cargarPersonal();
            cargarservicios();
            cargarlistaReserva(); 
            cboCliente.Text = "Buscar cliente----->";

        }
        void colocarcodigoreserva()
        {
            txtReserva.Text = Convert.ToString(reser_neg.coloccar_ultimoCodigo() + 1);
        }
        void cargarPersonal()
        {
            cboNombre.DataSource = reser_neg.Listar_personal();
            cboNombre.DisplayMember = "nombre";
            cboNombre.ValueMember = "codigo";
            cboNombre.Text = "<<Seleccionar>>";

        }
        void cargarservicios()
        {
            cboServicio.DataSource = reser_neg.listar_servicio();
            cboServicio.DisplayMember = "nombre";
            cboServicio.ValueMember = "codigo";
            cboServicio.Text = "<<Seleccionar>>";
        }
        void cargarlistaReserva()
        {
            dgv_listaReserva.DataSource = reser_neg.listar_Reserva();
        }

        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtReserva.Text != "" & cboCliente.Text != "Buscar cliente----->" & cboNombre.Text !=
                   "<<Seleccionar>>" &cbo_placa.Text!=""& cboServicio.Text != "<<Seleccionar>>" &
                   chestado.Checked == true)
            {
                registrarRserva();


            }
            else
            {
                MessageBox.Show("Llenar  los campos obligatorios",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                validarError();
            }
        }


        void BuscarCliente()
        {
            string cod_cli = txtbuscadorCliente.Text;
            if (reser_neg.Buscar_Cliente(cod_cli).Rows.Count > 0)
            {
                cboCliente.DataSource = reser_neg.Buscar_Cliente(cod_cli);
                cboCliente.DisplayMember = "nombre";
                cboCliente.ValueMember = "codigo";
                colocarPlaca();
                ValidarError.Clear();

            }
            else
            {
                MessageBox.Show("El cliente con este codigo no existe", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        ServicioCliente_Neg s = new ServicioCliente_Neg();
        void colocarPlaca()
        {
            string cod_cli = cboCliente.SelectedValue.ToString();
            if (s.Buscar_placa_vehiculo(cod_cli).Rows.Count > 0)
            {
                cbo_placa.DataSource = s.Buscar_placa_vehiculo(cod_cli);
                cbo_placa.DisplayMember = "placa_vehiculo";
                cbo_placa.ValueMember = "placa_vehiculo";

            }
            else
            {
                MessageBox.Show("El vehiculo del cliente a un no se registrado", "Soft Cherhikcar V1.0",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnbusca_Reserva_MouseClick(object sender, MouseEventArgs e)
        {


            if (txtbuscadorCliente.Text == "")
            {
                MessageBox.Show("Ingrese el codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BuscarCliente();
            }
        }


        void registrarRserva()
        {
            reser_ent.codigo = Convert.ToInt32(txtReserva.Text);
            reser_ent.cod_client = cboCliente.SelectedValue.ToString();
            reser_ent.nombre = cboNombre.SelectedValue.ToString();
            reser_ent.cod_servicio = Convert.ToInt32(cboServicio.SelectedValue);
            reser_ent.hora = Convert.ToDateTime(hora.Text);
            reser_ent.fecha = Convert.ToDateTime(fecha.Text);
            reser_ent.placa = cbo_placa.SelectedValue.ToString();
            reser_ent.estado = chestado.Checked;
            if (MessageBox.Show("¿Quieres guardar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (reser_neg.RegistrarReserva(reser_ent) > 0)
                {
                    MessageBox.Show("Reserva Nº RS0"+reser_ent.codigo+" guardado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarlistaReserva();
                    grup_datos.Enabled = false;
                    limpiar();
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;
                    btncancelar.Enabled = false;
                    ValidarError.Clear();

                }
                else
                {
                    MessageBox.Show("Error al guardar la reserva", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }

        private void btneliminar_MouseClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    int indiceFila = dgv_listaReserva.CurrentCell.RowIndex;
            //    DataGridViewRow row = dgv_listaReserva.Rows[indiceFila];

            //    //Disminuir el totalPAgado
            //    double total = 0;
            //    total = Convert.ToDouble(txtbucarReservaMant.Text) - Convert.ToDouble(row.Cells[3].Value);

            //    txtbucarReservaMant.Text = total.ToString("#0.00#");
            //    //Removemos la fila
            //    dgv_listaReserva.Rows.Remove(row);
            //    //colocar_orden();


            //}
            //catch
            //{
            //    MessageBox.Show("No hay lista detalle para quitar", "Soft Cherhikcar V1.0",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
         
            grup_datos.Enabled = false;
            limpiar();
            ValidarError.Clear();
            btncancelar.Enabled = false;
            btnguardar.Enabled = false;
            btnnuevo.Enabled = true;
        }

        private void bntbuscarPorCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            int cod = Convert.ToInt32(txtbuscadorCliente.Text);
            if (txtbuscadorCliente.Text != "")
            {
                if (reser_neg.buscar_reserva_cliente(cod).Rows.Count > 0)
                {

                    dgv_listaReserva.DataSource = reser_neg.buscar_reserva_cliente(cod);
                }
                else
                {
                    MessageBox.Show("El cliente con este DNI no existe", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ingrese el DNI para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {
       
            grup_datos.Enabled = true;
            limpiar();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            colocarcodigoreserva();
        }
        void limpiar()
        {          
            txtbuscadorCliente.Clear();
            txtbucarReservaMant.Clear();
            cargarlistaReserva();
            cargarPersonal();
            cargarservicios();
            txtReserva.Clear();
            cboCliente.Text = "Buscar cliente----->";
            cbo_placa.DataSource = null;
            chestado.Checked = false;
        }
        public void validarError()
        {
            if (txtReserva.Text == "")
            {
                ValidarError.SetError(txtReserva, "Ingrese el numero");
            }
            if (cboCliente.Text == "Buscar cliente----->")
            {
                ValidarError.SetError(cboCliente, "Debe buscar a un cliente");
            }
            if (cboNombre.Text =="<<Seleccionar>>")
            {
                ValidarError.SetError(cboNombre, "Seleccione un personal");
            }
            if (chestado.Checked == false)
            {
                ValidarError.SetError(chestado, "Debe estar activo para guardar");
            }
            if (cboServicio.Text == "<<Seleccionar>>")
            {
                ValidarError.SetError(cboServicio, "Seleccione un servicio");
            }
            if (cbo_placa.Text =="")
            {
                ValidarError.SetError(cbo_placa, "Ingrese la placa del vehiculo");
            }
        }
        private void cboCliente_Validating(object sender, CancelEventArgs e)
        {
            if (cboCliente.Text == "")
            {
                ValidarError.SetError(cboCliente, "Debe buscar un cliente");
            }
            else
            {
                ValidarError.SetError(cboCliente, null);
            }
        }
        private void cboNombre_Validating(object sender, CancelEventArgs e)
        {
            if (cboNombre.Text == "<<Seleccionar>>")
            {
                ValidarError.SetError(cboNombre, "Ingrese Nombre Personal");
            }
            else
            {
                ValidarError.SetError(cboNombre, null);
            }
        }

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                ValidarError.SetError(chestado, "Debe estar activo para guardar");
            }
            else
            {
                ValidarError.SetError(chestado, null);
            }
        }
        private void cboServicio_Validating(object sender, CancelEventArgs e)
        {
            if (cboServicio.Text == "<<Seleccionar>>")
            {
                ValidarError.SetError(cboServicio, "Ingrese el nombre del servicio");
            }
            else
            {
                ValidarError.SetError(cboServicio, null);
            }
        }

        private void cbo_placa_Validating(object sender, CancelEventArgs e)
        {
            if (cbo_placa.Text =="")
            {
                ValidarError.SetError(cbo_placa, "Ingrese la placa del vehiculo");
            }
            else
            {
                ValidarError.SetError(cbo_placa, null);
            }
        }

        private void btnbuscarporCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscadorCliente.Text == "Buscar cliente----->")
            {
                MessageBox.Show("Ingrese un identificacion para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                string cod= txtbuscadorCliente.Text;

            if (reser_neg.Buscar_Cliente(cod).Rows.Count > 0)
            {
                cboCliente.DataSource = reser_neg.Buscar_Cliente(cod);
                cboCliente.DisplayMember = "nombre";
                cboCliente.ValueMember = "codigo";
                txtbuscadorCliente.Clear();
                cargarPlaca();
            }
            else
            {
                MessageBox.Show("El cliente que busca no existe", "Soft Cherhikcar V1.0",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
         
        ServicioCliente_Neg n = new ServicioCliente_Neg();
        void cargarPlaca()
        {
            if (n.Buscar_placa_vehiculo(txtbuscadorCliente.Text).Rows.Count > 0)
            {
                cbo_placa.DataSource = n.Buscar_placa_vehiculo(txtbuscadorCliente.Text);
                cbo_placa.DisplayMember = "placa_vehiculo";
                cbo_placa.ValueMember = "placa_vehiculo";
            }
            else
            {
                MessageBox.Show("El cliente no tiene ningun vehículo registrado", "Soft Cherhikcar V1.0",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnguardar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chestado_Validating_1(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                ValidarError.SetError(chestado, "Debe estar activo para guardar");
            }
            else
            {
                ValidarError.SetError(chestado, null);

            }
        }

        private void cbo_placa_Validating_1(object sender, CancelEventArgs e)
        {
            if (cbo_placa.Text == "")
            {
                ValidarError.SetError(cbo_placa, "Busca el cliente para visualizar las placas");
            }
            else
            {
                ValidarError.SetError(cbo_placa,null);
            
           }
        }

        private void cboNombre_Validating_1(object sender, CancelEventArgs e)
        {
            if (cboNombre.Text == "<<Seleccionar>>")
            {
                ValidarError.SetError(cboNombre, "Seleccione un personal");
            }
            else
            {

                ValidarError.SetError(cboNombre, null);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtbuscadorCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }

        private void btn_imprimir_bol_Click(object sender, EventArgs e)
        {
            PRESENTACION.Mantenimiento_Registro_Clientes c = new PRESENTACION.Mantenimiento_Registro_Clientes();
            c.ShowDialog();
        }

        private void btn_imprimir_fac_Click(object sender, EventArgs e)
        {
            Registro_vehiculo v = new Registro_vehiculo();
            v.ShowDialog();
        }
    }
    }






