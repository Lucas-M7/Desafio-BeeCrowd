double divisao = 4 / 3.0;
double pi = 3.14159;
double raio = double.Parse(Console.ReadLine());

double calculo = divisao * pi * Math.Pow(raio, 3);

Console.WriteLine($"VOLUME = {calculo.ToString("F3")}");