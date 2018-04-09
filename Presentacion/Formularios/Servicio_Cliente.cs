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
    public partial class Servicio_Cliente : Form
    {
        
        //reutilisamos metos para buscarCliente en Vehiculo_Da
        Vehiculo_Neg v = new Vehiculo_Neg();
        //-----------------------------------
        ServicioCliente_Neg serv_neg = new ServicioCliente_Neg();
        DetalleServicioCiente_EN detaserv_en = new DetalleServicioCiente_EN();
        ServicioCliente_En serv_en = new ServicioCliente_En();
        Validacion_texbox val = new Validacion_texbox();

        // =============================================================
        public DataTable Tabla_Detalle;
       // int nº = 0;
        public Servicio_Cliente()
        {
            InitializeComponent();
        }

        private void Servicio_Cliente_Load(object sender, EventArgs e)
        {
            //crearTabla();
           
            txtprecio.Text = "0.00";
            cargarpersoanl();
            cargarservicios();
            cargarCliente();
            cbocliente.Text = "Buscar Cliente --->>";
            cargarlistarServicioCliente();

        }
        void cargarDetalleServicioCliente()
        {
            
            try
            {int n = Convert.ToInt32(dgv_lista_Servicios.CurrentRow.Cells[0].Value.ToString());
                if (n >= 0)
                {
                dgv_lista_detalle_serv.DataSource = serv_neg.listarDetalle_ServicioCliente(n);
                 }

            }
            catch
            {
                MessageBox.Show("No hay ningun servico", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        void cargarlistarServicioCliente()
        {
            dgv_lista_Servicios.DataSource = serv_neg.listarServicio_Cliente();
        }

        void cargar_ultimocodigo()
        {
            txtnum_serv.Text =Convert.ToString( serv_neg.Cargar_Mayor_Codigo() + 1);
        }
        void cargarpersoanl()
        {
            cbopersonal.DataSource = serv_neg.Listar_Personal_mecanico();
            cbopersonal.DisplayMember = "nombre";
            cbopersonal.ValueMember = "codigo";
            cbopersonal.Text = "<<Seleccionar>>";
        }

        void cargarservicios()
        {
            cboservicios.DataSource = serv_neg.cargarServicios();
            cboservicios.DisplayMember = "servicio";
            cboservicios.ValueMember = "codigo";
            cboservicios.Text = "<<Seleccionar>>";
        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {
            grupdatos.Enabled = true;           
            btncancelar.Enabled = true;
            groupBox1.Enabled = true;
            btnnuevo.Enabled = false;
            btnagregar.Enabled = true;
            cargar_ultimocodigo();
        }
        void colocarprecio()
        {
            int cod =Convert.ToInt32( cboservicios.SelectedValue);
            txtprecio.Text = serv_neg.colocarPrecio_servicio(cod).ToString();
        }

        private void cboservicios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            colocarprecio();
        }
        void cargarCliente()
        {
            cbocliente.DataSource = v.Listar_Cliente_Vehiculo();
            cbocliente.DisplayMember = "nombre";
            cbocliente.ValueMember = "codigo";        
           
        }
        int buscarcliente()
        {
            int r = 0;
            if (v.Buscar_Cliente_Vehiculo(txtbuscarcliente.Text).Rows.Count>0)
            {
                cargarCliente();
               cbocliente.SelectedValue = txtbuscarcliente.Text;
                txtbuscarcliente.Clear();
                r = 1;
            }
            else{
                MessageBox.Show("El cliente que busca no existe",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscarcliente.Clear();
            }
            return r;
        }


        private void btnbuscar_cliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscarcliente.Text == "")
            {
                MessageBox.Show("No ha ingresado ningun codigo",
                   "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {if (buscarcliente() > 0)
            {
               llenarplaca_cliente();
            }

            }
            
        }
        void llenarplaca_cliente()
        {
            string idcliente = Convert.ToString(cbocliente.SelectedValue.ToString());
            if(serv_neg.Buscar_placa_vehiculo(idcliente).Rows.Count >0)
            {
                cboplaca.DataSource = serv_neg.Buscar_placa_vehiculo(idcliente);
                cboplaca.DisplayMember = "placa_vehiculo";
                cboplaca.ValueMember = "placa_vehiculo";
            }
            else
            {
                MessageBox.Show("El cliente aun no tiene ningun vehículo registrado",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            
        }

        //private void crearTabla()
        //{
        //    Tabla_Detalle = new DataTable();
        //    Tabla_Detalle.Columns.Add("Nº");
        //    Tabla_Detalle.Columns.Add("Cod Serv");
        //    Tabla_Detalle.Columns.Add("Servicio de Mantenimiento");
        //    Tabla_Detalle.Columns.Add("Precio");        
        //    //Relacionar nuestro DataGRidView con nuestro DataTable
        //    dgv_Detalle_servico.DataSource = Tabla_Detalle;
        //}


        void limpiarDetalle()
        {
            cargarservicios();
            txtprecio.Text = "0.00";
            
        }
       

        public Boolean Recorrer()
        {
            Boolean r = false;

            foreach (DataGridViewRow row in dgv_Detalle_servico.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(cboservicios.SelectedValue))
                {
                    r = true;
                }
            }

            return r;
        }

        public void CalcularTotal()
        {

            if (dgv_Detalle_servico.Rows.Count > 0)
            {
                double sub_total = 0;
                foreach (DataGridViewRow row in dgv_Detalle_servico.Rows)
                {
                    sub_total += Convert.ToDouble(row.Cells[3].Value);
                    txtimporte.Text = sub_total.ToString("#0.00#");
                }
            }

        }

        public int Guardar_Detalle_Servicio()
        {int respuesta = 0;
            try
            {
            foreach (DataGridViewRow row in dgv_Detalle_servico.Rows)
            {
                detaserv_en.numserv = Convert.ToInt32(txtnum_serv.Text);
                detaserv_en.servicico = Convert.ToInt32(row.Cells[1].Value);
                detaserv_en.importe = Convert.ToDouble(row.Cells[3].Value);
                if (dgv_Detalle_servico == null)
                {
                    MessageBox.Show("No hay datos en la lista detalle para guardar",
                        "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (serv_neg.RegistrarDetalle_ServicioCliente(detaserv_en) > 0)
                    {
                        respuesta +=1;
                    }
                   

                }
            }

            }
            catch
            {
                MessageBox.Show("No hay datos en la lista detalle para guardar",
                        "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return respuesta;

        }
        public void validar()
        {
             if (cboplaca.Text == "")
            {
                validar_error.SetError(cboplaca, "La placa no es valido");
            }
            else
            {
                validar_error.SetError(cboplaca, null);
            }

            if(cbocliente.Text== "Buscar Cliente --->>")
            {
                validar_error.SetError(cbocliente, "Busca un cliente para registar");
            }
            else
            {
                validar_error.SetError(cbocliente, null);
            }

            if (cbopersonal.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbopersonal, "Elige un personal");
            }
            else
            {
                validar_error.SetError(cbopersonal, null);
            }
 
            if (chestado.Checked == false)
            {
                validar_error.SetError(chestado, "Activa para guardar");

            }
            else
            {
                validar_error.SetError(chestado, null);
            }
        }

        void limpiar()
        {
            cargarpersoanl();
            cargarCliente();
            cbocliente.Text = "Buscar Cliente --->>";
            cboplaca.DataSource=null;
            txtimporte.Clear();
            chestado.Checked = false;
            txtnum_serv.Clear();
           for(int i = 0; i < dgv_Detalle_servico.RowCount; i++)
            {
                dgv_Detalle_servico.Rows.Clear();
            }

        }

        object colocar_orden()
        {
           int n = 0;
            foreach (DataGridViewRow row in dgv_Detalle_servico.Rows)
            {
                n = Convert.ToInt32(row.Cells[0].Value = n + 1);

            }
            return n;
        }
        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if(cbocliente.Text == "Buscar Cliente --->>" || cbopersonal.Text == "<<Seleccionar>>"||cboplaca.Text==""
                ||chestado.Checked==false)
            {
                MessageBox.Show("Llena los campos correctamente para guardar",
                       "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar();
            }
            else
            {
            if(MessageBox.Show("¿Desea Guardar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                serv_en.numserv =Convert.ToInt32( txtnum_serv.Text);
                serv_en.cliente = cbocliente.SelectedValue.ToString();
                serv_en.placa = cboplaca.SelectedValue.ToString();
                serv_en.personal = cbopersonal.SelectedValue.ToString();
                serv_en.fecha = Convert.ToDateTime( fecha.Text);
                serv_en.importe = Convert.ToDouble( txtimporte.Text);
                serv_en.estado = Convert.ToBoolean( chestado.Checked);
                if (serv_neg.RegistrarServicioCliente(serv_en) > 0)
                {
                    if (Guardar_Detalle_Servicio() > 0)
                    {
                        MessageBox.Show("El servicio Nº SV0"+serv_en.numserv+" se guardó correctamente",
                       "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarlistarServicioCliente();
                            limpiar();
                            btnguardar.Enabled = false;
                            btnnuevo.Enabled = true;
                            btncancelar.Enabled = false;
                            btnagregar.Enabled = false;
                            btneliminar.Enabled = false;
                            grupdatos.Enabled = false;
                            groupBox1.Enabled = false;
                            validar_error.Clear();                       
                        }
                }
                else
                {
                    MessageBox.Show("Error al guardar el servicio de mantenimiento ",
                     "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
                

            }
        }

     

        private void dgv_lista_Servicios_DoubleClick(object sender, EventArgs e)
        {
           
                cargarDetalleServicioCliente();
         
           
        }

        private void bntbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscarservicio.Text == "")
            {
                cargarservicios();
            }
            else
            {
                if (serv_neg.buscar_Servicio_cliente(Convert.ToInt32(txtbuscarservicio.Text)).Rows.Count>0)
                {
                    dgv_lista_Servicios.DataSource = serv_neg.buscar_Servicio_cliente(
                    Convert.ToInt32(txtbuscarservicio.Text));

                }
                else
                {
                    MessageBox.Show("El registro que busca no existe", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscarservicio.Clear();
                }
            }
             
        }

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                validar_error.SetError(chestado, "Activa para guardar");

            }
            else
            {
                validar_error.SetError(chestado, null);
            }
        }

        private void cbopersonal_Validating(object sender, CancelEventArgs e)
        {
            if (cbopersonal.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbopersonal, "Elige un personal");
            }
            else
            {
                validar_error.SetError(cbopersonal, null);
            }
        }

        private void cbocliente_Validating(object sender, CancelEventArgs e)
        {
            if(cbocliente.Text== "Buscar Cliente --->>")
            {
                validar_error.SetError(cbocliente, "Busca un cliente para registar");
            }
            else
            {
                validar_error.SetError(cbocliente, null);
            }
        }

        private void txtplaca_Validating(object sender, CancelEventArgs e)
        {
            if (cboplaca.Text == "")
            {
                validar_error.SetError(cboplaca, "La placa no es valido");
            }
            else
            {
                validar_error.SetError(cboplaca, null);
            }
        }

        private void cboservicios_Validating(object sender, CancelEventArgs e)
        {
            if (cboservicios.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cboservicios, "Seleccione un servicio");
            }
            else
            {
                validar_error.SetError(cboservicios, null);
            }
        }

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
            cargarCliente();
            cargarpersoanl();
            limpiar();
            limpiarDetalle();
            btnagregar.Enabled = true;
            grupdatos.Enabled = false;
            groupBox1.Enabled = false;
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;           
            btnnuevo.Enabled = true;
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

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        //private void btneliminar_MouseHover(object sender, EventArgs e)
        //{
        //    btneliminar.BackgroundImage = Properties.Resources.eliminar2;
        //}

        //private void btneliminar_MouseLeave(object sender, EventArgs e)
        //{
        //    btneliminar.BackgroundImage = Properties.Resources.eliminar;
        //}

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbuscarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Solo_Numeros(e);
        }

        private void btnbuscar_cliente_MouseHover(object sender, EventArgs e)
        {
            btnbuscar_cliente.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscar_cliente_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar_cliente.BackgroundImage = Properties.Resources.buca2;
        }

        private void bntbuscar_MouseHover(object sender, EventArgs e)
        {
            btnbuscar_cliente.BackgroundImage = Properties.Resources.busc;
        }

        private void bntbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar_cliente.BackgroundImage = Properties.Resources.buca2;
        }

        private void cbocliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarplaca_cliente();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (dgv_lista_Servicios.Focus() == false)
            {
                MessageBox.Show("No Selecciono ningun Pedido", "Cherhikcar V1.0",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dar_baja_servicio();
            }
        }
        void Dar_baja_servicio()
        {
            try
            {
                serv_en.numserv = Convert.ToInt32(dgv_lista_Servicios.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿ Desea dar de baja este servicio ?", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { if (serv_neg.Eliminar_servicio(serv_en) > 0)
                {
                    MessageBox.Show("Se dio de baja correctamente", "Cherhikcar V1.0",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarlistarServicioCliente();
                }
                else
                {
                    MessageBox.Show("Error al dar de baja", "Cherhikcar V1.0",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
               

            }
            catch
            {
                MessageBox.Show("No Selecciono ningun servicio", "Cherhikcar V1.0",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cboservicios.Text == "<<Seleccionar>>"||txtprecio.Text == "0.00")
            {
                MessageBox.Show("No selecciono ningun servicio",
                 "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_error.SetError(cboservicios, "Seleccione un servicio");
                }          
            else
            {  /*nº = nº + 1;*/
                if (Recorrer() == false)
                {
                    dgv_Detalle_servico.Rows.Add(colocar_orden(), cboservicios.SelectedValue, cboservicios.Text, txtprecio.Text);
                    CalcularTotal();
                    limpiarDetalle();

                    btneliminar.Enabled = true;
                    btnguardar.Enabled = true;
                    btnguardar.Focus();
                    validar_error.Clear();
                }
                else
                {
                    MessageBox.Show("Ya se agrego este servicio al detalle",
                       "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = dgv_Detalle_servico.CurrentCell.RowIndex;
                DataGridViewRow row = dgv_Detalle_servico.Rows[indiceFila];

                //Disminuir el totalPAgado
                double total = 0;
                total = Convert.ToDouble(txtimporte.Text) - Convert.ToDouble(row.Cells[3].Value);

                txtimporte.Text = total.ToString("#0.00#");
                //Removemos la fila
                dgv_Detalle_servico.Rows.Remove(row);
                colocar_orden();


            }
            catch
            {
                MessageBox.Show("No hay lista detalle para quitar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtbuscarservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }

        private void btn_imprimir_bol_Click(object sender, EventArgs e)
        {
            frm_Reporte_Servicios_Vehiculo v = new frm_Reporte_Servicios_Vehiculo();
            v.ShowDialog();
        }
    }
}
