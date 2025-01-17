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

        public string OperacaRealizada = null;

        public List<string> listaHistorico = new List<string>();
        public StringBuilder stringHistorico = new StringBuilder();


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
                    calcularOperacoes(OperacaoEmMemoria);
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


        public void calcularOperacoes(char? operacaoEmMemoria)
        {
            switch (operacaoEmMemoria)
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
                    
            }
            OperacaRealizada = $"{Valor1} {OperacaoEmMemoria} {Valor2} = {Resultado}";
            gravarHistorico(OperacaRealizada);
            defineNovaOperacaoEmCurso();
        }

        public void defineNovaOperacaoEmCurso()
        {
            TxtResultado = "";
            Valor1 = Resultado;
            Valor2 = null;
            OperacaoEmMemoria = Operacao;
            Operacao = null;
            TxtOperacaoEmCurso = $"{Valor1} {OperacaoEmMemoria}";
        }

        public void encontraResultado(char? operacao)
        {
            if (Valor1 != null & OperacaoEmMemoria != null & TxtResultado != "")
            {
                Valor2 = double.Parse(TxtResultado);
                calcularOperacoes(OperacaoEmMemoria);
            }
            else
            {
                MessageBox.Show("Necessário digitar uma operação válida.");
                TxtResultado = "";
            }
        }

        public void gravarHistorico(string operacaRealizada)
        {
            listaHistorico.Add(operacaRealizada);
            preencherTxtHistorico(listaHistorico);
        }

        public void preencherTxtHistorico(List<string> listaHistorico)
        {
            stringHistorico.Clear();
            foreach (string itemLista in listaHistorico)
            {
                stringHistorico.AppendLine(itemLista);
            }
            //txtHistórico.Text = stringHistorico.ToString();
        }

        public void limparTudo()
        {
            Operacao = null;
            Valor1 = null;
            Valor2 = null;
            Resultado = null;
            OperacaoEmMemoria = null;
            stringHistorico.Clear();
            listaHistorico.Clear();
        }
    }
}
