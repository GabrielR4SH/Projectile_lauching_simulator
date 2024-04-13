using System;

class Program
{
    static void Main()
    {
        const double Gravity = 9.81; // Aceleração da gravidade em m/s^2
        double angle, velocity;

        Console.WriteLine("Simulador de Lançamento de Projéteis");
        Console.WriteLine("-------------------------------------");

        Console.Write("Digite o ângulo de lançamento (em graus): ");
        angle = double.Parse(Console.ReadLine());

        Console.Write("Digite a velocidade inicial (em m/s): ");
        velocity = double.Parse(Console.ReadLine());

        double radianAngle = angle * (Math.PI / 180); // Convertendo o ângulo para radianos

        double timeOfFlight = (2 * velocity * Math.Sin(radianAngle)) / Gravity; // Tempo de voo
        double distance = velocity * Math.Cos(radianAngle) * timeOfFlight; // Distância percorrida

        Console.WriteLine();
        Console.WriteLine($"Tempo de voo: {timeOfFlight:F2} segundos");
        Console.WriteLine($"Distância percorrida: {distance:F2} metros");
    }
}
