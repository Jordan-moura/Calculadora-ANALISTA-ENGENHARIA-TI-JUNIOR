using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            Stack<decimal> resultados = new Stack<decimal>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            while (filaOperacoes.Count != 0)
            {
                calculadora.ImprimirFilaOperacoes(filaOperacoes);
                Operacoes operacao = filaOperacoes.Dequeue();
                Console.WriteLine("\nProcessando a operação que está na primeira posição da fila...");
                calculadora.calcular(operacao);
                resultados.Push(operacao.resultado);
                Console.WriteLine("{0} {1} {2} = {3}\n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
            }

            calculadora.ImprimirPilhaResultados(resultados);
        }

    }
}