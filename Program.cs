using System;

namespace retangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opção = "";
                Console.Clear();

                Console.WriteLine("-- PROJETO CALCULADORA --");
                Console.WriteLine(" ");
                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Divisão");
                Console.WriteLine("4- Multiplicação");
                Console.WriteLine("5- Exponenciação");
                Console.WriteLine("6- Raiz quadrada");
                Console.WriteLine("7- Bhaskara");
                Console.WriteLine("8- Média entre números");
                Console.WriteLine("0- Sair");
                Console.WriteLine("S- Sobre");
                Console.WriteLine(" ");

                Console.Write("Escolha uma opção: ");
                opção = Console.ReadLine();

                switch (opção.ToUpper())
            {
                case "1":

                ExibeSoma();
                break;

                case "2":
    
                ExibeSubtração();
                break;
            
                case "3":
                
                ExibeDivisão();
                break;

                case "4":
                
                ExibeMultiplicação();
                break;

                case "5":
                
                ExibeExponenciação();
                break;

                case "6":
                
                ExbibeRadiciação();
                break;

                case "7":

                ExibeBhaskara();
                break;

                case "8":

                ExibeMedia();
                break;

                case "0":

                ExibeSair();
                break;

                case "S":
                
                ExibeSobre();
                break;

                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida!");
                Console.ResetColor();
                Environment.Exit(1);
                break;
            }
        }
        static void ExibeOpções()
        {
            string opção = "";
                Console.Clear();

                Console.WriteLine("-- PROJETO CALCULADORA --");
                Console.WriteLine(" ");
                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Divisão");
                Console.WriteLine("4- Multiplicação");
                Console.WriteLine("5- Exponenciação");
                Console.WriteLine("6- Raiz quadrada");
                Console.WriteLine("7- Bhaskara");
                Console.WriteLine("8- Média entre números");
                Console.WriteLine("0- Sair");
                Console.WriteLine("S- Sobre");
                Console.WriteLine(" ");

                Console.Write("Escolha uma opção: ");
                opção = Console.ReadLine();

                switch (opção.ToUpper())
            {
                case "1":

                ExibeSoma();
                break;

                case "2":
    
                ExibeSubtração();
                break;
            
                case "3":
                
                ExibeDivisão();
                break;

                case "4":
                
                ExibeMultiplicação();
                break;

                case "5":
                
                ExibeExponenciação();
                break;

                case "6":
                
                ExbibeRadiciação();
                break;

                case "7":

                ExibeBhaskara();
                break;

                case "8":

                ExibeMedia();
                break;

                case "0":

                ExibeSair();
                break;

                case "S":
                
                ExibeSobre();
                break;

                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida!");
                Console.ResetColor();
                Environment.Exit(1);
                break;
            }
        }
        static void ExibeSoma()
        {
            int nr1, nr2, soma;

            Console.Clear();
            Console.WriteLine("--SOMA--");
            Console.WriteLine("Digite os números que serão somados");
            Console.WriteLine(" ");
            Console.Write("Número 1: ");
            nr1= int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            nr2= int.Parse(Console.ReadLine());

            soma= nr1+nr2;

            Console.WriteLine($"O resultado é: {soma}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();

        }
        static void ExibeSubtração()
        {
            int nr1, nr2, Subtração;

            Console.Clear();
            Console.WriteLine("--SUBTRAÇÃO--");
            Console.WriteLine("Digite os números que serão subtraidos");
            Console.WriteLine(" ");
            Console.Write("Número 1: ");
            nr1= int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            nr2= int.Parse(Console.ReadLine());

            Subtração= nr1-nr2;
            Console.WriteLine($"O resultado é: {Subtração}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExibeDivisão()
        {
            int nr1, nr2, divisão;

            Console.Clear();
            Console.WriteLine("--DIVISÃO--");
            Console.WriteLine("Digite os números que serão divididos");
            Console.WriteLine(" ");
            Console.Write("Número 1: ");
            nr1= int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            nr2= int.Parse(Console.ReadLine());

            divisão= nr1/nr2;
            Console.WriteLine($"O resultado é: {divisão}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExibeMultiplicação()
        {
            int nr1, nr2, Multiplicação;

            Console.Clear();
            Console.WriteLine("--MULTIPLICAÇÃO--");
            Console.WriteLine("Digite os números que serão multiplicados");
            Console.WriteLine(" ");
            Console.Write("Número 1: ");
            nr1= int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            nr2= int.Parse(Console.ReadLine());

            Multiplicação= nr1*nr2;
            Console.WriteLine($"O resultado é: {Multiplicação}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExibeExponenciação()
        {
            double Exponenciação,nro1, nro2;

            Console.Clear();
            Console.WriteLine("--EXPONENCIAÇÃO--");
            Console.WriteLine("Digite: ");
            Console.Write("Base: ");
            nro1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Expoente: ");
            nro2= Convert.ToDouble(Console.ReadLine());
                
            Exponenciação= Math.Pow(nro1, nro2);
            Console.WriteLine($"O resultado é: {Exponenciação}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExbibeRadiciação()
        {
            double Raiz,nro1;

            Console.Clear();
            Console.WriteLine("--RAIZ QUADRADA--");
            Console.WriteLine("Digite: ");
            Console.Write("Número: ");
            nro1= Convert.ToDouble(Console.ReadLine());
                
            Raiz= Math.Sqrt(nro1);
            Console.WriteLine($"O resultado é: {Raiz}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExibeBhaskara()
        {
            string entrada1,entrada2,entrada3;
            double A,B,C,delta,x1,x2;

            Console.Clear();
            Console.WriteLine("--BHASKARA--");
            Console.Write("Valor A: ");
            entrada1= Console.ReadLine();
            A= Convert.ToDouble(entrada1);
            Console.Write("Valor B: ");
            entrada2= Console.ReadLine();
            B= Convert.ToDouble(entrada2);
            Console.Write("Valor C: ");
            entrada3= Console.ReadLine();
            C= Convert.ToDouble(entrada3);
            
            delta= B*B - 4*A*C;
            x1= (-B + Math.Sqrt(delta)) / (2*A);
            x2= (-B - Math.Sqrt(delta)) / (2*A);
            
            if (A<=0)
            {
                Console.WriteLine("Não é uma equação de segundo grau.");
            }

            else if(delta < 0)
            {
                Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais");
            }

            else
            {
                Console.WriteLine("O resultado é:");
                Console.WriteLine($"x1= {x1:N2} e x2= {x2:N2}");
            }
            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ExibeMedia()
        {
            decimal nro1, nro2, Media;

            Console.Clear();
            Console.WriteLine("--MÉDIA NUMERAL--");
            Console.WriteLine("Digite os valores:");
            Console.Write("Número 1: ");
            nro1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Número 2: ");
            nro2 = Convert.ToDecimal(Console.ReadLine());

            Media= (nro1+nro2) / 2;
            
            Console.WriteLine($"O resultado é {Media:N1}");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();

        }
        static void ExibeSair()
        {
            string saida;
            
            Console.Clear();
            Console.WriteLine("Deseja sair do programa?");
            Console.WriteLine("S-Sim || N-Não");
            Console.Write("Escolha uma opção: ");
            saida = Console.ReadLine();
            
             switch (saida.ToUpper())
            {
                case "S":
    
                Console.WriteLine("Obrigada por utilizar nosso programa!");
                Environment.Exit(0);
                break;
            
                case "N":

                ExibeOpções();
                break;
            }
        }
        static void ExibeSobre()
        {
            Console.Clear();
            Console.WriteLine("--Sobre mim e o projeto--");
            Console.WriteLine("Me chamo Yaritza, tenho 16 anos e atualmente, curso o 1° Módulo do Ensino Técnico de Informática, na ETEC Adolpho Berezin :)");
            Console.WriteLine("Este projeto foi realizado com intuito de por em prática o que aprendemos durante curso!");

            Console.WriteLine(" ");

            Console.Write("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
    }         
}