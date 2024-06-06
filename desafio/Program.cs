using System;

namespace desafiodo;

//Considerei para este código os valores que lembrei lá teste {2, 10, 3, 9}. 
//Sendo que eram duas pessoas e o valor da discordância de pagamento era 10.
//Na interatividade dá pra colocar qualquer valor desde que o valor 

class Desafio {
    static void Main(string[] args) {

        //Limpa a tela
        Console.Clear();

        //Criação de um array
        Console.WriteLine("Digite a quantidade de elementos para divisão da despesa)");

        string input = Console.ReadLine();
        int.TryParse(input, out int n);

        int[] array = new int[n];

        for (int i=0; i < n; i++) 
        {
            Console.WriteLine($"Digite o elemento {i+1}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Informações do Pagamento
        Console.WriteLine("Qual o valor discorda para pagamento?");
        int resp = Convert.ToInt32(Console.ReadLine());
        int k = Array.IndexOf(array, resp);
        
        int b = array[k];

        int total = (array.Sum() - b)/2;
        Console.WriteLine($"Valor Total sem discordância: {array.Sum()}");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Valor a ser pago pela pessoa 2 que discordou do valor: " + total);
        Console.WriteLine("-------------------------------");        
        
        Console.WriteLine("Qual o valor pago?");
        int vPago = Convert.ToInt32(Console.ReadLine());
        if (total == vPago)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Valor a ser reembolsado pois não descontou do pagamento {b}: { vPago - total}");
        }
    }
}

