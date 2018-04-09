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
    public partial class frm_info : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_info()
        {
            InitializeComponent();
        }

        private void frm_info_Load(object sender, EventArgs e)
        {
            try
            {
                llenar_info();
            }
            catch
            {
                MessageBox.Show("No se encontro el documento", 
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void llenar_info()
        {
            string leer_ruta = Path.Combine(Application.StartupPath, "proyecto.pdf");
            miVisor_pdf.DocumentFilePath=leer_ruta;
        }
    }
}
