using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmPrincipal : Form
    {
        //ATRIBUTO
        private List<Articulo> listaArticulo;

        //CONSTRUCTOR
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //EVENTO
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
        }

        //EVENTO
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null) 
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
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

        //METODO
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //METODO
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
        }

        //EVENTO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaArticulo alta = new frmAltaArticulo();
                alta.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un artículo para modificar", "¡ATENCIÓN!");
                }
                else
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un artículo para eliminar", "¡ATENCIÓN!");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que quiere eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //METODO para validar filtro de busqueda avanzado
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                lblErrorCampo.Text = "Seleccione el campo a filtrar";
                return true;
            }
            else
            {
                lblErrorCampo.Text = "";
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                lblErrorCriterio.Text = "Seleccione el criterio a filtrar";
                return true;
            }
            else
            {
                lblErrorCriterio.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
            {
                MessageBox.Show("El filtro se encuentra vacio, escriba algo para continuar", "¡ATENCIÓN!");
                return true;
            }
            return false;
        }

        //EVENTO
        private void btnRefrescarDgv_Click(object sender, EventArgs e)
        {
            cboCampo.SelectedIndex = -1;
            lblErrorCampo.Text = "";
            cboCriterio.SelectedIndex = -1;
            lblErrorCriterio.Text = "";
            cargar();
        }

        //EVENTO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listafiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Codigo.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listafiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            ocultarColumnas();
        }

        //EVENTO
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado;
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un artículo para ver el detalle del mismo", "¡ATENCIÓN!");
                }
                else
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
                    detalle.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Comienza con");
            cboCriterio.Items.Add("Termina con");
            cboCriterio.Items.Add("Contiene");
        }
    }
}
