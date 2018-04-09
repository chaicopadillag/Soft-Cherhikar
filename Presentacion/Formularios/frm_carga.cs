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
    public partial class frm_Carga : Form
    {
        public frm_Carga()
        {
            InitializeComponent();
        }
        int n = 0;
        private void frm_progress_Load(object sender, EventArgs e)
        {
            btnfoto.BackgroundImage = Properties.Resources.linda;
            lblnombre.Text = "Ermelinda";
            lblapellido.Text = "Choque Saire";
            lblfuncion.Text = "Jefa de Proyecto";
            lbl_ide.Text = "Desarrollado con Metologia XP";
           
        }
        //369; 272       
        private void tiempo_Tick(object sender, EventArgs e)
        {
            progressBarX1.Minimum = 0;
            progressBarX1.Maximum = 100;                    
             n = n + 1;                      
         if (progressBarX1.Value < 100)
            {                    
                progressBarX1.Value +=1;       
                progressPanel1.Description = "Cargando sistema... " + progressBarX1.Value + " %";
                if (progressBarX1.Value == 20)
                {
                    lbl_ide.Text = "Lenguaje de programación C#";
                    btnfoto.BackgroundImage = Properties.Resources.carmen;
                    lblnombre.Text = "Carmen";
                    lblapellido.Text = "Quispe Ccuno";
                    lblfuncion.Text = "Programadora";
                    
                }              
                else if (progressBarX1.Value == 40)
                {
                    lbl_ide.Text = "Arquitectura 4 capas";
                    btnfoto.BackgroundImage = Properties.Resources.chaico;
                    lblnombre.Text = "Gerard";
                    lblapellido.Text = "Chaico Padilla";
                    lblfuncion.Text = "Programador";
                    
                }
               else if (progressBarX1.Value == 60)
                {
                    lbl_ide.Text = "System.Data.SqlClient";
                    btnfoto.BackgroundImage = Properties.Resources.yandy;
                    lblnombre.Text = "Hirahoka";
                    lblapellido.Text = "Toledo Meza";
                    lblfuncion.Text = "Tester";
                    
                }
               else if (progressBarX1.Value == 80)
                {
                    lbl_ide.Text = "Proyecto: Desarrollo de Software";
                    btnfoto.BackgroundImage = Properties.Resources.kevin;
                    lblnombre.Text = "Kevin";
                    lblapellido.Text = "Gamarra Ninahuaman";
                    lblfuncion.Text = "Tester";
                    
                }
                else if (n == 2)
                {

                    btm_auto.SymbolColor = Color.Black;
                    btnllave.SymbolColor = Color.ForestGreen;
                    btnrepuesto.SymbolColor = Color.Red;
                }
                else if (n == 4)
                {
                    btm_auto.SymbolColor = Color.Red;
                    btnllave.SymbolColor = Color.Black;
                    btnrepuesto.SymbolColor = Color.ForestGreen;

                }
                else if (n == 6)
                {
                    btm_auto.SymbolColor = Color.ForestGreen;
                    btnllave.SymbolColor = Color.Red;
                    btnrepuesto.SymbolColor = Color.Black;
                }
                else if (n > 6)
                {
                    n = 0;

                }
                else
                {

                }
            }    
            else
            {
                tiempo.Stop();
                this.Hide();
                Loguin l = new Loguin();
                l.Show();

            }       
        }
    }
}
