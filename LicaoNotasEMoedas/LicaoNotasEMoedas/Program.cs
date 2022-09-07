using System;
using System.Globalization;

namespace LicaoNotasEMoedas {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 5; i++) {

                Console.WriteLine("Digite o valor desejado: ");
                double ValorInformado;
                int nota, moeda, quociente, resto;

                ValorInformado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("NOTAS:");

                resto = (int)(ValorInformado * 100.0 + 0.5);

                nota = 100;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                nota = 50;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                nota = 20;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                nota = 10;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                nota = 5;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                nota = 2;
                quociente = resto / (nota * 100);
                Console.WriteLine($"{quociente} nota(s) de R$ {nota.ToString("F2", CultureInfo.InvariantCulture)}");
                resto = resto % (nota * 100);

                Console.WriteLine("MOEDAS:");

                moeda = 100;
                quociente = resto / (moeda);
                Console.WriteLine($"{quociente} moeda(s) de R$ 1.00");
                resto = resto % (moeda);

                moeda = 50;
                quociente = resto / (moeda);
                Console.WriteLine($"{quociente} moeda(s) de R$ 0.50");
                resto = resto % (moeda);

                moeda = 25;
                quociente = resto / (moeda);
                Console.WriteLine($"{quociente} moeda(s) de R$ 0.25");
                resto = resto % (moeda);

                moeda = 10;
                quociente = resto / (moeda);
                Console.WriteLine($"{quociente} moeda(s) de R$ 0.10");
                resto = resto % (moeda);

                moeda = 5;
                quociente = resto / (moeda);
                Console.WriteLine($"{quociente} moeda(s) de R$ 0.05");
                resto = resto % (moeda);

                Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
    }
}
