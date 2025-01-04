using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Calculadora
    {
        public double? Valor1 { get; set; }
        public double? Valor2 { get; set; }
        public char? Operacao { get; set; }
        public double? Resultado { get; set; }
        public char? OperacaoEmMemoria { get; set; }

        public string TxtResultado { get; set; }
        public string TxtOperacaoEmCurso { get; set; }

        public void validaValores()
        {
            if (OperacaoEmMemoria == null)
                OperacaoEmMemoria = Operacao;
            if (Valor1 == null)
                validarPrimeiroValorDigitado();
            else
            {
                if (validarSegundoValorDigitado())
                {
                    Valor2 = double.Parse(TxtResultado);
                    TxtResultado = "";
                    calcularOperacoes();
                }
                else
                {
                    OperacaoEmMemoria = Operacao;
                    TxtOperacaoEmCurso = $"{Valor1} {OperacaoEmMemoria}";
                }
            }
        }

        public bool validarPrimeiroValorDigitado()
        {
            if (Valor1 == null & TxtResultado == "")
            {
                MessageBox.Show("Necessário digitar um valor para efetuar a operação.");
                return false;
            }
            else if (Valor1 == null & TxtResultado != "")
            {
                Valor1 = double.Parse(TxtResultado);
                TxtOperacaoEmCurso = $"{Valor1} {OperacaoEmMemoria}";
                TxtResultado = "";
                return true;
            }
            else
                return false;
        }

        public bool validarSegundoValorDigitado()
        {
            if (Valor2 == null & TxtResultado == "")
            {
                /*
                OperacaoEmMemoria = Operacao;
                TxtOperacaoEmCurso = $"{Valor1} {OperacaoEmMemoria}";
                */
                return false;
            }
            else if (Valor2 == null & TxtResultado != "")
            {
                /*
                Valor2 = double.Parse(TxtResultado);
                TxtResultado = "";
                */
                return true;
            }
            else
                return false;
        }


        public void calcularOperacoes()
        {
            switch (OperacaoEmMemoria)
            {
                case '+':
                    Resultado = Valor1 + Valor2;            
                    break;   
                case '-':
                    Resultado = Valor1 - Valor2;
                    break;
                case '*':
                    Resultado = Valor1 * Valor2;
                    break;
                case '/':
                    if (Valor2 != 0)
                    {
                        Resultado = Valor1 / Valor2;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        //limparTudo();
                        break;
                    }

                    /*
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
                    */
            }
            //operacaRealizada = $"{Valor1} {OperacaoEmMemoria} {Valor2} = {Resultado}";
            //gravarHistorico(operacaRealizada);
            definoNovaOperacaoEmCurso();
        }

        private void definoNovaOperacaoEmCurso()
        {
            TxtResultado = "";
            Valor1 = Resultado;
            Valor2 = null;
            OperacaoEmMemoria = Operacao;
            Operacao = null;
            TxtOperacaoEmCurso = $"{Valor1} {OperacaoEmMemoria}";
        }





    }
}
