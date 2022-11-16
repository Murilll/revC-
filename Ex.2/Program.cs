using System;

List<float> notas = new List<float>();
int x = 0;
for (int i = 0; i < 6; i++)
{
    
    Console.WriteLine($"Digite a {x+1}º nota do aluno: ");
    int addNotas = Convert.ToInt32(Console.ReadLine());
    notas.Add(addNotas);
    x++;
}

float media = notas.Sum() / notas.Count();

Console.WriteLine(media);


foreach (var item in notas)
{
    Console.Write(item + " ");
}