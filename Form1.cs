﻿using System;
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

        List<string> listaHistorico = new List<string>();
        StringBuilder stringHistorico = new StringBuilder();

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
            limparTudo();
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '+';
            calculadora.TxtResultado = txtResultado.Text;
            calculadora.validaValores();
            preencherTxtOperacaoEmCurso();
        }
      
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '-';
            calculadora.TxtResultado = txtResultado.Text;
            calculadora.validaValores();
            preencherTxtOperacaoEmCurso();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '*';
            calculadora.TxtResultado = txtResultado.Text;
            calculadora.validaValores();
            preencherTxtOperacaoEmCurso();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '/';
            calculadora.TxtResultado = txtResultado.Text;
            calculadora.validaValores();
            preencherTxtOperacaoEmCurso();
        }
        
        private void btnResultado_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = null;
            calculadora.TxtResultado = txtResultado.Text;
            calculadora.encontraResultado(calculadora.Operacao);
            preencherTxtOperacaoEmCurso();
        }


        //TO DO: AJUSTAR MÉTODO FRAÇACO E PASSAR PARA A CLASSE CALCULADORA
        private void btnFracao_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '/';
            calculadora.OperacaoEmMemoria = calculadora.Operacao;
            calculadora.TxtResultado = txtResultado.Text;
            if (calculadora.Valor1 == null)
                if (calculadora.validarPrimeiroValorDigitado())
                {
                    calculadora.Valor2 = calculadora.Valor1;
                    calculadora.Valor1 = 1;
                    calculadora.calcularOperacoes();
                }
        }

        // AJUSTAR MÉTODO DE POTÊNCIA E EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = '*';
            calculadora.OperacaoEmMemoria = calculadora.Operacao;
            calculadora.TxtResultado = txtResultado.Text;
            if (calculadora.Valor1 == null)
            {
                if (calculadora.validarPrimeiroValorDigitado())
                {
                    calculadora.Valor2 = calculadora.Valor1;
                    calculadora.calcularOperacoes();
                }
            }

            txtResultado.Text = calculadora.TxtResultado;
            txtOperacaoEmCurso.Text = calculadora.TxtOperacaoEmCurso;
        }

        // AJUSTAR MÉTODO DE RAIZ QUADRADA E A EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            calculadora.Operacao = 'V';
            calculadora.OperacaoEmMemoria = calculadora.Operacao;
            if (calculadora.Valor1 == null)
                if (calculadora.validarPrimeiroValorDigitado())
                {
                    calculadora.calcularOperacoes();
                }
        }

        // AJUSTAR MÉTODO DE PORCENTO E A EXIBIÇÃO DE SEU RESULTADO PELA CLASSE CALCULADORA
        private void btnPorcento_Click(object sender, EventArgs e)
        {
            if (calculadora.OperacaoEmMemoria == null)
               MessageBox.Show("Digite uma operãção válida.\nPor exemplo: '100+10%' ou '100*20%'");
                
            else if (calculadora.Valor1 != null & calculadora.OperacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                calculadora.Valor2 = double.Parse(this.txtResultado.Text);
                if (calculadora.OperacaoEmMemoria != '*')
                {
                    calculadora.Valor2 = (calculadora.Valor2 / 100) * calculadora.Valor1;
                    calculadora.Operacao = null;
                    calculadora.calcularOperacoes();
                }
                else
                {
                    calculadora.Valor2 = (calculadora.Valor2 / 100);
                    calculadora.Operacao = null;
                    calculadora.calcularOperacoes();
                }
                calculadora.Valor1 = null;
            }                
        }
        
  
        /*
        private void calcularOperacoes()
        {
            switch (calculadora.OperacaoEmMemoria)
            {              
                case '²':
                    calculadora.Resultado = calculadora.Valor1 * calculadora.Valor2;
                    calculadora.OperacaoEmMemoria = '*';
                    calculadora.Operacao = null;
                    operacaRealizada = $"{calculadora.Valor1} {calculadora.OperacaoEmMemoria} {calculadora.Valor2} = {calculadora.Resultado}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;

                case 'V':
                    calculadora.Resultado = Math.Sqrt(Convert.ToDouble(calculadora.Valor1));
                    //calculadora.OperacaoEmMemoria = null;
                    calculadora.Operacao = null;
                    operacaRealizada = $"²V{calculadora.Valor1} = {calculadora.Resultado}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtHistorico(listaHistorico);
                    this.txtOperacaoEmCurso.Text = calculadora.Resultado.ToString();
                    calculadora.Valor1 = calculadora.Resultado;
                    calculadora.Valor2 = null;
                    calculadora.OperacaoEmMemoria = calculadora.Operacao;
                    break;
            }
        }
     
        */


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
            txtResultado.Text = calculadora.TxtResultado;
            txtOperacaoEmCurso.Text = calculadora.TxtOperacaoEmCurso;
        }


        //IMPLANTADO MÉTODO LIMPARTUDO()
        private void limparTudo()
        {
            this.txtOperacaoEmCurso.Text = "";
            this.txtResultado.Text = "";
            calculadora.Operacao = null;
            calculadora.Valor1 = null;
            calculadora.Valor2 = null;
            calculadora.Resultado = null;
            calculadora.OperacaoEmMemoria = null;
            txtHistórico.Clear();
            stringHistorico.Clear();
            listaHistorico.Clear();
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
            // Se não for botão de controle( como o botão de apagar ou delete) ou um número ou virgula
            if(!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar) & e.KeyChar != ',')
            {
                if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                {
                    calculadora.Operacao = e.KeyChar;
                    calculadora.validaValores();
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
                calculadora.encontraResultado(calculadora.Operacao);
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


