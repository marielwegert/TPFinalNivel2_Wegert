using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        //ATRIBUTO
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        //CONSTRUCTOR
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        //SOBRECARGA CONSTRUCTOR
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lblArticulo.Text = "Mdificar Artículo";
            Text = "Mdificar Artículo";
        }

        //EVENTO cuando toco btn cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //EVENTO cuando toco el btn aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarBtnAceptar())
                    return;

                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente");
                }

                if (archivo != null && !(txtImagenUrl.Text.ToLower().Contains("http"))) 
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["articulo-app"] + archivo.SafeFileName);
                }


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //METODO para validar que los campos obligatorios no esten vacios cuando se apreta click en Aceptar
        private bool validarBtnAceptar()
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.Red;
                lblErrorCodigo.Text = "Escriba el código del artículo";
                return true;
            }
            else
            {
                txtCodigo.BackColor = System.Drawing.SystemColors.Control;
                lblErrorCodigo.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.Red;
                lblErrorNombre.Text = "Escriba el nombre del artículo";
                return true;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                lblErrorNombre.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.Red;
                lblErrorDescripcion.Text = "Escriba la descripción del artículo";
                return true;
            }
            else
            {
                txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
                lblErrorDescripcion.Text = "";
            }

            if (cboMarca.SelectedIndex < 0)
            {
                lblErrorMarca.Text = "Seleccione la marca";
                return true;
            }
            else
            {
                lblErrorMarca.Text = "";
            }

            if (cboCategoria.SelectedIndex < 0)
            {
                lblErrorCategoria.Text = "Seleccione la categoría";
                return true;
            }
            else
            {
                lblErrorCategoria.Text = "";
            }

            decimal numero;
            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !(decimal.TryParse(txtPrecio.Text, out numero))) //|| !(soloNumeros(txtPrecio.Text)))
            {
                txtPrecio.BackColor = Color.Red;
                lblErrorPrecio.Text = "Escriba el precio del artículo";
                return true;
            }
            else
            {
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
                lblErrorPrecio.Text = "";
            }
            return false;
        }

        //EVENTO
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegiocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegiocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                //Esto es para que los desplegables no aparezcan preseleccionados:
                cboCategoria.SelectedIndex = -1;
                cboMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        //METODO
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        //METODO
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
