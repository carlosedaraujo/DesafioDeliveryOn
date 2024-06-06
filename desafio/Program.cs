using System;


Console.WriteLine("Quantos elementos no array?");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[tamanhoArray];

for (int i=0; i < tamanhoArray; i++) 
{
    Console.WriteLine($"Digite o elemento {i+1}");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Elementos do array:");
foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine("Digite dois numeros separados por espaço");
string[] nk = Console.ReadLine().Split(' ');
List<int> lista = new List<int>();
foreach (var item in nk)
{
    lista.Add(Convert.ToInt32(item));
}

foreach (var i in lista) {
    Console.WriteLine(i);
}
   




