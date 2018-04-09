using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Registro_de_Materiales : Form
    {

        Materiales_EN mate_Ent = new Materiales_EN();
        Materiales_Neg mat_Neg = new Materiales_Neg();
        Validacion_texbox v = new Validacion_texbox(); 

        public Registro_de_Materiales()
        {
            InitializeComponent();
        }
        void cargarcodmaterial()
        {
            int cod = mat_Neg.colocarcodmaterial() + 1;
            txtcodigo.Text = Convert.ToString(cod);
        }
        void cargarcategoria()
        {
            cnbcategoria.DataSource = mat_Neg.listar_Categoria_Repuestos();
            cnbcategoria.DisplayMember = "nombre";
            cnbcategoria.ValueMember = "codigo";
           
        }
        void listarmateriales()
        {
            dgv_materiales.DataSource = mat_Neg.ListarRepuestos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupdatos.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            nuevo();
            groupbuscar.Enabled = false;
            txtnombres.Focus();
            btncacelar.Enabled = true;
            //btnGuardar.Enabled = true;
            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            cargarcodmaterial();


        }
        void nuevo()
        {
            txtbuscar.Clear();
            txtprecio.Clear();
            txtnombres.Clear();
            txtcantidad.Clear();
            txtmarca.Clear();
            checkestado.Checked = false;
            txtcodigo.Clear();
            cargarcategoria();
            cnbcategoria.Text = "<<Seleccione>>";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtnombres.TextLength>=4&&txtprecio.Text != ""
                && txtcantidad.Text != "" && txtmarca.TextLength>=3&&
                cnbcategoria.Text != "<<Seleccione>>" && checkestado.Checked== true )
            {
                    registar_material();                                                         
            }
            else
            {
                MessageBox.Show("Llenar los campos correctamente para guardar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campos();
            }            
          
        }
        void validar_campos()
        {
            if (txtnombres.TextLength < 3)
            {
                validar_error.SetError(txtnombres, "Debes ingresar un nombre");
            }
            if (txtprecio.Text == "")
            {
                validar_error.SetError(txtprecio, "Debe ingresar el  precio");
            }
            if (txtcantidad.TextLength < 1)
            {
                validar_error.SetError(txtcantidad, "Debe ingresar la cantidad de Repuestos");
            }
            if (txtmarca.TextLength < 3)
            {
                validar_error.SetError(txtmarca, "Debe ingresar la marca del Repuesto");
            }
            if (cnbcategoria.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbcategoria, "Debe eligir una Categoria");
            }
            if (checkestado.Checked == false)
            {
                validar_error.SetError(checkestado, "Para guardar debe estar activo");
            }

        }
        public  void registar_material()
        { mate_Ent.Codigo  = txtcodigo.Text;
            mate_Ent.Nombre = txtnombres.Text;
            mate_Ent.Precio = Convert.ToDouble(txtprecio.Text);
            mate_Ent.Cantidad = Convert.ToInt32( txtcantidad.Text);
            mate_Ent.Marca = txtmarca.Text;
            mate_Ent.Categoria = Convert.ToInt32(cnbcategoria.SelectedValue);
            mate_Ent.Estado = checkestado.Checked;

            if(MessageBox.Show("¿Estas seguro que quieres guardar?",
                "Soft Cherhikcar V1.0", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
               if(mat_Neg.insertarMateriales(mate_Ent) > 0)
                {
                    MessageBox.Show("El repuesto ''"+mate_Ent.Nombre+"'' se ha guardado correctamente","Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    groupbuscar.Enabled = true;                   
                    btncacelar.Enabled = false;
                    nuevo();
                    btnGuardar.Enabled = false;                   
                    btnNuevo.Enabled = true;
                    validar_error.Clear();
                    listarmateriales();
                    groupdatos.Enabled = false;
                    btncacelar.Enabled = true;
                    groupbuscar.Enabled = true;
                    //tabNavigationPage2.Select();
                }
                else
                {
                   
                    MessageBox.Show("Error al guardar",
                        "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }           

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (groupdatos.Enabled == false)
            {
                MessageBox.Show("Debe buscar un registro para modificar",
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtnombres.TextLength >= 4 && txtprecio.Text != ""
                && txtcantidad.Text != "" && txtmarca.TextLength >= 3 &&
                cnbcategoria.Text != "<<Seleccione>>" && checkestado.Checked == true)
               
            {
                
                    modificar_Repuesto();
                  
                
            
            }
            else
            {
                MessageBox.Show("Antes de modificar debes ingresar datos validos", 
                    "Soft Cherhikcar V1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar_campos();
            }
           
            
        }   
        
        public void modificar_Repuesto()
        { mate_Ent.Codigo  = txtcodigo.Text;
            mate_Ent.Nombre = txtnombres.Text;
            mate_Ent.Precio = Convert.ToDouble(txtprecio.Text);
            mate_Ent.Cantidad = Convert.ToInt32( txtcantidad.Text);
            mate_Ent.Marca = txtmarca.Text;
            mate_Ent.Categoria = Convert.ToInt32(cnbcategoria.SelectedValue);
            mate_Ent.Estado = checkestado.Checked;

            if (MessageBox.Show("¿Estas seguro de modificar?", "Soft Cherhikcar V1.0", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 if(mat_Neg.ActualizarMateriales(mate_Ent) > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    groupdatos.Enabled = false;
                    nuevo();
                    btncacelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btncacelar.Enabled = false;
                    btnNuevo.Enabled = true;
                    groupbuscar.Enabled = true;
                    validar_error.Clear();
                    listarmateriales();
                    //tabNavigationPage2.Select();
                }
                else
                {

                    MessageBox.Show("Error al modificar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevo();

                }
            }
         
       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             if (txtcodigo.Text!="")
            {
                eliminar_Repuesto();
                
               
            }
            else {
                MessageBox.Show("Debe buscar un codigo para eliminar", "Soft Cherhikcar V1.0", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }
        

        } 


        public void eliminar_Repuesto()
        { mate_Ent.Codigo = txtcodigo.Text;
           
            if (MessageBox.Show("¿Estas seguro de eliminar?", "Soft Cherhikcar V1.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (mat_Neg.eliminarRepuestos(mate_Ent) > 0)
                {
                    MessageBox.Show("Se ha eliminado correctamente", "Soft Cherhikcar V1.0", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupdatos.Enabled = false;
                    nuevo();
                    btncacelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btncacelar.Enabled = false;
                    btnNuevo.Enabled = true;
                    groupbuscar.Enabled = true;
                    validar_error.Clear();
                    listarmateriales();
                }
                else
                {

                    MessageBox.Show("Error al eliminar", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        
        }

        private void btncacelar_Click(object sender, EventArgs e)
        {
            groupdatos.Enabled = false;           
            groupbuscar.Enabled = true;
            nuevo();
            txtbuscar.Focus();
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
                btncacelar.Enabled = false;
            txtcodigo.Clear();           
            validar_error.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             
            if (txtbuscar.Text !="")
            {
                mate_Ent.Codigo = txtbuscar.Text;

                if (mat_Neg.Buscar_Repuestos(mate_Ent) == true) {
                    cargarcategoria();
                    txtcodigo.Text = mate_Ent.Codigo.ToString();
                    txtnombres.Text = mate_Ent.Nombre.ToString();
                    txtprecio.Text = mate_Ent.Precio.ToString();
                    txtcantidad.Text= mate_Ent.Cantidad.ToString();
                    txtmarca.Text = mate_Ent.Marca.ToString();
                    cnbcategoria.SelectedValue =  mate_Ent.Categoria;
                    checkestado.Checked = mate_Ent.Estado;

                    groupdatos.Enabled = true;
                    btnModificar.Enabled = true;
                    btncacelar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnNuevo.Enabled = false;                    
                    txtbuscar.Clear();
                    groupbuscar.Enabled = false;
                    validar_error.Clear();

                }
                else
                {
                    MessageBox.Show("El Usuario no existe", "Soft Cherhikcar V1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    groupdatos.Enabled = false;
                    txtbuscar.Clear();
                       }
            }
            else
            {
                MessageBox.Show("Ingresa un codigo para buscar", "Soft Cherhikcar V1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbusc_Click(object sender, EventArgs e)
        {
            if (txtbusc.Text == "")
            {
                listarmateriales();
            }

            else
            {
                mate_Ent.Codigo = txtbusc.Text;
                if (mat_Neg.BuscarRepuestos(mate_Ent).Rows.Count > 0)
                {
                    dgv_materiales.DataSource = mat_Neg.BuscarRepuestos(mate_Ent);


                }
                else
                {
                    MessageBox.Show("El Repuesto que busca no existe", "Soft Cherhikcar V1.0",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbuscar.Clear();
                    return;
                }


            }
        }

        private void Registro_de_Materiales_Load(object sender, EventArgs e)
        {
            cargarcategoria();
            cnbcategoria.Text = "<<Seleccione>>";
            listarmateriales();
            
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
           // v.Solo_Letras(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Letras(e);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void txtbusc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Solo_Numeros(e);
        }

        private void groupdatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.nuevo2;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.nuevo;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.guardar2;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.guardar;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Properties.Resources.modific2;
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = Properties.Resources.modificar;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.eliminar2;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
        }

        private void btncacelar_MouseHover(object sender, EventArgs e)
        {
            btncacelar.BackgroundImage = Properties.Resources.Cancel;
        }

        private void btncacelar_MouseLeave(object sender, EventArgs e)
        {
            btncacelar.BackgroundImage = Properties.Resources.Cancel1;
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImage = Properties.Resources.busc;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackgroundImage = Properties.Resources.buca2;
        }

        private void btnbusc_MouseHover(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.busc;
        }

        private void btnbusc_MouseLeave(object sender, EventArgs e)
        {
            btnbusc.BackgroundImage = Properties.Resources.buca2;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtnombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtnombres.TextLength < 3)
            {
                validar_error.SetError(txtnombres, "Debes ingresar un nombre");
            }
            else
            {
                validar_error.SetError(txtnombres, null);
            }
        }

        private void txtprecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtprecio.Text == "")
            {
                validar_error.SetError(txtprecio, "Debe ingresar el precio");
            }
            else
            {
                validar_error.SetError(txtprecio, null);
            }
        }

        private void txtcantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtcantidad.TextLength < 1)
            {
                validar_error.SetError(txtcantidad, "Debe ingresar la cantidad de Repuestos");
            }
            else
            {
                validar_error.SetError(txtcantidad, null);
            }
        }

        private void txtmarca_Validating(object sender, CancelEventArgs e)
        {
            if (txtmarca.TextLength < 3)
            {
                validar_error.SetError(txtmarca, "Debe ingresar la marca del Repuesto");
            }
            else
            {
                validar_error.SetError(txtmarca, null);
            }
        }

        private void cnbcategoria_Validating(object sender, CancelEventArgs e)
        {
            if (cnbcategoria.Text == "<<Seleccione>>")
            {
                validar_error.SetError(cnbcategoria, "Debe eligir una Categoria");
            }
            else
            {
                validar_error.SetError(cnbcategoria, null);
            }
        }

        private void checkestado_Validating(object sender, CancelEventArgs e)
        {
            if (checkestado.Checked == false)
            {
                validar_error.SetError(checkestado, "Para guardar debe estar activo");
            }
            else
            {
                validar_error.SetError(checkestado, null);
            }
        }
    }
  }
    

