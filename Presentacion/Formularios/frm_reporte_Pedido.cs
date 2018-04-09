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
    public partial class frm_reporte_Pedido : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_reporte_Pedido()
        {
            InitializeComponent();
        }

        private void frm_reporte_Pedido_Load(object sender, EventArgs e)
        {
            Reportes.Reporte__de__Pedido p = new Reportes.Reporte__de__Pedido();
            try
            {
                documentViewer1.PrintingSystem = p.PrintingSystem;
                p.CreateDocument();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el reporte solicitado",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
