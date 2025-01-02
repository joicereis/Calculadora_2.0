using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        string operacao = null;
        static double? primeiroValor = null;
        static double? segundoValor = null;
        static double? resultadoOperacao = null;
        static double? varResultado = null;
        string operacaoEmMemoria = null;
        static string operacaRealizada = null;

        List<string> listaHistorico = new List<string>();
        StringBuilder stringHistorico = new StringBuilder();
        string historico = "";

        // - * * 
        public frmCalculadora()
        {
            InitializeComponent();
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btnVirgula.Text);
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn0.Text);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn1.Text);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn2.Text);
        }
        private void btn3_Click_1(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn3.Text);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn4.Text);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn5.Text);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn6.Text);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn7.Text);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn8.Text);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            acumularValoresDigitados(this.btn9.Text);
        }

        private void acumularValoresDigitados(string valorDigitado)
        {
            if (valorDigitado == ",")
            {
                if (!this.txtResultado.Text.Contains(valorDigitado))
                    this.txtResultado.Text += ",";                    
            }
            else
                this.txtResultado.Text += valorDigitado;
        }


        // TO DO: AJUSTAR ESSE MÉTODO
        private void btnClear_Click(object sender, EventArgs e)
        {
            limparTudo();

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = "+";
            validaValores(operacao);
        }
      
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            operacao = "-";
            validaValores(operacao);
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operacao = "*";
            validaValores(operacao);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operacao = "/";
            validaValores(operacao);
        }
        private void validaValores(string operacao)
        {
            if (operacaoEmMemoria == null)
                operacaoEmMemoria = operacao;

            if (primeiroValor == null)
                validarPrimeiroValorDigitado();
            else
            {
                if (validarSegundoValorDigitado())
                {
                    calcularOperacoes();
                }
            }
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            operacao = null;
            if (primeiroValor != null & operacaoEmMemoria != null & segundoValor != null)
                calcularOperacoes();
            else if (primeiroValor != null & operacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                segundoValor = double.Parse(this.txtResultado.Text);
                calcularOperacoes();
            }
            else
                MessageBox.Show("Necessário digitar uma operação válida.");
            //operacao = null;
        }

        //TO DO: AJUSTAR ESSE MÉTODO
        private void btnFracao_Click(object sender, EventArgs e)
        {
            operacao = "1/x";
            operacaoEmMemoria = operacao;
            if (primeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    segundoValor = primeiroValor;
                    primeiroValor = 1;
                    calcularOperacoes();
                }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operacao = "x²";
            operacaoEmMemoria = operacao;
            if (primeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    segundoValor = primeiroValor;
                    calcularOperacoes();
                }
        }
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            operacao = "raiz";
            operacaoEmMemoria = operacao;
            if (primeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    calcularOperacoes();
                }
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            if (operacaoEmMemoria == null)
               MessageBox.Show("Digite uma operãção válida.\nPor exemplo: '100+10%' ou '100*20%'");
                
            else if (primeiroValor != null & operacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                segundoValor = double.Parse(this.txtResultado.Text);
                if (operacaoEmMemoria != "*")
                {
                    segundoValor = (segundoValor / 100) * primeiroValor;
                    operacao = null;
                    calcularOperacoes();
                }
                else
                {
                    segundoValor = (segundoValor / 100);
                    operacao = null;
                    calcularOperacoes();
                }
                primeiroValor = null;
                
            }                
        }
               
        private bool validarPrimeiroValorDigitado()
        {
            if (primeiroValor == null & this.txtResultado.Text == "")
            {
                MessageBox.Show("Necessário digitar um valor para efetuar a operação.");
                return false;
            }
            else if (primeiroValor == null & this.txtResultado.Text != "")
            {
                primeiroValor = double.Parse(this.txtResultado.Text);
                this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria}";
                this.txtResultado.Text = "";
                return true;
            }
            else
                return false;
        }

        private bool validarSegundoValorDigitado()
        {
            if (segundoValor == null & this.txtResultado.Text == "")
            {
                operacaoEmMemoria = operacao;
                this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria}";
                return false;
            }
            else if(segundoValor == null & this.txtResultado.Text != "")
            {
                segundoValor = double.Parse(this.txtResultado.Text);
                //this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria} {segundoValor}";
                this.txtResultado.Text = "";
                return true;
            }
            else
                return false;
        }
  
        private void calcularOperacoes()
        {
            switch (operacaoEmMemoria)
            {
                case "+":
                    resultadoOperacao = primeiroValor + segundoValor;
                    operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "-":
                    resultadoOperacao = primeiroValor - segundoValor;
                    operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "*":
                    resultadoOperacao = primeiroValor * segundoValor;
                    operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "/":
                    if(segundoValor != 0)
                    {
                        resultadoOperacao = primeiroValor / segundoValor;
                        operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                        gravarHistorico(operacaRealizada);
                        preencherTxtHistorico(listaHistorico);
                        preencherTxtOperacaoEmCurso();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        limparTudo();
                        break;
                    }
                case "1/x":
                    if (segundoValor != 0)
                    {
                        resultadoOperacao = primeiroValor / segundoValor;
                        operacaoEmMemoria = "/";
                        operacao = null;
                        operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                        gravarHistorico(operacaRealizada);
                        preencherTxtHistorico(listaHistorico);
                        preencherTxtOperacaoEmCurso();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        limparTudo();
                        break;
                    }
                case "x²":
                    resultadoOperacao = primeiroValor * segundoValor;
                    operacaoEmMemoria = "*";
                    operacao = null;
                    operacaRealizada = $"{primeiroValor} {operacaoEmMemoria} {segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    preencherTxtOperacaoEmCurso();
                    break;

                case "raiz":
                    resultadoOperacao = Math.Sqrt(Convert.ToDouble(primeiroValor));
                    //operacaoEmMemoria = null;
                    operacao = null;
                    operacaRealizada = $"²V{primeiroValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    this.txtOperacaoEmCurso.Text = resultadoOperacao.ToString();
                    primeiroValor = resultadoOperacao;
                    segundoValor = null;
                    operacaoEmMemoria = operacao;
                    break;
            }
        }
     
        private void gravarHistorico(string operacaRealizada)
        {
            listaHistorico.Add(operacaRealizada);
        }

        private void preencherTxtHistorico(List<string> listaHistorico)
        {
            stringHistorico.Clear();
            foreach (string itemLista in listaHistorico)
            {
                stringHistorico.AppendLine(itemLista);
            }
            txtHistórico.Text = stringHistorico.ToString();
        }

        private void preencherTxtOperacaoEmCurso()
        {
            this.txtResultado.Text = "";
            primeiroValor = resultadoOperacao;
            segundoValor = null;
            operacaoEmMemoria = operacao;
            operacao = null;
            this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria}";
        }

        private void limparTudo()
        {
            this.txtOperacaoEmCurso.Text = "";
            this.txtResultado.Text = "";
            operacao = null;
            primeiroValor = null;
            segundoValor = null;
            resultadoOperacao = null;
            operacaoEmMemoria = null;
            txtHistórico.Clear();
            stringHistorico.Clear();
            listaHistorico.Clear();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string valortxtResultado = txtResultado.Text;
            if(valortxtResultado.Length > 0)
            {
                txtResultado.Text = valortxtResultado.Remove(valortxtResultado.Length - 1);
            }
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
                        // Se não for botão de controle( como o botão de apagar ou delete) ou um número ou virgula
            if(!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != ',')
            {
                if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    //MessageBox.Show($"Você digitou o símbolo aritmético: {e.KeyChar}");
                    operacao = e.KeyChar.ToString();
                    validaValores(operacao);

                    txtResultado.Text = string.Empty;
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            //Se for digitado virgula, é verificado se já possui no txtResultado
            else if(e.KeyChar == ',' & txtResultado.Text.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                double valor = double.Parse(txtResultado.Text);
                valor = valor * -1;
                txtResultado.Text = valor.ToString();
            }
        }
    } 
        
}


