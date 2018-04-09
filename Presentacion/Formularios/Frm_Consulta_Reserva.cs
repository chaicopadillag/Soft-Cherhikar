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
    public partial class Frm_Consulta_Reserva : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Consulta_Reserva()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            CargarReporteResrva();
        }
        Reportes.Reporte_Reserva r = new Reportes.Reporte_Reserva();
        void CargarReporteResrva()
        {
            try
            {
                documentViewer1.PrintingSystem = r.PrintingSystem;
                r.CreateDocument();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede cargar el reporte por " + e.Message,
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
