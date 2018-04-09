using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Presentacion
{
    public partial class frm_ayuda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_ayuda()
        {
            InitializeComponent();
        }

        private void frm_ayuda_Load(object sender, EventArgs e)
        {
            try
            {
                llenar_ayuda();
            }
            catch
            {
                MessageBox.Show("No se encontro el documento",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void llenar_ayuda()
        {
            string leer_ruta = Path.Combine(Application.StartupPath, "presentacion.pdf");
            miVisor_pdf.DocumentFilePath = leer_ruta;
        }
    }
}
