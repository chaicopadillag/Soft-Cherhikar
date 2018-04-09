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
    public partial class frm_Reporte_Vehiculo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Reporte_Vehiculo()
        {
            InitializeComponent();
        }
        Reportes.Reporte_de_Vehiculos v = new Reportes.Reporte_de_Vehiculos();
        private void frm_Reporte_Vehiculo_Load(object sender, EventArgs e)
        {
            cargar_reporte();
        }
        void cargar_reporte()
        {
            try
            {
                documentViewer1.PrintingSystem = v.PrintingSystem;
                v.CreateDocument();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede cargar el reporte por " + e.Message,
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
