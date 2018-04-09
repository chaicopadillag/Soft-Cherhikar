using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace Presentacion
{
    public partial class Menu : DevComponents.DotNetBar.RibbonForm
    {
        int n;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.Usuario;
           lbl_Perfil.Text = Program.Perfil;
            lblcargo.Text = Program.cargo;
            colocar_Cerrar_sesion();
            Permisos_del_Usuario();
            cargar_previas();
            colocarItemprincipal();
            colocar_nombre();


            n = 0;
        }
        void colocar_nombre()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - (-250))/ 2;
            int anch = (tamañ_monitor.Width - 1200) / 2;
            lbl_logo.Location = new Point(alt, anch);
        }
        public void Permisos_del_Usuario()
        {
        
            
            string perfil = lbl_Perfil.Text;
             if (lblcargo.Text == "Secretaria")
            {                          
                btn_caja.Enabled = false;                
                btn_reportPedidos.Enabled = false;
                radial_reporte_Pedido.Enabled = false;
                radial_reporte_factura.Enabled = false;
                radial_report_boleta.Enabled = false;
                btn_caja.Enabled = false;
                radial_pedido.Enabled = false;
                btn_reportFactura.Enabled = false;
                btn_reportBoletas.Enabled = false;
                btn_pedido.Enabled = false;


            }
            if (lblcargo.Text == "Cajero")
            {
                btn_manto.Enabled = false;
                btn_reserva.Enabled = false;
                btn_servicios.Enabled = false;   
                radial_mantenimiento.Enabled = false;
                radial_procesos.Enabled = false;               
                btn_usu.Enabled = false;
                btn_personal.Enabled = false;
                btn_client.Enabled = false;
                btn_vehicul.Enabled = false;
                btn_repuestos.Enabled = false;
                btn_serv.Enabled = false;
                radial_reporte_cliente.Enabled = false;
                radial_reporte_Pedido.Enabled = false;
                radial_reporte_vehiculo.Enabled = false;
                radial_reporte_personal.Enabled = false;
                btn_reportCliente.Enabled = false;
                btn_reportePersonal.Enabled = false;
                btn_reportPedidos.Enabled = false;
                btn_reportServicios.Enabled = false;
                btn_reportVehiculo.Enabled = false;
                radial_servico_cliente.Enabled = false;
                radial_reporte_Servicios.Enabled = false;





            }
            if (lblcargo.Text == "Vendedor")
            {
                btn_manto.Enabled = false;
                btn_reserva.Enabled = false;
                btn_servicioVehiculo.Enabled = false;
                btn_reportes.Enabled = false;
                radial_mantenimiento.Enabled = false;
                radial_servico_cliente.Enabled = false;
                btn_usu.Enabled = false;
                btn_personal.Enabled = false;
                btn_client.Enabled = false;
                btn_vehicul.Enabled = false;
                btn_repuestos.Enabled = false;
                btn_serv.Enabled = false;
                radial_reporte_cliente.Enabled = false;
                radial_reporte_factura.Enabled = false;
                radial_report_boleta.Enabled = false;
                radial_reporte_vehiculo.Enabled = false;
                radial_reporte_personal.Enabled = false;
                btn_caja.Enabled = false;


            }
            if (perfil == "Cliente")
            {
                btn_manto.Enabled = false;
                btn_reservarServicios.Enabled = false;
                btn_servicios.Enabled = false;
                btn_caja.Enabled = false;
                btn_reportes.Enabled = false;                         
                radial_mantenimiento.Enabled = false;
                radial_reserva.Enabled = false;
                radial_caja.Enabled = false;
                btn_usu.Enabled = false;
                btn_personal.Enabled = false;
                btn_client.Enabled = false;
                btn_vehicul.Enabled = false;
                btn_repuestos.Enabled = false;
                btn_serv.Enabled = false;
                radial_servico_cliente.Enabled = false;
                radial_pedido.Enabled = false;
                radial_reportes.Enabled = false;

            }
            if (lblcargo.Text == "Mecánico")
            {
                btn_manto.Enabled = false;     
                btn_caja.Enabled = false;     
                radial_mantenimiento.Enabled = false;
                btn_pedido.Enabled = false;
                radial_caja.Enabled = false;
                btn_usu.Enabled = false;
                btn_personal.Enabled = false;
                btn_client.Enabled = false;      
                radial_pedido.Enabled = false;     
                radial_reporte_cliente.Enabled = false;
                radial_reporte_factura.Enabled = false;
                radial_report_boleta.Enabled = false;
                radial_reporte_personal.Enabled = false;
                radial_reporte_Pedido.Enabled = false;
                btn_reportBoletas.Enabled = false;
                btn_reportCliente.Enabled = false;
                btn_reportePersonal.Enabled = false;
                btn_reportFactura.Enabled = false;
                btn_reportPedidos.Enabled = false;
            }
        }
        public void cargar_previas()
        {
            menu_circular.Size=new Size(303, 339);
            Size tamaño_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alto = (tamaño_monitor.Height - (-320)) / 2;
            int ancho = (tamaño_monitor.Width - 900) / 2;
            menu_circular.Location = new Point(alto, ancho);          
            //====================================================================
           
            //====================================================================

            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        public void colocarItemprincipal()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - 765) / 2;
            int anch = (tamañ_monitor.Width - 900) / 2;
            item_principal.Location = new Point(alt, anch);
        }         
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargar_previas();
        }
        
        private void radial_usuario_Click(object sender, EventArgs e)
        {
            Registro_Usuario Usuario = new Registro_Usuario();
            Usuario.ShowDialog();
        }

        private void radial_servico_cliente_Click(object sender, EventArgs e)
        {
            Servicio_Cliente servicioCliente = new Servicio_Cliente();
            servicioCliente.ShowDialog();
        }

        private void radial_pedido_Click(object sender, EventArgs e)
        {
            Pedido_Cliente_Material pedido = new Pedido_Cliente_Material();
            pedido.ShowDialog();
        }

        private void radial_vehiculo_Click(object sender, EventArgs e)
        {
            Registro_vehiculo vehiculo = new Registro_vehiculo();
            vehiculo.ShowDialog();
        }     

        private void btn_manto_Click(object sender, EventArgs e)
        {
            n = 1;         
            btn_manto.ColorTable = eButtonColor.OrangeWithBackground;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            colocarItem_manto();
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;         
            item_reportes.Visible = false;
            item_manto.Visible = true;
            
           
            
        }
        public void colocarItem_manto()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - 355) / 2;
            int anch = (tamañ_monitor.Width - 900) / 2;
            item_manto.Location = new Point(alt, anch);
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        { n = 1;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.OrangeWithBackground;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            colocar_item_reserva();
            item_servicios.Visible = false;
            item_manto.Visible = false;         
            item_reportes.Visible = false;
            Item_Reservas.Visible = true;
           
        }

        public void colocar_item_reserva()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - 355) / 2;
            int anch = (tamañ_monitor.Width - 730) / 2;
            Item_Reservas.Location = new Point(alt, anch);
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {n = 1;

            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.OrangeWithBackground;
            btn_reportes.ColorTable = eButtonColor.Blue;
            colocar_item_Servicios();
            item_manto.Visible = false;
            Item_Reservas.Visible = false;           
            item_reportes.Visible = false;
            item_servicios.Visible = true;
            
        }

        public void colocar_item_Servicios()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - 355) / 2;
            int anch = (tamañ_monitor.Width - 630) / 2;
            item_servicios.Location = new Point(alt, anch);
        }

        private void tbn_reportes_Click(object sender, EventArgs e)
        {n = 1;

            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.OrangeWithBackground;
            colocar_item_Reportes();
            item_manto.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_reportes.Visible = true;
            
        }
        public void colocar_item_Reportes()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height - 355) / 2;
            int anch = (tamañ_monitor.Width - 810) / 2;
            item_reportes.Location = new Point(alt, anch);
        }

        private void tbn_salir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estas seguro que quieres salir del sistema?",
                "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            item_principal.Visible = false;        
             item_manto.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_reportes.Visible = false;
        }    
       
        private void btn_manto_MouseHover(object sender, EventArgs e)
        {
            if (n <=1)
            {
                n = 0;
            }
            colocarItem_manto();
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_reportes.Visible = false;
            item_manto.Visible = true;          
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_manto_MouseLeave(object sender, EventArgs e)
        {
            if (n<=0) {

            btn_manto.ColorTable = eButtonColor.Blue;
                colocarItem_manto();
                Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_reportes.Visible = false;
            item_manto.Visible = false;
            }            
            
        }

        private void btn_reserva_MouseHover(object sender, EventArgs e)
        {
            if (n <= 1)
            {
                n = 0;
            }
            colocar_item_reserva();
            item_servicios.Visible = false;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = true;
            btn_manto.ColorTable = eButtonColor.Blue;           
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_reserva_MouseLeave(object sender, EventArgs e)
        {
            if (n <= 0)
            {
            btn_reserva.ColorTable = eButtonColor.Blue;
                colocar_item_reserva();
                item_servicios.Visible = false;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            }
                       
        }

        private void btn_servicios_MouseHover(object sender, EventArgs e)
        {
            if (n <= 1)
            {
                n = 0;
            }
            colocar_item_Servicios();
            item_manto.Visible = false;
            Item_Reservas.Visible = false;
            item_reportes.Visible = false;
            item_servicios.Visible = true;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;            
            btn_reportes.ColorTable = eButtonColor.Blue;

        }

        private void btn_servicios_MouseLeave(object sender, EventArgs e)
        {
            if (n <= 0)
            {
                btn_servicios.ColorTable = eButtonColor.Blue;
                colocar_item_Servicios();
                item_manto.Visible = false;
                Item_Reservas.Visible = false;
                item_reportes.Visible = false;
                item_servicios.Visible = false;
            }
           
            
        }

        private void tbn_reportes_MouseHover(object sender, EventArgs e)
        {
            if (n <= 1)
            {
                n = 0;
            }
            colocar_item_Reportes();
            item_manto.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_reportes.Visible = true;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
           
        }

        private void tbn_reportes_MouseLeave(object sender, EventArgs e)
        {
            if (n <= 0)
            {
                btn_reportes.ColorTable = eButtonColor.Blue;
                colocar_item_Reportes();
                item_manto.Visible = false;
                Item_Reservas.Visible = false;
                item_servicios.Visible = false;
                item_reportes.Visible = false;
            }
           
        }

        private void btn_caja_MouseHover(object sender, EventArgs e)
        {
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
        }

        private void btn_informes_MouseHover(object sender, EventArgs e)
        {
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
        }

        private void btn_ayuda_MouseHover(object sender, EventArgs e)
        {
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
        }

        private void tbn_salir_MouseHover(object sender, EventArgs e)
        {
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;        }

        private void btn_usu_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            Registro_Usuario usu = new Registro_Usuario();
            usu.ShowDialog();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            Registro_del_personal p = new Registro_del_personal();
            p.ShowDialog();

        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            PRESENTACION.Mantenimiento_Registro_Clientes client = new PRESENTACION.Mantenimiento_Registro_Clientes();
            client.ShowDialog();

        }

        private void btn_vehicul_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            Registro_vehiculo v = new Registro_vehiculo();
            v.ShowDialog();
        }

        private void btn_repuestos_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;           
            Registro_de_Materiales m = new Registro_de_Materiales();
            m.ShowDialog();

        }

        private void btn_serv_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            frm_Servicios s = new frm_Servicios();
            s.ShowDialog();
        }

        private void menu_circular_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void Radial_menu_MouseHover(object sender, EventArgs e)
        {
            Radial_menu.Colors.RadialMenuButtonBorder = Color.DodgerBlue;
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

            Registro_vehiculo v = new Registro_vehiculo();
            v.ShowDialog();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

            Registro_Usuario usu = new Registro_Usuario();
            usu.ShowDialog();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

            Pedido_Cliente_Material pedido = new Pedido_Cliente_Material();
            pedido.ShowDialog();
        }

        private void btn_servicioVehiculo_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

            Servicio_Cliente serv = new Servicio_Cliente();
            serv.ShowDialog();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Cerrar Soft Cherhikcar ?",
               "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            item_principal.Visible = true;
           btnInicio.SymbolColor = Color.DodgerBlue;
            //btnInicio.BackColor = Color.White;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.SymbolColor = Color.Crimson;
            //btnInicio.BackColor = Color.Red;
            if (n <= 0)
            {
                item_principal.Visible = false;

            }

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            n = 1;
            item_principal.Visible = true;
        }

        private void tbn_personal_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Registro_del_personal p = new Registro_del_personal();
            p.ShowDialog();

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;

            PRESENTACION.Mantenimiento_Registro_Clientes client = new PRESENTACION.Mantenimiento_Registro_Clientes();
            client.ShowDialog();
        }

        private void btn_respuesto_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Registro_de_Materiales m = new Registro_de_Materiales();
            m.ShowDialog();

        }

        private void btn_servicio_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_Servicios s = new frm_Servicios();
            s.ShowDialog();
        }

        private void tbn_reportPersonal_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Formularios.Frm_Reporte_Perso p = new Formularios.Frm_Reporte_Perso();
            p.ShowDialog();

        }

        private void btn_reportCliente_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Formularios.Frm_Reporte_Clientes c = new Formularios.Frm_Reporte_Clientes();
            c.ShowDialog();

        }

        private void btn_reportVehiculo_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_Reporte_Vehiculo v = new frm_Reporte_Vehiculo();
            v.ShowDialog();

        }

        private void btn_reportFactura_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Formularios.Frm_Reporte_Factura f = new Formularios.Frm_Reporte_Factura();
            f.ShowDialog();
        }

        private void btn_reportBoletas_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Formularios.Frm_Reporte_Boleta b = new Formularios.Frm_Reporte_Boleta();
            b.ShowDialog();
        }

        private void btn_reportPedidos_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_reporte_Pedido p = new frm_reporte_Pedido();
            p.ShowDialog();

        }

        private void btn_reportServicios_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_Reporte_Servicios_Vehiculo s = new frm_Reporte_Servicios_Vehiculo();
            s.ShowDialog();
        }

        private void tbn_reservarServicios_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Registro_Reserva_Cliente r = new Registro_Reserva_Cliente();
            r.ShowDialog();

        }

        private void tbn_consultar_servicio_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Formularios.Frm_Consulta_Reserva r = new Formularios.Frm_Consulta_Reserva();
            r.ShowDialog();
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_info info = new frm_info();
            info.ShowDialog();

        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            Comprobante_Pago p = new Comprobante_Pago();
            p.ShowDialog();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            n = 0;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
            frm_ayuda ayuda = new frm_ayuda();
            ayuda.ShowDialog();
        }

        private void radial_Infro_Click(object sender, EventArgs e)
        {
            frm_info info = new frm_info();
            info.ShowDialog();
        }

        private void radial_ayuda_Click(object sender, EventArgs e)
        {
            frm_ayuda ayuda = new frm_ayuda();
            ayuda.ShowDialog();
        }

        private void btn_usu_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_personal_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_client_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_vehicul_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_repuestos_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void btn_serv_MouseHover(object sender, EventArgs e)
        {
            item_manto.Visible = false;
            item_reportes.Visible = false;
            Item_Reservas.Visible = false;
            item_servicios.Visible = false;
            item_principal.Visible = false;
            btn_manto.ColorTable = eButtonColor.Blue;
            btn_reserva.ColorTable = eButtonColor.Blue;
            btn_servicios.ColorTable = eButtonColor.Blue;
            btn_reportes.ColorTable = eButtonColor.Blue;
        }

        private void Radial_menu_MouseLeave(object sender, EventArgs e)
        {
            Radial_menu.Colors.RadialMenuButtonBorder = Color.Red;
        }

        private void menu_circular_MouseLeave(object sender, EventArgs e)
        {
            Radial_menu.Colors.RadialMenuButtonBorder = Color.Red;
        }

        private void radial_reporte_Pedido_Click(object sender, EventArgs e)
        {
            frm_reporte_Pedido p = new frm_reporte_Pedido();
            p.ShowDialog();
        }

        private void radial_reporte_vehiculo_Click(object sender, EventArgs e)
        {
            frm_Reporte_Vehiculo v = new frm_Reporte_Vehiculo();
            v.ShowDialog();
        }

        private void radial_eporte_Servicios_Click(object sender, EventArgs e)
        {
            frm_Reporte_Servicios_Vehiculo v = new frm_Reporte_Servicios_Vehiculo();
            v.ShowDialog();
        }

        private void radial_cliente_Click(object sender, EventArgs e)
        {
            PRESENTACION.Mantenimiento_Registro_Clientes client = new PRESENTACION.Mantenimiento_Registro_Clientes();
            client.ShowDialog();
        }

        private void radial_personal_Click(object sender, EventArgs e)
        {
            Registro_del_personal p = new Registro_del_personal();
            p.ShowDialog(); 
        }

        private void radial_servicio_Click(object sender, EventArgs e)
        {
            frm_Servicios s = new frm_Servicios();
            s.ShowDialog();
        }

        private void radial_repuestos_Click(object sender, EventArgs e)
        {
            Registro_de_Materiales m = new Registro_de_Materiales();
            m.ShowDialog();
        }

        private void radial_reserva_Click(object sender, EventArgs e)
        {
            Registro_Reserva_Cliente r = new Registro_Reserva_Cliente();
            r.ShowDialog();
        }

        private void radial_caja_Click(object sender, EventArgs e)
        {
            Comprobante_Pago caja = new Comprobante_Pago();
            caja.ShowDialog();
        }

        private void radial_report_boleta_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Boleta b = new Formularios.Frm_Reporte_Boleta();
            b.ShowDialog();
        }

        private void radial_reporte_cliente_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Clientes c = new Formularios.Frm_Reporte_Clientes();
            c.ShowDialog();
        }

        private void radial_reporte_factura_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Factura f = new Formularios.Frm_Reporte_Factura();
            f.ShowDialog();
        }

        private void radial_reporte_personal_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Reporte_Perso p = new Formularios.Frm_Reporte_Perso();
            p.ShowDialog();
        }

        private void radial_consulta_reserva_Click(object sender, EventArgs e)
        {
            Formularios.Frm_Consulta_Reserva r = new Formularios.Frm_Consulta_Reserva();
            r.ShowDialog();
        }

       

     

        private void labelX1_MouseHover(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Red;
        }

        private void labelX1_MouseLeave(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Blue;
        }
        int s = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            s = s + 1;
            if (s ==30)
            {
                this.Hide();
                Loguin l = new Loguin();
                l.Show();

            }
        }
        void colocar_Cerrar_sesion()
        {
            Size tamañ_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alt = (tamañ_monitor.Height -(-380)) / 2;
            int anch = (tamañ_monitor.Width - 200) / 2;
            progressSalir.Location = new Point(alt, anch);
        }
        private void labelX1_MouseClick(object sender, MouseEventArgs e)
        {
            if(MessageBox.Show("¿ Desea cerrar su sesión ?","Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer2.Enabled = true;
                timer2.Start();
              //  progressSalir.Caption = "Cerrando sesión de " + lblUsuario.Text;
                progressSalir.Visible = true;
                menu_circular.Enabled = false;
                btnInicio.Enabled = false;
                Program.cargo = "";
            }
            else
            {

            }
        }
    }
}