using dominio;
using FontAwesome.Sharp;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion
{
    public partial class frmDetalleArticulo : Form
    {
        //ATRIBUTO
        private Articulo articulo;

        //CONSTRUCTOR
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        //EVENTO
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //EVENTO
        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegiocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                lblDetalleCodigo.Text = articulo.Codigo;
                lblDetalleNombre.Text = articulo.Nombre;
                lblDetalleDescripcion.Text = articulo.Descripcion;
                cargarImagen(articulo.ImagenUrl);
                lblDetalleCategoria.Text = articulo.Categoria.ToString();
                lblDetalleMarca.Text = articulo.Marca.ToString();
                lblDetallePrecio.Text = articulo.Precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
