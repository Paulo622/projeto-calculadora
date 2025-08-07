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
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de somar.");
                return; 
            }

            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.");
                return;
            }

           
            lblResultado.Text = (numero1 + numero2).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de subtrair.");
                return; 
            }

            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.");
                return;
            }

           
            lblResultado.Text = (numero1 - numero2).ToString();


        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de multiplicar.");
                return;

            }
            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.");
                return;
            }

           
            lblResultado.Text = (numero1 * numero2).ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, preencha ambos os números antes de dividir.");
                return;

            }
            double numero1, numero2;

            bool numero1Valido = double.TryParse(txtNumero1.Text, out numero1);
            bool numero2Valido = double.TryParse(txtNumero2.Text, out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                MessageBox.Show("Digite apenas números válidos nos campos.");
                return;
            }


            lblResultado.Text = (numero1 / numero2).ToString();

        }
        

        private void lblNumero1_Click(object sender, EventArgs e)
        {

        }
    }
}
