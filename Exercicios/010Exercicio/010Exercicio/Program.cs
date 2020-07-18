using System;
using System.Globalization;

namespace _010Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("---------- MENU EXERCICIOS ----------");
            Console.WriteLine(" 1 - Área, Perímetro, Diagonal");
            Console.WriteLine(" 2 - Aumentar Salário");
            Console.WriteLine(" 3 - Aluno Aprovado / Reprovado");
            Console.WriteLine(" 4 - Terminar Programa");
            Console.WriteLine();
            Console.Write(" Escolha um exercício: ");
            int exer = int.Parse(Console.ReadLine());

            while (exer != 4)
            { 
                if (exer == 1) 
                {
                    Retangulo ret = new Retangulo();

                    Console.WriteLine();
                    Console.WriteLine("Entre a largura e altura do retângulo: ");
                    ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("ÁREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                }
                else if (exer == 2)
                {
                    Funcionario colab = new Funcionario();

                    Console.WriteLine();
                    Console.WriteLine("Entre os dados do funcionário; ");
                    Console.Write("Nome: ");
                    colab.Nome = Console.ReadLine();

                    Console.Write("Salário bruto: ");
                    colab.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Imposto: ");
                    colab.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Console.WriteLine("Funcionário: " + colab);
                    Console.WriteLine();

                    Console.Write("Deseja aumentar o salário em qual percentagem? ");
                    double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    colab.AumentarSalario(percent);
                    Console.WriteLine();

                    Console.WriteLine("Dados atualizados: " + colab);
                    Console.WriteLine();
                }
                else if (exer == 3)
                {
                    Avaliacao nota = new Avaliacao();

                    Console.WriteLine();
                    Console.Write("Nome do aluno: ");
                    nota.nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite as três notas do aluno: ");
                    nota.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    nota.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    nota.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Console.Write("NOTA FINAL = " + nota.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();

                    if (nota.Resultado())
                    {
                        Console.WriteLine("APROVADO");
                    }
                    else
                    {
                        Console.WriteLine("REPROVADO");
                        Console.WriteLine("FALTARAM " 
                            + nota.EmFalta().ToString("F2", CultureInfo.InvariantCulture) 
                            + " PONTOS");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("---------- MENU EXERCICIOS ----------");
                Console.WriteLine(" 1 - Área, Perímetro, Diagonal");
                Console.WriteLine(" 2 - Aumentar Salário");
                Console.WriteLine(" 3 - Aluno Aprovado / Reprovado");
                Console.WriteLine(" 4 - Terminar Programa");
                Console.WriteLine();
                Console.Write(" Escolha um exercício: ");
                exer = int.Parse(Console.ReadLine());
            }
        }
    }
}
