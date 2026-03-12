using System;
using System.Diagnostics.Eventing.Reader;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome");
            string nome = Console.ReadLine();

            //variáveis zeradas que definem o peso e a altura do usuário
            float peso, altura;

            Console.WriteLine("Bem-vindo " + nome);
            while (true) 
            {
                Console.WriteLine("Insira seu Peso");
                float.TryParse(Console.ReadLine(), out peso);
                if (peso == 0)
                    Console.WriteLine("Peso Inválido, por favor, insira outro valor");
                else
                    break;
            }                                 

            //variável de altura definida como string para utilização do .Replace + validação
            while (true)
            {
                Console.WriteLine("Insira sua altura");
                string imcAltura = Console.ReadLine();
                imcAltura = imcAltura.Replace('.', ',');
                float.TryParse(imcAltura, out altura);

                if (altura == 0) 
                Console.WriteLine("Altura Inválida, por favor, insira outro valor");
                else
                    break;
            }  
            
            //Cálculo do IMC
            float IMC = (peso / (altura * altura));

 
            // F2 utilizado após citar varíavel para definir a quantidade de casas após a virgula
            Console.WriteLine($"Seu IMC é: {IMC:f2}");
            

            if (IMC >= 40.00)
            {
                Console.WriteLine("Você está com obesidade grau III");
            }
            else if (IMC >= 35.00 && IMC < 39.90)
            {
                Console.WriteLine("Você está com obesidade grau II");
            }
            else if (IMC >= 30.00 && IMC < 34.90)
            {
                Console.WriteLine("Você está com obesidade grau I");
            }
            else if (IMC >= 25.00 && IMC < 29.90)
            {
                Console.WriteLine("Você está com Sobrepeso");
            }
            else if (IMC >= 18.60 && IMC < 24.90)
            {
                Console.WriteLine("Você está Normal");
            }
            else if (IMC < 18.50)
            {
                Console.WriteLine("Você está abaixo do normal");
            }

            Console.ReadLine();
        }
    }
}