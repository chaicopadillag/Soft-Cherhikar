using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//insertar
using Negocio;
using Entidad;
namespace Presentacion
{
    public partial class Comprobante_Pago : Form
    {
        Boleta_Neg b = new Boleta_Neg();
        Reserva_Cliente_Neg v = new Reserva_Cliente_Neg();
        Boleta_En boletaEn = new Boleta_En();
        Factura_Neg f = new Factura_Neg();
        Factura_En facturaEn = new Factura_En();
        DetalleBoleta_En dtb = new DetalleBoleta_En();
        DetalleFactura_En dtf = new DetalleFactura_En();
        Validacion_texbox va = new Validacion_texbox();
        Pedido_Neg p = new Pedido_Neg();
        ServicioCliente_Neg s = new ServicioCliente_Neg();
        //modificado


        public Comprobante_Pago()
        {
            InitializeComponent();
        }
        //cargar datos factura
        void cargarcodFactura()
        {
            int cod = f.colocarcodFactura() + 1;
            txtnum_comprobante.Text = Convert.ToString(cod);
        }
        //cargar datos boleta
        void cargarcliente()
        {           
            cboclientes.Text = "<<buscar cliente----->>";
        }
        void cargarpersonal()
        {
            cbopersonal.DataSource = b.Lista_Personal();
            cbopersonal.DisplayMember = "nombre";
            cbopersonal.ValueMember = "codigo";
            cbopersonal.Text = "<<Seleccionar>>";
        }
        void cargarcodBoleta()
        {
            int cod = b.colocarcodboleta() + 1;
            txtnum_comprobante.Text = Convert.ToString(cod);
        }
        void cargarlistaboletas()
        {
            if (b.Lista_boleta().Rows.Count > 0)
            {
                dglistafacturas.DataSource = b.Lista_boleta();
            }
            else
            {
                MessageBox.Show("Error en cargar la lista de boletas",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void cargarlistafacturas()
        {
            if (f.Lista_Factura().Rows.Count > 0)
            {
                dglistafacturas.DataSource = f.Lista_Factura();

            }
            else
            {
                MessageBox.Show("Error al cargar lista de facturas",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //void cargartipopago()
        //{
        //    cbopagos.DataSource = b.Lista_TipoPago();
        //    cbopagos.DisplayMember = "pago";
        //    cbopagos.ValueMember = "codigo";
        //    cbopagos.Text = "<<seleccione pago>>";
        //}

        private void btnnuevo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {

            grupcomprobante.Enabled = true;
            limpiar();
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            validar_error.Clear();

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

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {   limpiar();           
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;          
            btnnuevo.Enabled = true;       
            grupcomprobante.Enabled = false;          
            grupbuscapedido.Enabled = false;
            grupbuscarservicio.Enabled = false;
            btncalcular.Enabled = false;
            rboboleta.Checked = false;
            rbofactura.Checked = false;            
            grup_Datos.Enabled = false;
            validar_error.Clear();
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rboboleta.Checked == true)
            {
                limpiar();
                cargarcodBoleta();
                grup_Datos.Enabled = true;
                grup_buscar.Enabled = true;
                txtbuscarcliente.Focus();
                txtruc.Enabled = false;
                grupbuscapedido.Enabled = true;
                grupbuscarservicio.Enabled = true;                
                cargarpersonal();
                cargarcliente();
                validar_error.Clear();
                btncalcular.Enabled = true;
                int numpe = p.cargarUltimoCodigoPedido();
                txtnumpedido.Text = numpe.ToString();
                int numserv = s.Cargar_Mayor_Codigo();
                txtnumservicio.Text = numserv.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbofactura.Checked == true)
            {
                limpiar();
                cargarcodFactura();
                grup_Datos.Enabled = true;
                grup_buscar.Enabled = true;
                txtbuscarcliente.Focus();
                txtruc.Enabled = true;
                grupbuscapedido.Enabled = true;
                grupbuscarservicio.Enabled = true;
                btncalcular.Enabled = true;
                cargarpersonal();
                int numpe = p.cargarUltimoCodigoPedido();
                txtnumpedido.Text = numpe.ToString();
                int numserv = s.Cargar_Mayor_Codigo();
                txtnumservicio.Text = numserv.ToString();
                validar_error.Clear();
            }

        }

        private void Comprobante_Pago_Load(object sender, EventArgs e)
        {
            cargarcliente();
            cargarpersonal();
            //cargartipopago();
            txtmontototal.Focus();
            cbocomprobante.Text = "<<Seleccionar>>";
        }


        void limpiar()
        { //--12
            txtbuscarcliente.Clear();
            txtnum_comprobante.Clear();
            txtruc.Clear();
            txtmontototal.Clear();
            txtigv.Clear();
            txtsubtotal.Clear();
            fecha.Text = "";
            cargarpersonal();
            chestado.Checked = false;
            dgpedidos.DataSource = null;
            dgservicios.DataSource = null;
            txtnumservicio.Clear();
            txtnumpedido.Clear();
            cboclientes.DataSource = null;
            cargarcliente();          
        }
        void calcular_monto_totalFactura()
        {
            double cal_igv=0;
            double subttottal;
            double montototal;
            double pedido = calcular_Total_pedido();
            double servicio = calcular_Total_Servicio();
            double igv = 0.18;
            if (pedido == 0)
            {
                cal_igv = servicio * igv;
                txtigv.Text = cal_igv.ToString("#00.00#");
                subttottal =  servicio;
                txtsubtotal.Text = subttottal.ToString("#00.00#");
                montototal = subttottal + cal_igv;
                txtmontototal.Text = montototal.ToString("#00.00#");
            }
            else if (servicio == 0)
            {
                cal_igv = pedido * igv;
                txtigv.Text = cal_igv.ToString("#00.00#");
                subttottal = pedido ;
                txtsubtotal.Text = subttottal.ToString("#00.00#");
                montototal = subttottal + cal_igv;
                txtmontototal.Text = montototal.ToString("#00.00#");
            }
            else
            {
                cal_igv = (pedido + servicio) * igv;
                txtigv.Text = cal_igv.ToString("#00.00#");
                subttottal = pedido + servicio;
                txtsubtotal.Text = subttottal.ToString("#00.00#");
                montototal = subttottal + cal_igv;
                txtmontototal.Text = montototal.ToString("#00.00#");

            }
           

        }
        void calcular_monto_totalBoleta()
        {
            double montototal;
            double pedido = calcular_Total_pedido();
            double servicio = calcular_Total_Servicio();
            montototal = pedido + servicio;
            txtmontototal.Text = montototal.ToString("#00.00#");

        }
        public double calcular_Total_pedido()
        {
            double total_pedido = 0;
            if (dgpedidos.DataSource != null)
            {
                if (dgpedidos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgpedidos.Rows)
                {
                    total_pedido += Convert.ToDouble(row.Cells[3].Value);
                }

            }

            }
            
            return total_pedido;
        }
        public double calcular_Total_Servicio()
        {
            double total_servicio = 0;
            if (dgservicios.DataSource != null)
            {
                if (dgservicios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgservicios.Rows)
                {
                    total_servicio += Convert.ToDouble(row.Cells[1].Value);
                }

            }

            }
           
            return total_servicio;
        }

        private void btnbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscarcliente.Text == "")
            {
                MessageBox.Show("Ingrese un codigo  para buscar cliente",
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cod = txtbuscarcliente.Text;
                if (v.Buscar_Cliente(cod).Rows.Count > 0)
                {
                    cboclientes.DataSource = v.Buscar_Cliente(cod);
                    cboclientes.DisplayMember = "nombre";
                    cboclientes.ValueMember = "codigo";
                    txtbuscarcliente.Text = "";
                }
                else
                {
                    MessageBox.Show("El cliente que busca no exixte",
                        "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //listar pedido
        void cargarpedido()
        {
            int pedido = Convert.ToInt32(txtnumpedido.Text);
            if (b.listarpedidos(pedido).Rows.Count > 0)
            {
                dgpedidos.DataSource = b.listarpedidos(pedido);
            }
            else
            {
                MessageBox.Show("El pedido con este numero no existe",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //listar servicio
        void cargarServicio()
        {
            int servicio = Convert.ToInt32(txtnumservicio.Text);
            if (b.listarservicios(servicio).Rows.Count > 0)
            {
                dgservicios.DataSource = b.listarservicios(servicio);
            }
            else
            {
                MessageBox.Show("El servicio con este numero no existe",
                      "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            btnbuscar.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar.BackgroundImage = Properties.Resources.buca2;
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void cboclientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cargarpedido();
            //cargarServicio();
            //calcular_monto_totalBoleta();
            //calcular_monto_totalFactura();

        }
        void guardarFactura()
        {
            if (txtnum_comprobante.Text == "" || cbopersonal.Text == "<<Seleccionar>>" || cboclientes.Text == "<<buscar cliente----->>"
                || fecha.Text == "" || chestado.Checked == false || txtruc.TextLength < 11 || txtmontototal.Text == "")
            {
                MessageBox.Show("Llena los campos correctamente para guardar",
                   "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validartxtbox();
                if (txtruc.TextLength < 11)
                {
                    validar_error.SetError(txtruc, "Obligatorio 11 carácteres");
                }

            }
            else
            {

                if (rbofactura.Checked == true)
                {
                    if (MessageBox.Show("¿Desea guardar la factura?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (insertarFactura() > 0)
                        {
                            if (guardarDetalleFactura() > 0)
                            {
                                MessageBox.Show("Factura FAC0"+txtnum_comprobante.Text+" se guardó corretamente",
                            "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiar();
                                btncalcular.Enabled = false;
                                rboboleta.Checked = false;
                                rbofactura.Checked = false;
                                btnguardar.Enabled = false;
                                btncalcular.Enabled = false;
                                btncancelar.Enabled = false;
                                btnnuevo.Enabled = true;
                                grupbuscapedido.Enabled = false;
                                grupbuscarservicio.Enabled = false;
                                grupcomprobante.Enabled = false;
                                grup_Datos.Enabled = false;
                                grup_buscar.Enabled = false;
                                validar_error.Clear();

                            }
                            else
                            {
                                MessageBox.Show("Error en guardar la factura",
                           "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
        }
        void guardar_boleta()
        {
            if (txtnum_comprobante.Text == "" || cbopersonal.Text == "<<Seleccionar>>" || cboclientes.Text == "<<buscar cliente----->>"
                || fecha.Text == "" || chestado.Checked == false || txtmontototal.Text == "")
            {
                MessageBox.Show("Llena los campos correctamente para guardar",
                   "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validartxtbox();


            }
            else
            {
                if (MessageBox.Show("¿Desea guardar la boleta?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (insertarBoleta() > 0)
                    {
                        if (guardarDetalleBoleta() > 0)
                        {
                            MessageBox.Show("Boleta B0" + txtnum_comprobante.Text + " se guardó corretamente",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            btncalcular.Enabled = false;
                            rboboleta.Checked = false;
                            rbofactura.Checked = false;
                            btnguardar.Enabled = false;
                            btncalcular.Enabled = false;
                            btncancelar.Enabled = false;
                            btnnuevo.Enabled = true;
                            grupbuscapedido.Enabled = false;
                            grupbuscarservicio.Enabled = false;
                            grupcomprobante.Enabled = false;
                            grup_buscar.Enabled = false;
                            validar_error.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error en  guardar la boleta",
                      "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validartxtbox();
                        }
                    }

                }
                else
                {

                }


            }
        }
        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {

            if (rboboleta.Checked == true)
            {
                guardar_boleta();

            }
            else
            {
                guardarFactura();

            }

        }

        void validartxtbox()
        {
            if (chestado.Checked == false)
            {
                validar_error.SetError(chestado, "Activa el estado para guardar");
            }

            if (cbopersonal.Text == "<<Seleccionar>>")
             {
                    validar_error.SetError(cbopersonal, "Seleccione un personal");
             }
             if (cboclientes.Text == "<<buscar cliente----->>")
             {
                    validar_error.SetError(cboclientes, "debe buscar un cliente");
            }
            if (fecha.Text == " ")
            {
              validar_error.SetError(fecha, "ingrese la  fecha");
            }
            if (txtmontototal.Text == "")
            {
                validar_error.SetError(txtmontototal, "calcule el monto");
            }
             

          
        }
        //insertar boleta
        int insertarBoleta()
        {
            int n = 0;
            boletaEn.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
            boletaEn.fecha = Convert.ToDateTime(fecha.Value);
            boletaEn.personal = cbopersonal.SelectedValue.ToString();
            boletaEn.cliente = cboclientes.SelectedValue.ToString();
            boletaEn.estado = chestado.Checked;
            boletaEn.montototal = Convert.ToDouble(txtmontototal.Text);
            if (b.RegistrarBoleta(boletaEn) > 0)
            {
                n = 10;
            }
            else
            {
                MessageBox.Show("Error al guardar boleta", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return n;
        }
        //insertar factura
        int insertarFactura()
        {
            int n = 0;
            facturaEn.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
            facturaEn.ruc = txtruc.Text;
            facturaEn.fecha = Convert.ToDateTime(fecha.Text);
            facturaEn.personal = cbopersonal.SelectedValue.ToString();
            facturaEn.cliente = cboclientes.SelectedValue.ToString();
            facturaEn.estado = Convert.ToBoolean(chestado.Checked);
            facturaEn.montototal = Convert.ToDouble(txtmontototal.Text);
            facturaEn.igv = Convert.ToDouble(txtigv.Text);

            if (f.RegistrarFactura(facturaEn) > 0)
            {
                n = 10;
            }
            else
            {
                MessageBox.Show("Error al guardar la factura", "Soft Cherhikcar V1.0",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            return n;
        }


        //insertardetalleboleta

        public int guardarDetalleBoleta()
        {
            int respuesta = 0;
            if (dgpedidos.DataSource != null & dgservicios.DataSource != null)
            {
                dtb.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtb.pedido = Convert.ToInt32(txtnumpedido.Text);
                dtb.servicio = Convert.ToInt32(txtnumservicio.Text);
                if (b.RegistrarDetalleBoleta(dtb) > 0)
                {
                    respuesta = 10;

                }
            }
            else if (dgpedidos.DataSource != null & dgservicios.DataSource == null)
            {
                dtb.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtb.pedido = Convert.ToInt32(txtnumpedido.Text);
                dtb.servicio = 0;
                if (b.RegistrarDetalleBoleta(dtb) > 0)
                {
                    respuesta = 10;

                }
            }
            else if (dgpedidos.DataSource == null & dgservicios.DataSource != null)
            {
                dtb.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtb.pedido = 0;
                dtb.servicio = Convert.ToInt32(txtnumservicio.Text);
                if (b.RegistrarDetalleBoleta(dtb) > 0)
                {
                    respuesta = 10;

                }

            }
            else
            {
                MessageBox.Show("No hay datos en la lista detalle para guardar",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return respuesta;
        }

        //insertardetallefactura
        public int guardarDetalleFactura()
        {
            int respuesta = 0;
            if (dgpedidos.DataSource != null & dgservicios.DataSource != null)
            {
                dtf.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtf.pedido = Convert.ToInt32(txtnumpedido.Text);
                dtf.servicio = Convert.ToInt32(txtnumservicio.Text);
                if (f.RegistrarDetalleFactura(dtf) > 0)
                {
                    respuesta = 10;

                }
            }
            else if (dgpedidos.DataSource != null & dgservicios.DataSource == null)
            {
                dtf.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtf.pedido = Convert.ToInt32(txtnumpedido.Text);
                dtf.servicio = 0;
                if (f.RegistrarDetalleFactura(dtf) > 0)
                {
                    respuesta = 10;

                }
            }
            else if (dgpedidos.DataSource == null & dgservicios.DataSource != null)
            {
                dtf.numcomprobante = Convert.ToInt32(txtnum_comprobante.Text);
                dtf.pedido = 0;
                dtf.servicio = Convert.ToInt32(txtnumservicio.Text);
                if (f.RegistrarDetalleFactura(dtf) > 0)
                {
                    respuesta = 10;

                }

            }
            else
            {
                MessageBox.Show("No hay datos en la lista detalle para guardar",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return respuesta;
        }
        private void btnbuscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscardetalle_Click(object sender, EventArgs e)
        {
            if (txtnumpedido.Text == "")
            {
                MessageBox.Show("No se ingreso ningun codigo del pedido",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cargarpedido();
            }



        }

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                validar_error.SetError(chestado, "active el estado para guardar");
            }
            else
            {
                validar_error.SetError(chestado, null);
            }

        }

        private void cboclientes_Validating(object sender, CancelEventArgs e)
        {
            if (cboclientes.Text == "<<buscar cliente----->>")
            {
                validar_error.SetError(cbopersonal, "debe buscar un cliente");
            }
            else
            {
                validar_error.SetError(cboclientes, null);
            }
        }

        private void btnbuscardetalle_Validating(object sender, CancelEventArgs e)
        {
            if (btnbuscardetallepedido.Text == "")
            {
                validar_error.SetError(btnbuscardetallepedido, "no se a seleccionado la fecha");
            }
            else
            {
                validar_error.SetError(btnbuscardetallepedido, null);
            }
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cbocomprobante.SelectedIndex == 1)
            //{

            //    cargarlistaboletas();
            //}
            //if (cbocomprobante.SelectedIndex ==3)
            //{
            //    cargarlistafacturas();

            //}

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumservicio.Text == "")
            {
                MessageBox.Show("No se ingreso ningun codigo del servicio",
                    "Soft Cherhikcar V1.0",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                cargarServicio();
            }
           
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (rboboleta.Checked == true)
            {
                if (dgpedidos.DataSource != null & dgservicios.DataSource != null)
                {
                    calcular_monto_totalBoleta();
                    btnguardar.Enabled = true;
                }
                else if (dgpedidos.DataSource != null & dgservicios.DataSource == null)
                {
                    double montototal;
                    double pedido = calcular_Total_pedido();
                    montototal = pedido;
                    txtmontototal.Text = montototal.ToString("#00.00#");
                    btnguardar.Enabled = true;
                }
                else if (dgpedidos.DataSource == null & dgservicios.DataSource != null)
                {
                    double montototal;
                    double servicio = calcular_Total_Servicio();
                    montototal = servicio;
                    txtmontototal.Text = montototal.ToString("#00.00#");
                    btnguardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay datos en la lista detalle para calcular",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(rbofactura.Checked==true)
            {
                
                if (dgpedidos.DataSource != null & dgservicios.DataSource != null)
                {
                    calcular_monto_totalFactura();
                    btnguardar.Enabled = true;
                }
                else if (dgpedidos.DataSource != null & dgservicios.DataSource == null)
                {
                    //double montototal;
                    //double pedido = calcular_Total_pedido();
                    //montototal = pedido;

                    //txtmontototal.Text = montototal.ToString("#00.00#");
                    //btnguardar.Enabled = true;
                    calcular_monto_totalFactura();
                    btnguardar.Enabled = true;
                }
                else if (dgpedidos.DataSource == null & dgservicios.DataSource != null)
                {
                    calcular_monto_totalFactura();
                    btnguardar.Enabled = true;
                    //double montototal;
                    //double servicio = calcular_Total_Servicio();
                    //montototal = servicio;
                    //txtmontototal.Text = montototal.ToString("#00.00#");
                    //btnguardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay datos en la lista detalle para calcular",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun tipo de comprobante",
                      "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.Solo_Numeros(e);

        }

        private void txtnumpedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.Solo_Numeros(e);
        }

        private void txtnumservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.Solo_Numeros(e);
        }

        private void btnbuscardetallepedido_Click(object sender, EventArgs e)
        {
            if (txtnumpedido.Text == "")
            {
                MessageBox.Show("No se ingreso ningun codigo del pedido",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cargarpedido();
            }



        }

        private void btnbuscardetalleservicio_Click(object sender, EventArgs e)
        {
            if (txtnumservicio.Text == "")
            {
                MessageBox.Show("No se ingreso ningun codigo del servicio",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cargarServicio();
            }        
    }

        private void txtnumservicio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            va.Solo_Numeros(e);
        }

        private void txtruc_Validating(object sender, CancelEventArgs e)
        {
            if (txtruc.TextLength<11)
            {
                validar_error.SetError(txtruc, "ingrese el numero de Ruc");
            }
            else
            {
                validar_error.SetError(txtruc, null);
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

        private void txtnumpedido_Validating(object sender, CancelEventArgs e)
        {
            if (txtnumpedido.Text == " ")
            {
                validar_error.SetError(txtnumpedido, "ingrese el codigo para buscar");
            }
            else
            {
                validar_error.SetError(txtnumpedido, null);
            }
        }

        private void txtnumservicio_Validating(object sender, CancelEventArgs e)
        {
            if (txtnumservicio.Text == " ")
            {
                validar_error.SetError(txtnumservicio, "ingrese el codigo para buscar");
            }
            else
            {
                validar_error.SetError(txtnumservicio, null);
            }
        }

        private void fecha_Validating(object sender, CancelEventArgs e)
        {
            if (fecha.Text == " ")
            {
                validar_error.SetError(fecha, "ingrese la  fecha");
            }
            else
            {
                validar_error.SetError(fecha, null);
            }
        }

        private void cboclientes_SelectedIndexChanged(object sender, EventArgs e)
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

        private void grupdatos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_Validating(object sender, CancelEventArgs e)
        {
            if (cbocomprobante.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbocomprobante, "Seleccione un comprobante");
            }
            else
            {
                validar_error.SetError(cbocomprobante, null);
            }
        }

        private void cbopersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbocomprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString( cbocomprobante.SelectedItem) == "Boleta")
            {

                cargarlistaboletas();
            }
            if (Convert.ToString( cbocomprobante.SelectedItem )== "Factura")
            {
                cargarlistafacturas();

            }
        }

        private void txtbuscarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }

        private void btn_imprimir_bol_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Boleta b = new Formularios.Frm_Reporte_Boleta();
            b.ShowDialog();
        }

        private void btn_imprimir_fac_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Factura f = new Formularios.Frm_Reporte_Factura();
            f.ShowDialog();
        }

       
           
        
    } 
    
}

