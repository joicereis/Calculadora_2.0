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
        Calculadora calculadora = new Calculadora();
        double? resultadoOperacao = null;
        double? varResultado = null;
        char? operacaoEmMemoria = null;
        string operacaRealizada = null;

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
            calculadora.Operacao = '+';
            validaValores(calculadora.Operacao);
        }
      
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '-';
            validaValores(calculadora.Operacao);
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '*';
            validaValores(calculadora.Operacao);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '/';
            validaValores(calculadora.Operacao);
        }
        private void validaValores(char? operacao)
        {
            if (operacaoEmMemoria == null)
                operacaoEmMemoria = operacao;

            if (calculadora.PrimeiroValor == null)
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
            calculadora.Operacao = null;
            encontraResultado(calculadora.Operacao);
        }

        private void encontraResultado(char? operacao)
        {
            if (calculadora.PrimeiroValor != null & operacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                calculadora.SegundoValor = double.Parse(this.txtResultado.Text);
                calcularOperacoes();
            }
            else
            {
                MessageBox.Show("Necessário digitar uma operação válida.");
                txtResultado.Clear();
            }
                
            //operacao = null;
        }

        //TO DO: AJUSTAR ESSE MÉTODO
        private void btnFracao_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '/';
            operacaoEmMemoria = calculadora.Operacao;
            if (calculadora.PrimeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    calculadora.SegundoValor = calculadora.PrimeiroValor;
                    calculadora.PrimeiroValor = 1;
                    calcularOperacoes();
                }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '²';
            operacaoEmMemoria = calculadora.Operacao;
            if (calculadora.PrimeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    calculadora.SegundoValor = calculadora.PrimeiroValor;
                    calcularOperacoes();
                }
        }
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = 'V';
            operacaoEmMemoria = calculadora.Operacao;
            if (calculadora.PrimeiroValor == null)
                if (validarPrimeiroValorDigitado())
                {
                    calcularOperacoes();
                }
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            if (operacaoEmMemoria == null)
               MessageBox.Show("Digite uma operãção válida.\nPor exemplo: '100+10%' ou '100*20%'");
                
            else if (calculadora.PrimeiroValor != null & operacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                calculadora.SegundoValor = double.Parse(this.txtResultado.Text);
                if (operacaoEmMemoria != '*')
                {
                    calculadora.SegundoValor = (calculadora.SegundoValor / 100) * calculadora.PrimeiroValor;
                    calculadora.Operacao = null;
                    calcularOperacoes();
                }
                else
                {
                    calculadora.SegundoValor = (calculadora.SegundoValor / 100);
                    calculadora.Operacao = null;
                    calcularOperacoes();
                }
                calculadora.PrimeiroValor = null;
            }                
        }
               
        private bool validarPrimeiroValorDigitado()
        {
            if (calculadora.PrimeiroValor == null & this.txtResultado.Text == "")
            {
                MessageBox.Show("Necessário digitar um valor para efetuar a operação.");
                return false;
            }
            else if (calculadora.PrimeiroValor == null & this.txtResultado.Text != "")
            {
                calculadora.PrimeiroValor = double.Parse(this.txtResultado.Text);
                this.txtOperacaoEmCurso.Text = $"{calculadora.PrimeiroValor} {operacaoEmMemoria}";
                this.txtResultado.Text = "";
                return true;
            }
            else
                return false;
        }

        private bool validarSegundoValorDigitado()
        {
            if (calculadora.SegundoValor == null & this.txtResultado.Text == "")
            {
                operacaoEmMemoria = calculadora.Operacao;
                this.txtOperacaoEmCurso.Text = $"{calculadora.PrimeiroValor} {operacaoEmMemoria}";
                return false;
            }
            else if(calculadora.SegundoValor == null & this.txtResultado.Text != "")
            {
                calculadora.SegundoValor = double.Parse(this.txtResultado.Text);
                //this.txtOperacaoEmCurso.Text = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor}";
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
                case '+':
                    resultadoOperacao = calculadora.PrimeiroValor + calculadora.SegundoValor;
                    operacaRealizada = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;
                case '-':
                    resultadoOperacao = calculadora.PrimeiroValor - calculadora.SegundoValor;
                    operacaRealizada = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;
                case '*':
                    resultadoOperacao = calculadora.PrimeiroValor * calculadora.SegundoValor;
                    operacaRealizada = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    break;
                case '/':
                    if(calculadora.SegundoValor != 0)
                    {
                        resultadoOperacao = calculadora.PrimeiroValor / calculadora.SegundoValor;
                        operacaRealizada = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor} = {resultadoOperacao}";
                        gravarHistorico(operacaRealizada);
                        preencherTxtOperacaoEmCurso();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        limparTudo();
                        break;
                    }
                case '²':
                    resultadoOperacao = calculadora.PrimeiroValor * calculadora.SegundoValor;
                    operacaoEmMemoria = '*';
                    calculadora.Operacao = null;
                    operacaRealizada = $"{calculadora.PrimeiroValor} {operacaoEmMemoria} {calculadora.SegundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;

                case 'V':
                    resultadoOperacao = Math.Sqrt(Convert.ToDouble(calculadora.PrimeiroValor));
                    //operacaoEmMemoria = null;
                    calculadora.Operacao = null;
                    operacaRealizada = $"²V{calculadora.PrimeiroValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    this.txtOperacaoEmCurso.Text = resultadoOperacao.ToString();
                    calculadora.PrimeiroValor = resultadoOperacao;
                    calculadora.SegundoValor = null;
                    operacaoEmMemoria = calculadora.Operacao;
                    break;
            }
        }
     
        private void gravarHistorico(string operacaRealizada)
        {
            listaHistorico.Add(operacaRealizada);
            preencherTxtHistorico(listaHistorico);
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
            calculadora.PrimeiroValor = resultadoOperacao;
            calculadora.SegundoValor = null;
            operacaoEmMemoria = calculadora.Operacao;
            calculadora.Operacao = null;
            this.txtOperacaoEmCurso.Text = $"{calculadora.PrimeiroValor} {operacaoEmMemoria}";
        }

        private void limparTudo()
        {
            this.txtOperacaoEmCurso.Text = "";
            this.txtResultado.Text = "";
            calculadora.Operacao = null;
            calculadora.PrimeiroValor = null;
            calculadora.SegundoValor = null;
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
                    calculadora.Operacao = e.KeyChar;
                    validaValores(calculadora.Operacao);
                    txtResultado.Clear();
                    e.Handled = true;
                }                
                else
                {
                    e.Handled = true;
                }
            }

            else if (e.KeyChar == (char)Keys.Enter)
            //Converte Keys.Enter para char para fazer a comparação já que o Enter é enum e o KeyChar é do tipo char
            {
                calculadora.Operacao = null;
                MessageBox.Show("Tecla Enter pressionada!");
                encontraResultado(calculadora.Operacao);
                txtResultado.Clear();
                e.Handled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
    } 
        
}


