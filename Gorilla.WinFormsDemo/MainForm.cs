using Gorilla.WinFormsDemo.Models;
using Gorilla.WinFormsDemo.Services;
using Gorilla.BusinessLogic.Models;
using Gorilla.BusinessLogic.Services;

namespace Gorilla.WinFormsDemo
{
    public partial class MainForm : Form
    {
        private readonly ProductoService _productoService;
        private readonly FacturaService _facturaService;
        private List<Producto> _productos = new();
        public MainForm()
        {
            InitializeComponent();
            _productoService = new ProductoService();
            _facturaService = new FacturaService();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("Todas");
            cboCategoria.Items.Add("Reencauche");
            cboCategoria.Items.Add("Servicio");
            cboCategoria.SelectedIndex = 0;
        }
        private void CargarDatosEnGrid(IEnumerable<Producto> productos)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos.ToList();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Cargando datos...";
            _productos = _productoService.ObtenerProductosDemo();
            AplicarFiltroYCargar();
            lblStatus.Text = "Datos cargados.";
        }

        private async void btnCargarAsync_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Cargando datos (async)...";
            btnCargar.Enabled = false;
            btnCargarAsync.Enabled = false;

            try
            {
                _productos = await Task.Run(() =>
                {
                    // Simula una operación pesada (BD, API externa, etc.)
                    Thread.Sleep(2000);
                    return _productoService.ObtenerProductosDemo();
                });

                AplicarFiltroYCargar();
                lblStatus.Text = "Datos cargados (async).";
            }
            finally
            {
                btnCargar.Enabled = true;
                btnCargarAsync.Enabled = true;
            }
        }

        private void AplicarFiltroYCargar()
        {
            string categoria = cboCategoria.SelectedItem?.ToString() ?? "Todas";

            var filtrados = categoria == "Todas"
                ? _productos
                : _productoService.FiltrarPorCategoria(_productos, categoria);

            CargarDatosEnGrid(filtrados);
        }

        private void btnFacturaDemo_Click(object sender, EventArgs e)
        {
            var factura = _facturaService.CrearFacturaDemo();

            var mensaje =
                $"Factura: {factura.Numero}\n" +
                $"Fecha: {factura.Fecha:d}\n" +
                $"Cliente: {factura.Cliente}\n\n" +
                $"Total bruto: {factura.TotalBruto:C}\n" +
                $"Impuesto: {factura.Impuesto:C}\n" +
                $"Total neto: {factura.TotalNeto:C}";

            MessageBox.Show(mensaje, "Factura demo (BusinessLogic)", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
