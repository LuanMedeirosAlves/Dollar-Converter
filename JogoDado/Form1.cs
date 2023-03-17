namespace JogoDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorAtual = Convert.ToDouble(textBox2.Text);
            double valorDiaAnterior = Convert.ToDouble(textBox1.Text);

            double diferenca = Math.Round(valorDiaAnterior - valorAtual, 2);
            double porcetangemSobreValorAnterior = valorDiaAnterior/diferenca;
            //double porcentagemSobreDiaAnterior = 100 - (valorAtual / valorDiaAnterior)*100;

            if (porcetangemSobreValorAnterior >= 5)
            {
                label6.Text = "Dolar com ótimo preço, comprar!";
            }
            
            double valorASerConvertidoParaDolar = Convert.ToDouble(textBox3.Text);
            double valorConvertidoParaDolar = Math.Round(valorASerConvertidoParaDolar / valorAtual, 2);
            label4.Text = valorConvertidoParaDolar.ToString("US$: 0"); 
        }
    }
}