using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraProgramador : CalculadoraCientifica
    {
        public string Binario { get; set; }
        public void calcularOperacoesProgramador()
        {
            OperacaoEmMemoria = Operacao;
            if (Valor1 == null)
            {
                if (validarPrimeiroValorDigitado())
                {
                    switch (OperacaoEmMemoria)
                    {
                        case 'B':
                            Binario = ConverterDecimalParaBinario(Convert.ToDouble(Valor1));
                            break;
                    }
                    gravarHistorico(OperacaRealizada);
                    defineNovaOperacaoEmCurso();
                    OperacaoEmMemoria = null;
                    TxtOperacaoEmCurso = $"{Binario}";
                }
            }
        }
    }
}
