using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Reporte_Servicios_Vehiculo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Reporte_Servicios_Vehiculo()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Servicios_Vehiculo_Load(object sender, EventArgs e)
        {
            Reportes.Reporte_de_Servicios s = new Reportes.Reporte_de_Servicios();
            try
            {
                documentViewer1.PrintingSystem = s.PrintingSystem;
                s.CreateDocument();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el reporte solicitado",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
