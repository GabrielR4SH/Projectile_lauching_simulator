using Physucal_One;
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
        

        if (timeOfFlight >= 45)
        {
            Person person = new Person();

            Random random = new Random();
            int hitLocation = random.Next(1, 4); // 1 = cabeça, 2 = ombros, 3 = pé

            switch (hitLocation)
            {
                case 1:
                    person.Head = false;
                    Console.WriteLine("A pessoa foi atingida na cabeça e não resistiu. 0 chance de vida");
                    break;
                case 2:
                    person.Shoulders = random.Next(0, 2) == 1; // 50% de chance de sobreviver
                    if (person.Shoulders)
                        Console.WriteLine("A pessoa sobreviveu ao impacto nos ombros. ela só tinha 50% de chances de vida");
                    else
                        Console.WriteLine("A pessoa foi atingida nos ombros e não resistiu mesmo com 50% de chances de vida.");
                    break;
                case 3:
                    person.Foot = random.Next(0, 6) < 5; // 80% de chance de sobreviver
                    if (person.Foot)
                        Console.WriteLine("A pessoa sobreviveu ao impacto nos pés. ela tinha 80% de chance de vida");
                    else
                        Console.WriteLine("A pessoa foi atingida nos pés e não resistiu mesmo com 80% de chances de vida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ninguem foi atingido pois o projétil cai no chão");
            Console.WriteLine("O projétil não ficou muito tempo noa alto pra cair em alguem");
        }
    }
}