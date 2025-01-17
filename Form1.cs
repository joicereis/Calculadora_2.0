using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //Calculadora calculadora = new Calculadora();
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();

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
                if (!txtResultado.Text.Contains(valorDigitado))
                    txtResultado.Text += ",";                    
            }
            else
                txtResultado.Text += valorDigitado;
        }

        // TO DO: AJUSTAR ESSE MÉTODO
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.limparTudo();
            txtOperacaoEmCurso.Text = "";
            txtResultado.Text = "";
            txtHistórico.Clear();
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '+';
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.validaValores();
            preencherTxtOperacaoEmCurso();
        }
      
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '-';
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.validaValores();
            preencherTxtOperacaoEmCurso();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '*';
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.validaValores();
            preencherTxtOperacaoEmCurso();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '/';
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.validaValores();
            preencherTxtOperacaoEmCurso();
        }
        
        private void btnResultado_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = null;
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.encontraResultado(calculadoraCientifica.Operacao);
            preencherTxtOperacaoEmCurso();
        }


        //TO DO: AJUSTAR MÉTODO FRAÇACO E PASSAR PARA A CLASSE CALCULADORA

        
        private void btnFracao_Click(object sender, EventArgs e)
        {

            calculadoraCientifica.Operacao = 'F';
            calculadoraCientifica.TxtResultado = txtResultado.Text;

            calculadoraCientifica.CalcularOperacoesCientificas();

            txtResultado.Text = calculadoraCientifica.TxtResultado;
            txtOperacaoEmCurso.Text = calculadoraCientifica.TxtOperacaoEmCurso;

        }

        // AJUSTAR MÉTODO DE POTÊNCIA E EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = 'P';
            calculadoraCientifica.TxtResultado = txtResultado.Text;

            calculadoraCientifica.CalcularOperacoesCientificas();

            txtResultado.Text = calculadoraCientifica.TxtResultado;
            txtOperacaoEmCurso.Text = calculadoraCientifica.TxtOperacaoEmCurso;

        }

        // AJUSTAR MÉTODO DE RAIZ QUADRADA E A EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {

            calculadoraCientifica.Operacao = 'R';
            calculadoraCientifica.TxtResultado = txtResultado.Text;

            calculadoraCientifica.CalcularOperacoesCientificas();

            txtResultado.Text = calculadoraCientifica.TxtResultado;
            txtOperacaoEmCurso.Text = calculadoraCientifica.TxtOperacaoEmCurso;

        }

        // AJUSTAR MÉTODO DE PORCENTO E A EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnPorcento_Click(object sender, EventArgs e)
        {

            /*
            if (calculadoraCientifica.OperacaoEmMemoria == null)
               MessageBox.Show("Digite uma operãção válida.\nPor exemplo: '100+10%' ou '100*20%'");
                
            else if (calculadoraCientifica.Valor1 != null & calculadoraCientifica.OperacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                calculadoraCientifica.Valor2 = double.Parse(this.txtResultado.Text);
                if (calculadoraCientifica.OperacaoEmMemoria != '*')
                {
                    calculadoraCientifica.Valor2 = (calculadoraCientifica.Valor2 / 100) * calculadoraCientifica.Valor1;
                    calculadoraCientifica.Operacao = null;
                    calculadoraCientifica.calcularOperacoes();
                }
                else
                {
                    calculadoraCientifica.Valor2 = (calculadoraCientifica.Valor2 / 100);
                    calculadoraCientifica.Operacao = null;
                    calculadoraCientifica.calcularOperacoes();
                }
                calculadoraCientifica.Valor1 = null;
            }          
            */
        }
        

        private void preencherTxtOperacaoEmCurso()
        {
            txtResultado.Text = calculadoraCientifica.TxtResultado;
            txtOperacaoEmCurso.Text = calculadoraCientifica.TxtOperacaoEmCurso;
        }

        //IMPLANTADO MÉTODO LIMPARTUDO()
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string valortxtResultado = txtResultado.Text;
            if(valortxtResultado.Length > 0)
            {
                txtResultado.Text = valortxtResultado.Remove(valortxtResultado.Length - 1);
            }
        }


        //PASSAR O KEYPRESS PARA A CLASSE CALCULADORA
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            //Converte Keys.Enter para char para fazer a comparação já que o Enter é enum e o KeyChar é do tipo char
            {
                calculadoraCientifica.Operacao = null;
                //MessageBox.Show("Tecla Enter pressionada!");
                calculadoraCientifica.TxtResultado = txtResultado.Text;
                calculadoraCientifica.encontraResultado(calculadoraCientifica.Operacao);
                preencherTxtOperacaoEmCurso();
                txtResultado.Clear();
                e.Handled = true;
            }

            // Se não for botão de controle( como o botão de apagar ou delete) ou um número ou virgula
            else if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != ',')
            {
                if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    calculadoraCientifica.Operacao = e.KeyChar;
                    calculadoraCientifica.TxtResultado = txtResultado.Text;
                    calculadoraCientifica.validaValores();
                    preencherTxtOperacaoEmCurso();
                    txtResultado.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnAtualizaHistorico_Click(object sender, EventArgs e)
        {
            txtHistórico.Text = calculadoraCientifica.stringHistorico.ToString();
            MessageBox.Show(calculadoraCientifica.stringHistorico.ToString());
        }

        private void frmCalculadora_Shown(object sender, EventArgs e)
        {
            txtResultado.Focus();
            HideCaret();
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(txtResultado.Handle);
        }

        private void txtResultado_Click(object sender, EventArgs e)
        {
            HideCaret();
        }
    } 
        
}


