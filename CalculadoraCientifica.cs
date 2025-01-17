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
    }
}
