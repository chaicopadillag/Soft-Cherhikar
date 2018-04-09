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
    public partial class Frm_Reporte_Boleta : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Reporte_Boleta()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Boleta_Load(object sender, EventArgs e)
        {
            cargar_reporte_boleta();
        }
        Reportes.Reporte_de_Boleta b = new Reportes.Reporte_de_Boleta();
        void cargar_reporte_boleta()
        {
            try
            {
                documentViewer1.PrintingSystem = b.PrintingSystem;
                b.CreateDocument();

            }
            catch(Exception e)
            {
                MessageBox.Show("No carga la boleta por "+e.Message, "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
