using Exemplo.Classes;

namespace Exemplo
{
    public partial class Form1 : Form

    {
        Operacoes op;
        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Setar o valor
        public void setInputs()
        {
            op.setXFromInput(Double.Parse(inputTextX.Text));
            op.setYFromInput(Double.Parse(inputTextY.Text));

        }

        public void printResult(double x, double y, string operacao, double result)
        {
            string formatoSaida = "Resultado da "+operacao+ " entre " + x + "e " + y + " foi igual á: " + result;


            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.soma();
            printResult(op.getX(), op.getY(), "soma", result);


        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.subtracao();
            printResult(op.getX(), op.getY(), "subtração", result);


        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.multi();
            printResult(op.getX(), op.getY(), "multiplicação", result);


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.divisao();
            printResult(op.getX(), op.getY(), "divisão", result);


        }
        private void btnQuad_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.quadrado();
            printResult(op.getX(), op.getY(), "quadrado", result);


        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.raiz();
            printResult(op.getX(), op.getY(), "raiz quadrada", result);


        }
        private void btnPorc_Click(object sender, EventArgs e)
        {
            setInputs();
            double result = op.porcentagem();
            printResult(op.getX(), op.getY(), "porcentagem", result);


        }

    }
}
