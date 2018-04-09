using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Frm_Reporte_Clientes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Reporte_Clientes()
        {
            InitializeComponent();
        }
        Reportes.Reporte_Cliente c = new Reportes.Reporte_Cliente();
        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }
        void CargarReporteCliente()
        {
            try
            {
                documentViewer1.PrintingSystem = c.PrintingSystem;
                c.CreateDocument();
                              

            }
            catch(Exception e)
            {
                MessageBox.Show("No se puede cargar el reporte por " + e.Message, 
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Reporte_Clientes_Load(object sender, EventArgs e)
        {
            CargarReporteCliente();
        }
    }
}
