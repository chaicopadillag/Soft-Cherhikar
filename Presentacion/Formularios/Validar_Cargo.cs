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

namespace Presentacion
{
    public partial class Validar_Cargo : Form
    {
        Usuarios_Neg u = new Usuarios_Neg();
        string codUsuario = Program.Usuario;
        public Validar_Cargo()
        {
            InitializeComponent();
        }
        public void cargarPrevias()
        {
            //centrar Panel
            Size tamaño_monitor = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int alto = (tamaño_monitor.Height - (-350)) / 2;
            int ancho = (tamaño_monitor.Width - 660) / 2;
            validar_carg.Location = new Point(alto, ancho);

        }
        private void Validar_Cargo_Load(object sender, EventArgs e)
        {
            cargarCago();
            cargarPrevias();           
            try
            {
                object personal=u.ColocarNombrePersonal(codUsuario).ToString();
                if (personal == null){
                    MessageBox.Show("El codigo de personal no reconocido vuelve intentar de nuevo",
                  "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            lblpersonal.Text = personal.ToString();
             MessageBox.Show("Para continuar debe seleccionar un rol, funcion o cargo",
                "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch
            {
                MessageBox.Show("El codigo de personal no reconocido vuelve intentar de nuevo",
                   "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void cargarCago()
        {
            cbocargo.DataSource = u.listarcargo();
            cbocargo.DisplayMember = "nombre";
            cbocargo.ValueMember = "codigo";
            cbocargo.Text = "<<Seleccionar>>";

        }
        private void tbniniciar_Click(object sender, EventArgs e)
        {
            if (cbocargo.Text == "<<Seleccionar>>")
            {
                MessageBox.Show("No selecciono ningun funcion, rol o cargo",
                   "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cod = codUsuario;
            int carg = Convert.ToInt32(cbocargo.SelectedValue);
            object cargo = null;
            cargo = u.obtener_cargo(cod, carg);
            if (cargo == null)
            {
                MessageBox.Show("El cargo o rol seleccionado no es correcto",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Program.Usuario = lblpersonal.Text;
                Program.cargo = cargo.ToString();
                this.Hide();
                Menu m = new Menu();
                m.Show();
                
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loguin l = new Loguin();
            l.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
