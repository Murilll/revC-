using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

List<string> arr = new List<string>();

int temp = 0;

while (true)
{
    Console.WriteLine("Digite um caracter: ");
    string num = Console.ReadLine();
    arr.Add(num);
    Console.WriteLine("Digite 0 para parar");
    int stop = Convert.ToInt32(Console.ReadLine());

    if (stop == 0)
        break;
    else
        continue;
}

for (int write = 0; write < arr.Count; write++)
{
    for (int sort = 0; sort < arr.Count; sort++)
    {
        if (arr[sort] > arr[sort + 1])
        {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}

for (int i = 0; i < arr.length; i++)
    Console.Write(arr[i] + " ");

Console.ReadKey();

Console.Write("Lista: ");
foreach (var i in arr)
{  
    Console.Write($"{i}");
}