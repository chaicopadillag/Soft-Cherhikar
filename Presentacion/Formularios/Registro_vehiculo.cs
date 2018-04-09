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
    public partial class Registro_vehiculo : Form
    {
        Vehiculo_En car_ent = new Vehiculo_En();
        Vehiculo_Neg car_neg = new Vehiculo_Neg();
        Validacion_texbox v = new Validacion_texbox();
        public Registro_vehiculo()
        {
            InitializeComponent();
        }

        private void btnbuscar_MouseHover(object sender, EventArgs e)
        {
            btnbuscarplaca.BackgroundImage = Properties.Resources.bus_car1;
        }

        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnbuscarplaca.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnbuscar2_MouseHover(object sender, EventArgs e)
        {
            btnbuscarCliente.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbuscar2_MouseLeave(object sender, EventArgs e)
        {

            btnbuscarCliente.BackgroundImage = Properties.Resources.buca2;
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

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void Registro_vehiculo_Load(object sender, EventArgs e)
        {
            cargarVehiculo();
            cargarMarca();
            cbomarcav.Text = "<<Seleccionar>>";
            cargarTipoVeh();
            cbotipov.Text = "<<Seleccionar>>";
            cargarcliente();
            cbocliente.Text = "Buscar cliente ------>>";
        }  
                
        public void cargarMarca()
        {
            cbomarcav.DataSource = car_neg.listar_Marca();
            cbomarcav.DisplayMember = "marca";
            cbomarcav.ValueMember = "cod";
           
        }
        public void cargarmodelo()
        {
            int cod = Convert.ToInt32(cbomarcav.SelectedValue);
            cbomodelo.DataSource = car_neg.listar_Modelo(cod);
            cbomodelo.DisplayMember = "Modelo";
            cbomodelo.ValueMember = "Codigo";           
        }
        public void cargarVehiculo()
        {
            dgv_vehiculos.DataSource = car_neg.Listar_Vehiculo();
        }
        public void cargarTipoVeh()
        {
            cbotipov.DataSource = car_neg.listar_tipoVehiculo();
            cbotipov.ValueMember = "codigo";
            cbotipov.DisplayMember = "nombre";
           
        }
        private void cbomarcav_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarmodelo();
            Validar_error.SetError(cbomodelo, null);
        }

        private void btnbusc_MouseHover(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.bus_car1;
        }

        private void btnbusc_MouseLeave(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnguardar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtplaca.TextLength==6 & cbocliente.Text != "Buscar cliente ------>>" & 
                cbomarcav.Text != "<<Seleccionar>>" & cbotipov.Text != "<<Seleccionar>>" &
                chestado.Checked == true)
            {
                registrarVehiculo();
                
               

            }
            else
            {
                MessageBox.Show("Llena los campos correctamente para guardar", 
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                validar_campo();

            }
            
        }
        void validar_campo()
        {if(cbocliente.Text== "Buscar cliente ------>>")
                {
                    Validar_error.SetError(cbocliente, "Debe buscar un cliente/propietario");
                }
                if(cbotipov.Text== "<<Seleccionar>>")
                {Validar_error.SetError(cbotipov, "Seleccionar marca del vehíulo");

                }

                if (cbomarcav.Text == "<<Seleccionar>>")
                {Validar_error.SetError(cbomarcav, "Seleccionar marca del vehíulo");
                Validar_error.SetError(cbomodelo, "Primero seleccione marca vehículo");
                }

                if (txtplaca.TextLength < 6)
                {
                    Validar_error.SetError(txtplaca, "La placa es de seis caracteres");
                }
                if (chestado.Checked == false)
                {
                    Validar_error.SetError(chestado, "Debe estar activo para guardar");
                }

        }
        void registrarVehiculo()
        {
            car_ent.placa = txtplaca.Text;
            car_ent.cod_client = cbocliente.SelectedValue.ToString();
            car_ent.cod_marca = Convert.ToInt32(cbomarcav.SelectedValue);
            car_ent.cod_madel = Convert.ToInt32(cbomodelo.SelectedValue);
            car_ent.cod_tipo = Convert.ToInt32(cbotipov.SelectedValue);
            car_ent.color = txtcolor.Text;
            car_ent.descrip = txtdescricion.Text;
            car_ent.estado = chestado.Checked;
            if (MessageBox.Show("¿ Estas seguro que quieres guardar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (car_neg.RegistarVehiculo(car_ent) > 0)
                {
                    MessageBox.Show("El vehículo con placa ''"+car_ent.placa+"'' se ha guardado correctamente", 
                        "Soft Cherhikcar V1.0",     MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargarVehiculo();
                    grup_datos.Enabled = false;
                    limpiar();
                    btnguardar.Enabled = false;
                    btncancelar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                    btnnuevo.Enabled = true;
                    Validar_error.Clear();
                    grup_buscar.Enabled = true;
                    Validar_error.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar vehículo con placa ''"+car_ent.placa+"''", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }

        private void btnmodificar_MouseClick(object sender, MouseEventArgs e)
        {
            if (grup_datos.Enabled == false)
            {
                MessageBox.Show("Busca un vehículo  para modificar", "Soft Cherhikcar V1.0",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtplaca.TextLength == 6 & cbocliente.Text != "Buscar cliente ------>>" &
                cbomarcav.Text != "<<Seleccionar>>" & cbotipov.Text != "<<Seleccionar>>" &
                chestado.Checked == true)
            {
                modificarveh();              

            }
            else
            {
                MessageBox.Show("Ingrese datos correctos para modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campo();
            }
           
        }
        void modificarveh()
        {
            car_ent.placa = txtplaca.Text;
            car_ent.cod_client = cbocliente.SelectedValue.ToString();
            car_ent.cod_marca = Convert.ToInt32(cbomarcav.SelectedValue);
            car_ent.cod_madel = Convert.ToInt32(cbomodelo.SelectedValue);
            car_ent.cod_tipo = Convert.ToInt32(cbotipov.SelectedValue);
            car_ent.color = txtcolor.Text;
            car_ent.descrip = txtdescricion.Text;
            car_ent.estado = chestado.Checked;
            if (MessageBox.Show("¿ Quieres modificar el registro ?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (car_neg.ModificarVehiculo(car_ent) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargarVehiculo();
                    grup_datos.Enabled = false;
                    limpiar();                               
                    Validar_error.Clear();
                    btnnuevo.Enabled = true;
                    btncancelar.Enabled = false;
                    grup_buscar.Enabled = true;
                    btnmodificar.Enabled = false;
                    btneliminar.Enabled = false;
                    Validar_error.Clear();
                }
                else
                {
                    MessageBox.Show("Error al modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                btnmodificar.Enabled = true;

            }

        }

        private void btneliminar_MouseClick(object sender, MouseEventArgs e)
        {
            if (grup_datos.Enabled == false)
            {
                MessageBox.Show("Busca un vehículo para eliminar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtplaca.Text != "")
            {
                EliminarVeh();

            }
            else
            {
                MessageBox.Show("Ingrese la placa para eliminar", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        void EliminarVeh()
        {
            car_ent.placa = txtplaca.Text;

            if (MessageBox.Show("¿ Quieres eliminar el registro ?", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (car_neg.EliminarVehiculo(car_ent) > 0)
                {
                    MessageBox.Show("Se ha eliminado correctamente", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cargarVehiculo();
                    grup_datos.Enabled = false;
                    limpiar();
                    Validar_error.Clear();
                    btncancelar.Enabled = false;
                    btnnuevo.Enabled = true;
                    grup_buscar.Enabled = true;
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    Validar_error.Clear();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
            else
            {

            }

        }        

        private void btnnuevo_MouseClick(object sender, MouseEventArgs e)        {
          
            grup_datos.Enabled = true;
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            grup_buscar.Enabled =false;
            limpiar();
        }
        void limpiar() {
            txtplaca.Clear();
            txtbusc.Clear();
            txtbuscarClient.Clear();
            txtcolor.Clear();
            txtdescricion.Clear();         
            cargarTipoVeh();
            cbotipov.Text = "<<Seleccionar>>";
            cargarcliente();
            cbocliente.Text = "Buscar cliente ------>>";
            cargarMarca();
            cbomarcav.Text = "<<Seleccionar>>";
            cbomodelo.DataSource = null;
            chestado.Checked = false;

        }

        private void btncancelar_MouseClick(object sender, MouseEventArgs e)
        {           
            grup_datos.Enabled = false;
            limpiar();
            Validar_error.Clear();
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = false;
            grup_buscar.Enabled = true;
        }

        private void btnbusc_MouseClick(object sender, MouseEventArgs e)
        {
            cargarcliente();

            if (txtbusc.Text != "")
            { car_ent.placa = txtbusc.Text;
                if (car_neg.Buscar_VehiculoFrom(car_ent) == true)
                {
                    cargarcliente();
                    cargarMarca();
                    cargarTipoVeh();
                    txtplaca.Text = car_ent.placa.ToString();
                    cbocliente.SelectedValue = car_ent.cod_client;
                    cbomarcav.SelectedValue = car_ent.cod_marca;
                    cargarmodelo();
                    cbomodelo.SelectedValue = car_ent.cod_madel;
                    cbotipov.SelectedValue = car_ent.cod_tipo;
                    txtcolor.Text = car_ent.color;
                    txtdescricion.Text = car_ent.descrip;
                    chestado.Checked = car_ent.estado;
                    grup_datos.Enabled = true;
                    btnmodificar.Enabled = true;
                    Validar_error.Clear();
                    grup_buscar.Enabled = false;
                    btneliminar.Enabled = true;
                    txtbusc.Clear();
                    btncancelar.Enabled = true;
                    btnnuevo.Enabled = false;
                    
                }
                else
                {
                    MessageBox.Show("El vehículo con esta placa no existe", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbusc.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingrese la placa del vehículo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                
            
           
        }

        private void btnbuscar_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (txtbuscaVehiculo.Text != "")
            { car_ent.placa = txtbuscaVehiculo.Text;
                if (car_neg.BuscarVehiculoTabla(car_ent).Rows.Count > 0)
                {
                   dgv_vehiculos.DataSource = car_neg.BuscarVehiculoTabla(car_ent);
                    Validar_error.Clear();
                   
                }
                else
                {
                    MessageBox.Show("El vehículo con esta placa no existe",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtbuscaVehiculo.Clear();

                }
            }
            else
            {
                MessageBox.Show("Ingrese la placa del Vehículo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        void cargarcliente()
        {
            cbocliente.DataSource = car_neg.Listar_Cliente_Vehiculo();
            cbocliente.DisplayMember = "nombre";
            cbocliente.ValueMember = "codigo";           
        }
        private void btnbuscarCliente_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (txtbuscarClient.Text != "")
            { string cod = txtbuscarClient.Text;
                if (car_neg.Buscar_Cliente_Vehiculo(cod).Rows.Count > 0)
                {
                    cbocliente.SelectedValue = cod;
                    Validar_error.SetError(cbocliente, null);
                }
                else
                {
                    MessageBox.Show("El Cliente que busca no existe", "Soft Cherhikcar V1.0",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la identificacion del cliente para buscar", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtplaca_Validating(object sender, CancelEventArgs e)
        {
            if (txtplaca.TextLength<6)
            {
                Validar_error.SetError(txtplaca, "La placa es de seis caracteres");
            }
            else
            {
                Validar_error.SetError(txtplaca, null);
            }
        }

        private void cbocliente_Validating(object sender, CancelEventArgs e)
        {
            if(cbocliente.Text== "Buscar cliente ------>>"){
                Validar_error.SetError(cbocliente, "Debe buscar un cliente/propietario");
            }
            else
            {
                Validar_error.SetError(cbocliente, null);
            }
        }

        private void cbomarcav_Validating(object sender, CancelEventArgs e)
        {
            if (cbomarcav.Text == "<<Seleccionar>>")
            {
                Validar_error.SetError(cbomarcav, "Seleccionar marca del vehíulo");
            }
            else
            {
                Validar_error.SetError(cbomarcav, null);
            }

        }

        private void cbomodelo_Validating(object sender, CancelEventArgs e)
        {
            if (cbomodelo.Text == "")
            {
                Validar_error.SetError(cbomodelo, "Primero seleccione marca vehículo");
            }
            else
            {
                Validar_error.SetError(cbomodelo, null);
            }
        }

        private void cbotipov_Validating(object sender, CancelEventArgs e)
        {
            if (cbotipov.Text == "<<Seleccionar>>")
            {
                Validar_error.SetError(cbotipov, "Seleccionar marca del vehíulo");
            }
            else
            {
                Validar_error.SetError(cbotipov, null);
            }
        }

        private void chestado_Validating(object sender, CancelEventArgs e)
        {
            if (chestado.Checked == false)
            {
                Validar_error.SetError(chestado, "Debe estar activo para guardar");
            }
            else
            {
                Validar_error.SetError(chestado, null);
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

        private void txtbuscarClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtplaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras_Y_Numeros(e);
        }

        private void txtbuscaVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras_Y_Numeros(e);
        }

        private void txtbusc_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.Solo_Letras_Y_Numeros(e);
        }
    }
}

