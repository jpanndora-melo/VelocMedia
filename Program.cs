Console.Write("Distancia percorrida (m)");
            double distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tempo gasto (s)");
            double tempo = Convert.ToDouble(Console.ReadLine());
            double velocidade = distancia / tempo;
            Console.WriteLine($"\n velocidade média: {velocidade:N2} m/s");