using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {

        public void CalcularPotencia()
        {
            if (this.Valor1 == null)
            {
                if (this.validarPrimeiroValorDigitado())
                {
                    this.Valor2 = this.Valor1;
                    this.calcularOperacoes(this.OperacaoEmMemoria);
                }
            }
        }

        internal void CalcularFracao()
        {
            if (Valor1 == null)
                if (validarPrimeiroValorDigitado())
                {
                    Valor2 = Valor1;
                    Valor1 = 1;
                    calcularOperacoes(OperacaoEmMemoria);
                }
        }

        internal void CalcularRaizQuadrada()
        {
            if (this.Valor1 == null)
                if (this.validarPrimeiroValorDigitado())
                {
                    //case 'V':
                    Resultado = Math.Sqrt(Convert.ToDouble(Valor1));
                    Valor2 = null;
                    OperacaRealizada = $"²V{Valor1} = {Resultado}";
                    
                    gravarHistorico(OperacaRealizada);
                    defineNovaOperacaoEmCurso();
                    OperacaoEmMemoria = null;
                    TxtOperacaoEmCurso = $"{Resultado}";
                    //break;
                }
        }
    }
}
