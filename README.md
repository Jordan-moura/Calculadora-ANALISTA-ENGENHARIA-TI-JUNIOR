# Calculadora
Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
  2. Implemente a funcionalidade de divisão.
  3. Aplicação não está calculando a penultima operação corretamente.
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6

  5. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.
  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final


Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.

# Solução Exercicio 01

### Problema Inicial

A aplicação estava processando o primeiro item da fila infinitamente.

### Solução Implementada

Para resolver este problema, foi necessário editar o programa `Program.cs` em dois pontos:

1. **Correção da Condição do Loop**:
   - Na linha 20, substituímos `filaOperacoes.Count >= 0`, que roda enquanto o número de elementos na fila seja maior ou igual a zero, por `filaOperacoes.Count != 0`, ajustando a condição do `while` para interromper o loop quando o número de elementos na fila se tornar zero.

2. **Substituição de `Peek()` por `Dequeue()`**:
   - Na linha 22, substituímos `filaOperacoes.Peek()`, que obtém o elemento do topo da fila sem removê-lo, por `filaOperacoes.Dequeue()`, que também obtém o topo da fila, mas o remove.

Program.cs
![Resolvido](Imagens/exercicio01.png)

Saída
![Saida](Imagens/resultadoExercicio01.png)

# Solução Exercicio 02

### Problema Inicial

Implemente a funcionalidade de divisão.

### Solução Implementada

Para resolver este problema, foram realizadas as seguintes alterações no programa `Calculadora.cs`:

1. **Adição do Operador de Divisão**:
   - Na linha 14, foi incluído o seguinte código:
     ```csharp
     case '/': operacao.resultado = divisao(operacao); break;
     ```
   Isso permite que a calculadora reconheça o operador de divisão e execute a operação correspondente.

2. **Implementação do Método de Divisão**:
   - Na linha 31, foi adicionado um novo método para realizar a operação de divisão:
   ```csharp
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
     ```
   Este método calcula a divisão entre os dois valores fornecidos.

Com estas modificações, a funcionalidade de divisão foi devidamente implementada na calculadora.

Calculadora.cs
![Resolvido](Imagens/exercicio02.png)

Saída
![Saida](Imagens/resultadoExercicio02.png)
