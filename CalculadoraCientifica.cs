using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {

        public void CalcularOperacoesCientificas()
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
                    }
                }
            }
        }
        public void CalcularPotencia()
        {
            Resultado = Math.Pow(Convert.ToDouble(Valor1), 2);
            Valor2 = null;
            OperacaRealizada = $"{Valor1}² = {Resultado}";

            gravarHistorico(OperacaRealizada);
            defineNovaOperacaoEmCurso();
            OperacaoEmMemoria = null;
            TxtOperacaoEmCurso = $"{Resultado}";

        }

        internal void CalcularFracao()
        {
            Resultado = 1/Valor1;
            Valor2 = null;
            OperacaRealizada = $"1/{Valor1} = {Resultado}";

            gravarHistorico(OperacaRealizada);
            defineNovaOperacaoEmCurso();
            OperacaoEmMemoria = null;
            TxtOperacaoEmCurso = $"{Resultado}";
        }

        internal void CalcularRaizQuadrada()
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

                gravarHistorico(OperacaRealizada);
                defineNovaOperacaoEmCurso();
                OperacaoEmMemoria = null;
                TxtOperacaoEmCurso = $"{Resultado}";
            }
        }
    }
}
