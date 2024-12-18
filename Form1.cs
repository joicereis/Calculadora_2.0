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

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        static string operacao = "";
        static double? primeiroValor = null;
        static double? segundoValor = null;
        static double? resultadoOperacao = null;
        static string operacaoEmMemoria = null;
        static string operacaRealizada = null;

        List<string> listaHistorico = new List<string>();
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
                if (this.txtResultado.Text.Contains(valorDigitado))
                {
                    this.txtResultado.Text += "";
                }
                else
                    this.txtResultado.Text += ",";
            }
            else
                this.txtResultado.Text += valorDigitado;
        }


        // AJUSTAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            limparTudo();

        }
        //12/12 - noite
        private void btnSoma_Click(object sender, EventArgs e)
        {
                operacao = "+";
                if (operacaoEmMemoria == null)
                {
                    operacaoEmMemoria = operacao;
                }
                validaNumerosDigitados();

        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (primeiroValor != null & operacaoEmMemoria != null & segundoValor != null)
            {
                calcularOperacoes(primeiroValor, segundoValor);
            }
            else if(primeiroValor != null & operacaoEmMemoria != null & this.txtResultado.Text != "")
            {
                segundoValor = double.Parse(this.txtResultado.Text);
                calcularOperacoes(primeiroValor, segundoValor);
            }
            else
            {
                MessageBox.Show("Necessário digitar uma operação válida.");
            }
            operacao = null;
        }


        //12/12
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            operacao = "-";
            if (operacaoEmMemoria == null)
            {
                operacaoEmMemoria = operacao;
            }
            validaNumerosDigitados();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operacao = "*";
            if (operacaoEmMemoria == null)
            {
                operacaoEmMemoria = operacao;
            }
            validaNumerosDigitados();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operacao = "/";
            if (operacaoEmMemoria == null)
            {
                operacaoEmMemoria = operacao;
            }
            validaNumerosDigitados();
        }



        private void btnFracao_Click(object sender, EventArgs e)
        {/*
            operacao = "1/x";
            preencherElementosDoVetor(operacao, vetCalculo);
            preencherTxtOperacaoEmCurso();
            limparVetor();
            limparAcumulo(); */
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {/*
            operacao = "x²";
            preencherElementosDoVetor(operacao, vetCalculo);
            preencherTxtOperacaoEmCurso();
            limparVetor();
            limparAcumulo(); */
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {/*
            operacao = "raiz";
            /*
            preencherElementosDoVetor(operacao, vetCalculo);
            preencherTxtOperacaoEmCurso();
            limparVetor();
            limparAcumulo();
            */
        }
        
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            exibirHistorico();
        }

        
        private void btnPorcento_Click(object sender, EventArgs e)
        {/*
            operacao = "%";
            if (vetCalculo[0] != "" & vetCalculo[1] != "" & nroDigitado != "")
            {

            }
            */
            
        }



        //17/12
        private void validaNumerosDigitados()
        {

            if (this.txtResultado.Text == "" & primeiroValor == null)
            {
                MessageBox.Show("Necessário digitar um valor para efetuar a operação.");
            }
            else if (this.txtResultado.Text != "" & primeiroValor == null)
            {
                primeiroValor = double.Parse(this.txtResultado.Text);
                this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria}";
                this.txtResultado.Text = "";
            }
            else if (primeiroValor != null & segundoValor == null)
            {
                if (this.txtResultado.Text == "")
                {
                    operacaoEmMemoria = operacao;
                    this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria}";
                }
                else
                {
                    segundoValor = double.Parse(this.txtResultado.Text);
                    //this.txtOperacaoEmCurso.Text = $"{primeiroValor} {operacaoEmMemoria} {segundoValor}";
                    this.txtResultado.Text = "";
                    calcularOperacoes(primeiroValor, segundoValor);
                }
            }
        }

        //17/12
        private void calcularOperacoes(double? primeiroValor, double? segundoValor)
        {
            switch (operacaoEmMemoria)
            {
                case "+":
                    resultadoOperacao = primeiroValor + segundoValor;
                    operacaRealizada = $"{primeiroValor}{operacaoEmMemoria}{segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "-":
                    resultadoOperacao = primeiroValor - segundoValor;
                    operacaRealizada = $"{primeiroValor}{operacaoEmMemoria}{segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "*":
                    resultadoOperacao = primeiroValor * segundoValor;
                    operacaRealizada = $"{primeiroValor}{operacaoEmMemoria}{segundoValor} = {resultadoOperacao}";
                    gravarHistorico(operacaRealizada);
                    preencherTxtOperacaoEmCurso();
                    break;
                case "/":
                    if(segundoValor != 0)
                    {
                        resultadoOperacao = primeiroValor / segundoValor;
                        operacaRealizada = $"{primeiroValor}{operacaoEmMemoria}{segundoValor} = {resultadoOperacao}";
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
            }
        }

        /*

        //12/12
        private void preencherElementosDoVetor(string operacao, string[] vetCalculo)
        {
            if (vetCalculo[0] == "" & nroDigitado != "" & operacao != "=")
            {
                vetCalculo[0] = nroDigitado;
                vetCalculo[1] = operacao;
                if (operacao == "1/x" || operacao == "x²" || operacao == "raiz" || operacao == "%" )
                {
                    calcularOperacaoEmCurso(vetCalculo);
                }
                limparAcumulo();
            }
            else if (vetCalculo[0] != "" & vetCalculo[2] == "" & operacao != "=")
            {
                if (nroDigitado == "") //& operacao != "="
                {
                    vetCalculo[1] = operacao;
                    if (operacao == "1/x" || operacao == "x²" || operacao == "raiz" || operacao == "%")
                    {
                        calcularOperacaoEmCurso(vetCalculo);
                    }
                }
                else if (nroDigitado != "") //& operacao != "="
                {
                    vetCalculo[2] = nroDigitado;
                    vetCalculo[3] = operacao;
                    calcularOperacaoEmCurso(vetCalculo);
                    limparAcumulo();
                }
            }
            else if(vetCalculo[0] != "" & vetCalculo[1] != "" & operacao == "=")
            {
                if (nroDigitado != "") //& operacao != "="
                {
                    vetCalculo[2] = nroDigitado;
                    vetCalculo[3] = operacao;
                    calcularOperacaoEmCurso(vetCalculo);
                    limparAcumulo();
                    //vetCalculo[1] = "";
                }
            }          
        }
        */


        /*
        //12/12
        private void calcularOperacaoEmCurso(string[] vetCalculo)
        {
            double valorUM = Convert.ToDouble(vetCalculo[0]);
            string operacaoEmCurso = vetCalculo[1];
            if(vetCalculo[2] != "")
            {
                double valorDois = Convert.ToDouble(vetCalculo[2]);
            }
            string resultado = "";

            switch (operacaoEmCurso)
            {
                case "+":
                    resultado = (valorUM + valorDois).ToString();
                    //gravarHistorico(vetCalculo, resultado);
                    reordenarVetor(resultado, vetCalculo);
                    break;

                case "-":
                    resultado = (valorUM - valorDois).ToString();
                    //gravarHistorico(vetCalculo, resultado);
                    reordenarVetor(resultado, vetCalculo);
                    break;

                case "*":
                    resultado = (valorUM * valorDois).ToString();
                    //gravarHistorico(vetCalculo, resultado);
                    reordenarVetor(resultado, vetCalculo);
                    break;

                case "/":
                    validaDivisaoPorZero(vetCalculo, valorUM, valorDois);
                    break;

                case "1/x":
                    if(valorUM == 0)
                    {
                        resultado = "Não é possível divisão por zero";
                       // gravarHistorico(vetCalculo, resultado);
                        limparPosicoesVetCalculo(vetCalculo);
                        this.txtOperacaoEmCurso.Clear();
                        this.txtResultado.Clear();
                        this.txtResultado.Text = resultado.ToString();
                    }else
                        resultado = (1/valorUM).ToString();
                    break;

                case "x²":
                    resultado = Math.Pow(valorUM, 2).ToString();
                    //gravarHistorico(vetCalculo, resultado);
                    reordenarVetor(resultado, vetCalculo);
                    break;

                case "raiz":
                    resultado = Math.Sqrt(valorUM).ToString();
                    //gravarHistorico(vetCalculo, resultado);
                    reordenarVetor(resultado, vetCalculo);
                    break;
            }
            operacao = "";
        }
        */

        private void gravarHistorico(string operacaRealizada)
        {
            listaHistorico.Add(operacaRealizada);
        }

        //12/12
        /*
        private void gravarHistorico(string[] vetCalculo, string resultado)
        {
            ultimaOperacao = $"{vetCalculo[0]} {vetCalculo[1]} {vetCalculo[2]} = {resultado}";
            listaHistorico.Add(ultimaOperacao);            
        }
        */
        private void exibirHistorico()
        {
            foreach (string n in listaHistorico)
            {
                //ajustar exibição de linhas de historico
                historico += $"{n}       ";
            }
            MessageBox.Show(historico);
            historico = "";
        }
        

        /*
        //12/12 
        private void reordenarVetor(string resultado, string[] vetCalculo)
        {
            vetCalculo[0] =  resultado;
            vetCalculo[1] =  vetCalculo[3];
            vetCalculo[2] = "";
            vetCalculo[3] = "";
        }

        private void limparPosicoesVetCalculo(string[] vetCalculo)
        {
            for (int index = 0; index < vetCalculo.Length; index++)
                vetCalculo[index] = "";
        }*/

        /*
        private void preencherTxtOperacaoEmCurso()
        {
            this.txtOperacaoEmCurso.Text = $"{vetCalculo[0]}{vetCalculo[1]}";
            string tst = this.txtOperacaoEmCurso.Text;
        } */

        //17/12
        private void preencherTxtOperacaoEmCurso()
        {
            this.txtResultado.Text = "";
            primeiroValor = resultadoOperacao;
            segundoValor = null;
            operacaoEmMemoria = operacao;
            operacao = null;
            this.txtOperacaoEmCurso.Text = $"{primeiroValor}{operacaoEmMemoria}";
        }

        //17/12
        private void limparTudo()
        {
            this.txtOperacaoEmCurso.Text = "";
            this.txtResultado.Text = "";
            operacao = "";
            primeiroValor = null;
            segundoValor = null;
            resultadoOperacao = null;
            operacaoEmMemoria = null;
        }   

        /*
        private void validaDivisaoPorZero(string[] vetCalculo, double valorUM, double valorDois)
        {
            if (valorDois == 0) {
                string resultado = "Não é possível divisão por zero";
                gravarHistorico(vetCalculo, resultado);
                limparPosicoesVetCalculo(vetCalculo);
                this.txtOperacaoEmCurso.Clear();
                this.txtResultado.Clear();
                this.txtResultado.Text = resultado.ToString();
            }
            else
            {
                string resultado = (valorUM / valorDois).ToString();
                gravarHistorico(vetCalculo, resultado);
                reordenarVetor(resultado, vetCalculo);
            }    
        }*/

        /*
        private void limparAcumulo()
        {
            nroDigitado = "";
            this.txtResultado.Clear();
        }
        */

       
        /*
        private void limparVetor()
        {
            vetCalculo[0] = "";
            vetCalculo[1] = "";
            vetCalculo[2] = "";
            vetCalculo[3] = "";
        }
        */
    } 
        
}


