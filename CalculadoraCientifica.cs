using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        public void calcularOperacoesCientificas()
        {
            OperacaoEmMemoria = Operacao;
            if (Valor1 == null)
            {
                if (validarPrimeiroValorDigitado())
                {
                    switch(OperacaoEmMemoria)
                    {
                        case 'P':
                            CalcularPotencia();
                            break;
                        case 'F':
                            CalcularFracao();
                            break;
                        case 'R':
                            CalcularRaizQuadrada();
                            break;
                        /*case '%':
                            CalcularPorcentagem();
                            break; */
                    }
                    gravarHistorico(OperacaRealizada);
                    defineNovaOperacaoEmCurso();
                    OperacaoEmMemoria = null;
                    TxtOperacaoEmCurso = $"{Resultado}";
                }
            }
        }

        

        public void CalcularPotencia()
        {
            Resultado = Math.Pow(Convert.ToDouble(Valor1), 2);
            Valor2 = null;
            OperacaRealizada = $"{Valor1}² = {Resultado}";
        }

        public void CalcularFracao()
        {
            Resultado = 1/Valor1;
            Valor2 = null;
            OperacaRealizada = $"1/{Valor1} = {Resultado}";
        }

        public void CalcularRaizQuadrada()
        {
            /*
            if (Valor1 < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            else*/
            {
                Resultado = Math.Sqrt(Convert.ToDouble(Valor1));
                Valor2 = null;
                OperacaRealizada = $"²V{Valor1} = {Resultado}";
            }
        }


        //AJUSTAR O MÉTODO DE CALCULO DE PORCENTAGEM
        public void CalcularPorcentagem()
        {
             if (OperacaoEmMemoria == null)
                MessageBox.Show("Digite uma operãção válida.\nPor exemplo: '100+10%' ou '100*20%'");

             else if (Valor1 != null & OperacaoEmMemoria != null & TxtResultado != "")
             {
                 Valor2 = double.Parse(TxtResultado);
                 if (OperacaoEmMemoria != '*')
                 {
                     Valor2 = (Valor2 / 100) * Valor1;
                     Operacao = null;
                     calcularOperacoes(OperacaoEmMemoria);
                 }
                 else
                 {
                     Valor2 = (Valor2 / 100);
                     Operacao = null;
                     calcularOperacoes(OperacaoEmMemoria);
                 }
                 Valor1 = null;
             }
        }
    }
}
