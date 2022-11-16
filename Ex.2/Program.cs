using System;

List<int> notas = new List<int>();
int x = 0;
for (int i = 0; i < 3; i++)
{
    x++;
    Console.WriteLine($"Digite a {x}º nota do aluno: ");
    int addNotas = Convert.ToInt32(Console.ReadLine());
    notas.Add(addNotas);
}
