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
    public partial class Frm_Reporte_Perso : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Reporte_Perso()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Perso_Load(object sender, EventArgs e)
        {
            cargar_reporte_personal();
        }
        Reportes.Reporte_de_Personal p = new Reportes.Reporte_de_Personal();
        void cargar_reporte_personal()
        {
            try
            {
                documentViewer1.PrintingSystem = p.PrintingSystem;
                p.CreateDocument();
            }
            catch(Exception e)
            {
                MessageBox.Show("No puede cargar el reporte por " + e.Message,
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
