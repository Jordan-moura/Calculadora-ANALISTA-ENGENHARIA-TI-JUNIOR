using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public int soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public int subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public int multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public decimal divisao(Operacoes operacao)
        {
            try
            {
                return (decimal)operacao.valorA / operacao.valorB;
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Erro: Tentativa de divisão por zero. -> ");
                return 0;
            }
        }

    }
}
