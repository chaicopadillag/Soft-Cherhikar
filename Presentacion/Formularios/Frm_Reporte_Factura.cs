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
    public partial class Frm_Reporte_Factura : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Reporte_Factura()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Factura_Load(object sender, EventArgs e)
        {
            CargarReporteFactura();
        }
        Reportes.Reporte_de_Factura f = new Reportes.Reporte_de_Factura();
        void CargarReporteFactura()
        {
            try
            {
                documentViewer1.PrintingSystem = f.PrintingSystem;
                f.CreateDocument();


            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede cargar el reporte por " + e.Message,
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
