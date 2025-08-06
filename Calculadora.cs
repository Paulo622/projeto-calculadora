namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Validação de Campos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de somar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para a execução se algum campo estiver vazio
            }

            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Soma e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            //Validação de Campos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de subtrair.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para a execução se algum campo estiver vazio
            }

            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Soma e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();


        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 / numero2).ToString();
        }

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }
    }
}
