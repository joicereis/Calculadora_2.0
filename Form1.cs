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
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();

        public frmCalculadora()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button botao = sender as System.Windows.Forms.Button;
            acumularValoresDigitados(botao.Text);
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
            buscaValidarValores();
        }
      
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '-';
            buscaValidarValores();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '*';
            buscaValidarValores();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '/';
            buscaValidarValores();
        }
        
        private void btnResultado_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = null;
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.encontraResultado(calculadoraCientifica.Operacao);
            preencherTxtOperacaoEmCurso();
        }
              
        private void btnFracao_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = 'F';
            validaOperacoesCientificas();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = 'P';
            validaOperacoesCientificas();
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = 'R';
            validaOperacoesCientificas();
        }

        // AJUSTAR MÉTODO DE PORCENTO E A EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnPorcento_Click(object sender, EventArgs e)
        {
            calculadoraCientifica.Operacao = '%';
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.CalcularPorcentagem();
            preencherTxtOperacaoEmCurso();
        }

        private void buscaValidarValores()
        {
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.validaValores();
            preencherTxtOperacaoEmCurso();
        }

        private void validaOperacoesCientificas()
        {
            calculadoraCientifica.TxtResultado = txtResultado.Text;
            calculadoraCientifica.calcularOperacoesCientificas();
            preencherTxtOperacaoEmCurso();
        }
        private void preencherTxtOperacaoEmCurso()
        {
            txtResultado.Text = calculadoraCientifica.TxtResultado;
            txtOperacaoEmCurso.Text = calculadoraCientifica.TxtOperacaoEmCurso;
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


