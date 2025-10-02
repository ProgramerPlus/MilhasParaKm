﻿Console.WriteLine("Milhas para Km");
Console.Write("Informe o valor em milhas: ");
string entrada = Console.ReadLine()!;
double umaMilhaEmKm = 1.609;
double milhas = Convert.ToDouble(entrada);
double resultado = umaMilhaEmKm * milhas;
Console.WriteLine($"{resultado} km");
