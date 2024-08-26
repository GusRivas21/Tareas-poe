namespace ActividadInvividual
{
    public partial class Form2 : Form
    {
        public string NombreVideojuego { get; private set; }
        public decimal PrecioVideojuego { get; private set; }
        public string ConsolasVideojuego { get; private set; }

        public Form2()
        {
            InitializeComponent();

            ConsolasVideoJuegoComboBox.Items.Add("PlayStation");
            ConsolasVideoJuegoComboBox.Items.Add("Xbox");
            ConsolasVideoJuegoComboBox.Items.Add("Nintendo Switch");
            ConsolasVideoJuegoComboBox.Items.Add("PC");
        }

        private void ConfirmarInformacionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreVideoJuegoTextBox.Text))
            {
                MessageBox.Show("Por favor. Ingres el Nombre de un VideoJuego.");
                return;
            }

            if (!decimal.TryParse(PrecioVideoJuegoTextBox.Text, out decimal precio))
            {
                MessageBox.Show("Por favor ingrese un precio válido.");
                return;
            }

            if (ConsolasVideoJuegoComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una consola de VideoJuegos.");
                return;
            }

            NombreVideojuego = NombreVideoJuegoTextBox.Text;
            PrecioVideojuego = precio;
            ConsolasVideojuego = ConsolasVideoJuegoComboBox.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
