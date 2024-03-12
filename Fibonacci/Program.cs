using static System.Console;

namespace Fibo;

public class Program
{
    public static bool Fibonacci(int valor, int? penualtimo = 0, int? ultimo = 1)
    {
        int? valorAtual = ultimo + penualtimo;
        if (valor == penualtimo)
        {
            return true;
        }

        if(valor == ultimo)
        {
            return true;
        }
        if (valor >= valorAtual)
        {
            if(valor == valorAtual)
            {
                return true;
            } else
            {
                return Fibonacci(valor, ultimo, valorAtual);
            }
        } else
        {
            return false;
        }
    }
    public static void Main()
    {
        WriteLine("\tFibonacci");
        resp:
        Write("Digite um valor: ");
        if(!int.TryParse(ReadLine(), out int valor))
        {
            WriteLine("Erro!\nDigite um valor válido!");
            goto resp;
        }
        if (Fibonacci(valor))
        {
            WriteLine($"O valor {valor} está na sequência de Fibonacci!");
        } else
        {
            WriteLine($"O valor {valor} não está na sequência de Fibonacci!");
        }
    }
}
