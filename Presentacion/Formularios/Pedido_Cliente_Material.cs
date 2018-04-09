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
    public partial class Pedido_Cliente_Material : Form
    {
        Pedido_En ped_En = new Pedido_En();
        Pedido_Neg ped_Neg = new Pedido_Neg();
        Detallepedido_En detalle = new Detallepedido_En();
        //--Reutilizando metodos de otras clases para bucar cliente;
        Vehiculo_Neg car_neg = new Vehiculo_Neg();
        public DataTable dtDetalle;
        //int nº = 0;

        public Pedido_Cliente_Material()
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

       

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void btnbusca_client_MouseHover(object sender, EventArgs e)
        {
            btnbusca_client.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbusca_client_MouseLeave(object sender, EventArgs e)
        {
            btnbusca_client.BackgroundImage = Properties.Resources.buca2;
        }

        private void bntbuscar_MouseHover(object sender, EventArgs e)
        {
            bntbuscar.BackgroundImage = Properties.Resources.busc;
        }

        private void bntbuscar_MouseLeave(object sender, EventArgs e)
        {
            bntbuscar.BackgroundImage = Properties.Resources.buca2;
        }

        private void Pedido_Cliente_Material_Load(object sender, EventArgs e)
        {
            
            cargarlistapedidos();
            cargar_categoria();
         
            cargarpersonal();
            crearTabla();
            txtprecio.Text="0.00";
            cbocliente.Text = "Buscar cliente ------>>";
            txtbuscarCliente.Focus();
        }
        void cargar_categoria()
        {
            cbocategoria.DataSource = ped_Neg.lista_categoria_rpto();
            cbocategoria.DisplayMember = "nombre";
            cbocategoria.ValueMember = "codigo";
            cbocategoria.Text = "<<Seleccionar>>";
        }
        void cargar_existencia_repuesto()
        {
            int cod = Convert.ToInt32(cborepuestos.SelectedValue);
            txtexistencia.Text =Convert.ToString(
            ped_Neg.Cargar_Cantidad_Existencia_Repuesto(cod));
        }
        void cagarultimocodigo()
        {
            txtcodpedio.Text = Convert.ToString(ped_Neg.cargarUltimoCodigoPedido()+1);
        }
        private void crearTabla()
        {
            dtDetalle = new DataTable();
            //dtDetalle.Columns.Add("Nº");
            dtDetalle.Columns.Add("Codigo");
            dtDetalle.Columns.Add("Repuesto");
            dtDetalle.Columns.Add("Cantidad");
            dtDetalle.Columns.Add("Precio Unitario");
            dtDetalle.Columns.Add("Importe");
            //Relacionar nuestro DataGRidView con nuestro DataTable
            dgv_Detalle_pedido.DataSource = dtDetalle;
        }       
     
          
       
        void cargarrepuestos()
        {
            cborepuestos.DataSource = ped_Neg.lista_repuesto(Convert.ToInt32(cbocategoria.SelectedValue));
            cborepuestos.DisplayMember = "nombre";
            cborepuestos.ValueMember = "codigo";
            cborepuestos.Text = "<<Seleccionar>>";
        }
        void cargarpersonal()
        {
            cbopersonal.DataSource = ped_Neg.Lista_Persoanl();
            cbopersonal.DisplayMember = "nombre";
            cbopersonal.ValueMember = "codigo";
            cbopersonal.Text = "<<Seleccionar>>";
            colocarprecio();
        }
        void cargarlistapedidos()
        {
            dgv_tbpedido.DataSource = ped_Neg.Listar_Pedido();
        }
         
        void colocarprecio()
        {
            int cod = Convert.ToInt32(cborepuestos.SelectedValue);
                 
                txtprecio.Text =ped_Neg.colocar_precio(cod).ToString();
                    
            
        }
        Reserva_Cliente_Neg r = new Reserva_Cliente_Neg();
        private void btnbusca_client_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbuscarCliente.Text == "")
            {
                MessageBox.Show("Ingrese la identificacion cliente para buscar ", 
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { string cod = txtbuscarCliente.Text;
                if (r.Buscar_Cliente(cod).Rows.Count > 0)
                {
                    cbocliente.DataSource = r.Buscar_Cliente(cod);
                    cbocliente.DisplayMember = "nombre";
                    cbocliente.ValueMember = "codigo";
                    txtbuscarCliente.Clear();                 
                }
                else
            {
                MessageBox.Show("El cliente que busca no existe",
                    "Cherhikcar V1.0", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbuscarCliente.Clear();
            }

            }
           
        }

        private void bntbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbucarpedido.Text == "")
            {
                cargarlistapedidos();
            }
            else
            {ped_En.numpedido = Convert.ToInt32( txtbucarpedido.Text);

            if (ped_Neg.Buscar_Pedido(ped_En).Rows.Count > 0)
            {
                dgv_tbpedido.DataSource = ped_Neg.Buscar_Pedido(ped_En);
            }
            else
            {
                MessageBox.Show("El pedido con este numero no existe", 
                    "Cherhikcar V1.0",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbucarpedido.Clear();
                }

            }
            
        }

        private void cborepuestos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_existencia_repuesto();
            colocarprecio();
            limitarcantidad();
            calcular();
        }
        //object colocar_orden()
        //{
        //    int n = 0;
        //    foreach (DataRow row in dtDetalle.Rows)
        //    {
        //        n = Convert.ToInt32(row[0] = n + 1);

        //    }
        //    return n;
        //}

        private void btnagregar_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        public void CalcularTotal()
        {           

            if (dgv_Detalle_pedido.Rows.Count > 0)
            { 
                double sub_total = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    sub_total += Convert.ToDouble(row[4]);
                    txtMontoTotal.Text =sub_total.ToString("#0.00#");
                }               
            }       

         }
        public Boolean Recorrer()
        {
            Boolean r = false;

            foreach (DataRow row in dtDetalle.Rows)
            {
                if (Convert.ToInt32(row[0]) == Convert.ToInt32(cborepuestos.SelectedValue))
                {                    
                    r = true;
                }
            }                      
           
            return r;         
       }
        void limpiarDetalle()
        {              
            txtcantidad.Value=0;
            txtexistencia.Text="0";
            txtprecio.Text = "0.00";
            txtsubtotal.Clear();
            cargar_categoria();
            cborepuestos.DataSource = null;
        }

        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        { if (cbopersonal.Text == "<<Seleccionar>>" ||
                cbocliente.Text == "Buscar cliente ------>>" ||
                txtMontoTotal.Text == ""|| chestado.Checked == false)
            {MessageBox.Show("Llena los campos correctamente para guardar",
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(cbocliente.Text== "Buscar cliente ------>>")
                {
                    validar_error.SetError(cbocliente, "Buscas un Cliente");
                }
                if (chestado.Checked == false)
                {
                  validar_error.SetError(chestado, "Activa el estado para guardar pedido");
                }
                if (cbopersonal.Text == "<<Seleccionar>>")
                {
                 validar_error.SetError(cbopersonal, "Seleccione un personal");
                }
               
                        
            }
            else
            {
                if (detalle == null)
                {
                    MessageBox.Show("No hay datos en la lista detalle para guardar",
                        "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("¿Desea Guardar?", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ped_En.numpedido = Convert.ToInt32(txtcodpedio.Text);
                        ped_En.personal = cbopersonal.SelectedValue.ToString();
                        ped_En.cliente = cbocliente.SelectedValue.ToString();
                        ped_En.fecha = Convert.ToDateTime(fecha.Text);
                        ped_En.importe = Convert.ToDouble(txtMontoTotal.Text);
                        ped_En.estado = Convert.ToBoolean(chestado.Checked);
                        if (ped_Neg.Registar_Pedido(ped_En) > 0)
                        {
                            if (guardarDetallepedido() > 0)
                            {
                                MessageBox.Show("El pedido PD0"+ped_En.numpedido+" se registro corectamente",
                                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                cargarlistapedidos();
                     
                                cargarpersonal();
                                chestado.Checked = false;
                                dtDetalle.Clear();
                                txtcodpedio.Clear();
                                cbocliente.Text = "Buscar cliente ------>>";
                                grupdatos.Enabled = false;
                                btnguardar.Enabled = false;
                                btncancelar.Enabled = false;
                                btnnuevo.Enabled = true;
                                groupBox3.Enabled = false;
                                groupBox1.Enabled = false;                                
                                txtMontoTotal.Clear();
                                validar_error.Clear();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al guardar pedido",
                                "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }                 
            }
           

        }
       

        public int guardarDetallepedido()
        { int respuesta= 0;
            foreach (DataRow row in dtDetalle.Rows)
            {
                detalle.numpedido = Convert.ToInt32(txtcodpedio.Text);
                detalle.repuesto = Convert.ToInt32(row[0]);
                detalle.cantidad = Convert.ToInt32(row[2]);
                detalle.precio = Convert.ToDouble(row[3]);
                detalle.sub_total = Convert.ToDouble(row[4]);
                if (detalle == null)
                {
                    MessageBox.Show("No hay lista detalle para guardar",
                        "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    respuesta = ped_Neg.Registar_Detalle_Pedido(detalle);
                   
                }
            }
            return respuesta;          
            
        }        
        private void txtcantidad_ValueChanged(object sender, EventArgs e)
        {
           
            calcular();
            limitarcantidad();

        }
        void limitarcantidad()
        { txtcantidad.Maximum = Convert.ToInt32( txtexistencia.Text);
            if (txtcantidad.Value >= Convert.ToInt32(txtexistencia.Text))
            {
                MessageBox.Show("No hay mas repuestos para agregar",
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void calcular()
        {         
           int cantidad = Convert.ToInt32(txtcantidad.Value);
                double subtotal = 0;
                double precio = Convert.ToDouble(txtprecio.Text);
                subtotal = cantidad * precio;
                txtsubtotal.Text = subtotal.ToString("#0.00#");            
        }

        private void dgv_tbpedido_DoubleClick(object sender, EventArgs e)
        {


            try
            {
                int n = Convert.ToInt32(dgv_tbpedido.CurrentRow.Cells[0].Value.ToString());
               if (n > 0)
               {
                    dgv_detalle.DataSource = ped_Neg.BuscarDetallePedido(n);
               }

            }
            catch
            {

                MessageBox.Show("No hay ningun pedido",
                    "soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
           
        }

        private void dgv_Detalle_pedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        //    DataGridViewRow fila = dgv_Detalle_pedido.CurrentRow;
        //    cborepuestos.SelectedValue = fila.Cells[1].Value.ToString();
        //    cargar_existencia_repuesto();
        //    txtcantidad.Value = Convert.ToInt32(fila.Cells[3].Value.ToString());
        //    txtprecio.Text = fila.Cells[4].Value.ToString();
        //    txtsubtotal.Text = fila.Cells[5].Value.ToString();
        //    cborepuestos.Enabled = false;
        //    btnmodificar.Enabled = true;
           
        }

        private void btneliminar_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)
        {
            txtbuscarCliente.Focus();
            cargar_categoria();
            grupdatos.Enabled = true;
            btnagregar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            groupBox1.Enabled = true;
            cagarultimocodigo();
            cbocliente.Text = "Buscar cliente ------>>";
            groupBox3.Enabled = true;
        }


        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {
            grupdatos.Enabled = false;
            btnagregar.Enabled = false;
            btnguardar.Enabled = false;           
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            chestado.Checked = false;  
            cargarpersonal();                
            limpiarDetalle();
            dtDetalle.Clear();
            btnnuevo.Enabled = true;
            txtexistencia.Text = "0";
            groupBox1.Enabled = false;          
            txtcodpedio.Clear();
            txtMontoTotal.Clear();
            cbocliente.Text = "Buscar cliente ------>>";
            validar_error.Clear();

        }

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                validar_error.SetError(chestado, "Activa el estado para guardar pedido");
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
                validar_error.SetError(cbopersonal, "Seleccione un personal");
            }
            else
            {
                validar_error.SetError(cbopersonal, null);
            }
        }

        private void cbocliente_Validating(object sender, CancelEventArgs e)
        {
            if (cbocliente.Text== "Buscar cliente ------>>")
            {
                validar_error.SetError(cbocliente, "Busca un Cliente");
            }
            else
            {
                validar_error.SetError(cbocliente, null);
            }
        }

        private void cborepuestos_Validating(object sender, CancelEventArgs e)
        {
            if (cborepuestos.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cborepuestos, "Seleccione un repuesto");
            }
            else
            {
                validar_error.SetError(cborepuestos, null);
            }
        }

        private void txtcantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtcantidad.Value ==0)
            {
                validar_error.SetError(txtcantidad, "Agregue una cantidad");
            }
            else
            {
                validar_error.SetError(txtcantidad, null);
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

        private void txtbuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }

        private void txtbucarpedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_texbox v = new Validacion_texbox();
            v.Solo_Numeros(e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(dgv_tbpedido.Focus()==false)
            {
                MessageBox.Show("No Selecciono ningun Pedido", "Cherhikcar V1.0",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dar_baja_pedido();
            }
        }
        void Dar_baja_pedido()
        {
            try
            { ped_En.numpedido = Convert.ToInt32(dgv_tbpedido.CurrentRow.Cells[0].Value);

                if(MessageBox.Show("Desea dar de baja este pedido", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  if (ped_Neg.Eliminar_Pedido(ped_En) > 0)
            {
                MessageBox.Show("Se dio de baja correctamente", "Cherhikcar V1.0",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarlistapedidos();
                        dgv_Detalle_pedido.DataSource = null;
            } else
            {
                MessageBox.Show("Error al dar de baja", "Cherhikcar V1.0",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                }
          

            }
            catch
            {
                MessageBox.Show("No Selecciono ningun Pedido", "Cherhikcar V1.0",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbocategoria.Text == "<<Seleccionar>>")
            {
                MessageBox.Show("Seleccione una categoria",
                   "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_error.SetError(cbocategoria, "Seleccione un repuesto");
            }
            else if (cborepuestos.Text == "<<Seleccionar>>")
            {

                MessageBox.Show("Seleccione un repuesto para agregar",
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_error.SetError(cborepuestos, "Seleccione un repuesto");
            }
            else if (txtcantidad.Value == 0)
            {
                MessageBox.Show("Elige una cantidad para agregar",
                    "Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_error.SetError(txtcantidad, "Agregue una cantidad");
            }


            else
            {
                if (Recorrer() == false)
                {
                    // nº = nº + 1;
                    DataRow f = dtDetalle.NewRow();
                    //f[0] = colocar_orden();
                    f[0] = Convert.ToInt32(cborepuestos.SelectedValue);
                    f[1] = cborepuestos.Text;
                    f[2] = Convert.ToInt32(txtcantidad.Text);
                    f[3] = Convert.ToDecimal(txtprecio.Text);
                    f[4] = Convert.ToDecimal(txtsubtotal.Text);
                    dtDetalle.Rows.Add(f);
                    dgv_Detalle_pedido.DataSource = dtDetalle;
                    CalcularTotal();
                    limpiarDetalle();
                    btnguardar.Enabled = true;
                    btneliminar.Enabled = true;
                    btnguardar.Focus();
                    validar_error.Clear();

                }
                else
                {
                    MessageBox.Show("Este repuesto ya se agrego al detalle", "Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = dgv_Detalle_pedido.CurrentCell.RowIndex;

                btnguardar.Enabled = true;
                DataRow row = dtDetalle.Rows[indiceFila];
                //Disminuir el totalPAgado
                double total = 0;
                total = Convert.ToDouble(txtMontoTotal.Text) - Convert.ToDouble(row[4].ToString());

                txtMontoTotal.Text = total.ToString("#0.00#");
                //Removemos la fila
                dtDetalle.Rows.Remove(row);


            }
            catch (Exception)
            {
                MessageBox.Show("No hay lista detalle para quitar", "Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbocategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarrepuestos();
            txtexistencia.Text = 0.ToString();
        }

        private void cbocategoria_Validating(object sender, CancelEventArgs e)
        {
            if (cbocategoria.Text == "<<Seleccionar>>")
            {
                validar_error.SetError(cbocategoria, "Seleccione una categoria");
            }
            else
            {
                validar_error.SetError(cbocategoria, null);
            }
        }

        private void btn_imprimir_bol_Click(object sender, EventArgs e)
        {
            frm_reporte_Pedido p = new frm_reporte_Pedido();
            p.ShowDialog();
        }
    }
}

