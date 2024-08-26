namespace ActividadInvividual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComprarVideoJuegoButton_Click(object sender, EventArgs e)
        {
            if (ListaVideoJuegos.SelectedItem != null)
            {
                string CompraVideoJuego = ListaVideoJuegos.SelectedItem.ToString();

                MessageBox.Show($"Usted ha Comprado el VideoJuego: {CompraVideoJuego}");

                ListaVideoJuegos.Items.Remove(ListaVideoJuegos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por Favor. Seleccione un VideoJuego para Comprar :).");
            }
        }

        private void AñadirVideoJuegoButton_Click(object sender, EventArgs e)
        {
            string nuevoJuego = AñadirVideojuegoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nuevoJuego))
            {
                MessageBox.Show("Por favor. Ingrese el Nombre de un VideoJuego.");
                return;
            }

            if (ListaVideoJuegos.Items.Contains(nuevoJuego))
            {
                MessageBox.Show("E VideoJuego ya esta en la Lista.");
                return;
            }

            ListaVideoJuegos.Items.Add(nuevoJuego);
            MessageBox.Show($"El VideoJuego {nuevoJuego} ha sido Añadido con Exito a la Tienda.");
        }

        private void EliminarVideoJuegoButton_Click(object sender, EventArgs e)
        {
            if (ListaVideoJuegos.SelectedItem != null)
            {
                string EliminarVideoJuegos = ListaVideoJuegos.SelectedItem.ToString();

                DialogResult Confirmacion = MessageBox.Show(
                    $"¿Confirmas la Elimininación de: {EliminarVideoJuegos}?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Confirmacion == DialogResult.Yes)
                {
                    ListaVideoJuegos.Items.Remove(ListaVideoJuegos.SelectedItem);

                    MessageBox.Show($"El VideoJuego {EliminarVideoJuegos} ha sido Eliminado con Exito.");
                }
            }
            else
            {
                MessageBox.Show("Por Favor. Eliga un VideoJuego para eliminar");
            }
        }

        private void LimpiarVideoJuegoButton_Click(object sender, EventArgs e)
        {
            ListaVideoJuegos.Items.Clear();
        }

        private void AñadirDetallesButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                string nombre = form2.NombreVideojuego;
                decimal precio = form2.PrecioVideojuego;
                string consola = form2.ConsolasVideojuego;

                ListaVideoJuegos.Items.Add($"{nombre} - {consola} - ${precio}");
                MessageBox.Show($"Videojuego {nombre} se añadio con exito :).");
            }
        }
    }
}
