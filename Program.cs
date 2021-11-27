using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02lidandoComErros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double salario = 0;
                int aulas = 0;
                double valorAula = 0;

                Console.Write("Informe o numero de aulas do professor: ");
                aulas += int.Parse(Console.ReadLine());

                if (aulas <= 0 )
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Informe o valor da aula: R$ ");
                    valorAula += double.Parse(Console.ReadLine());
                }

                if (valorAula <=0 )
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    salario += aulas * valorAula;
                }

                if (salario > 0)
                {
                    Console.WriteLine("Salario bruto do professor: " + salario.ToString("C"));
                }
                else
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }


                Console.Write("Informe o % de INSS: ");
                double inss = double.Parse(Console.ReadLine());

                if (inss <= 0)
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    salario -= salario * (inss / 100);
                    Console.WriteLine("O Salario Liquido do professor é: " + salario.ToString("C"));
                }            
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Informe um valor maior do que 0 (Zero)");
            }
            catch(FormatException)
            {
                Console.WriteLine("Informe um Valor que contenha Numeros.");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                Console.WriteLine("Programa Encerrado.");
            }
            Console.ReadKey();
        }
    }
}
