using System;

public class Desafio {
    public static void Main(string[] args) {

        Console.WriteLine("Digite dois numeros separados por espaço (sendo o primeiro o tamanho do array e o segundo o numero do item que não será pago)");
        string[] nk = Console.ReadLine().Split(' ');

        List<int> lista = new List<int>();
        foreach (var item in nk)
        {
            lista.Add(Convert.ToInt32(item));
        }

        int k = lista[1];

        int tamanhoArray = Convert.ToInt32(lista[0]);

        int[] array = new int[tamanhoArray];

        for (int i=0; i < tamanhoArray; i++) 
        {
            Console.WriteLine($"Digite o elemento {i+1}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int b = array[k];

        Console.WriteLine(b);

    static void resposta (List<int> array, int k, int b) 
    {
            int soma = (array.Sum() - b) / 2;
            


    }
   }
}

