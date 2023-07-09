using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool program_control = true;
            int number_control;
            char calculator_control;
            int a, b, sum, sub, mult;
            double div, div_mod;
            do
            {
                Console.WriteLine("Qual operação deseja executar?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Digite a operação que deseja executar: ");
                number_control = int.Parse(Console.ReadLine());

                switch (number_control)
                {
                    case 1:
                        Console.Write("\nDigite o valor de A para a soma: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor de B para a soma: ");
                        b = int.Parse(Console.ReadLine());
                        sum = a + b;
                        Console.WriteLine("\nResultado da operação:");
                        Console.WriteLine($"{a} + {b} = {sum}\n", sum);
                        Console.Write("Deseja fazer outra operação?[s]Sim [n]Não: ");
                        calculator_control = Convert.ToChar(Console.ReadLine());

                        if(calculator_control == 'n')
                        {
                            program_control = false;
                            continue;
                        }else if(calculator_control == 's')
                        {
                            Console.WriteLine("\nReiniciando o programa...\n");
                            continue;
                        }else
                        {
                            bool do_control = true;
                            do{
                                Console.WriteLine("Comando não encontrado, digite entre [s]Sim e [n]Não");
                                calculator_control = Convert.ToChar(Console.ReadLine());
                                if(calculator_control == 's')
                                {
                                    do_control = false;
                                    continue;
                                }else if(calculator_control == 'n')
                                {
                                    do_control = false;
                                    program_control = false;
                                    continue;
                                }
                                
                            }while(do_control);
                            break;
                            
                        }
                    case 2:
                        Console.Write("\nDigite o valor de A para a subtração: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor de B para a subtração: ");
                        b = int.Parse(Console.ReadLine());
                        sub = a - b;
                        Console.WriteLine("\nResultado da operação:");
                        Console.WriteLine($"{a} - {b} = {sub}\n", sub);
                        Console.Write("Deseja fazer outra operação?[s]Sim [n]Não: ");
                        calculator_control = Convert.ToChar(Console.ReadLine());

                        if(calculator_control == 'n')
                        {
                            program_control = false;
                            continue;
                        }else if(calculator_control == 's')
                        {
                            Console.WriteLine("\nReiniciando o programa...\n");
                            continue;
                        }else
                        {
                            bool do_control = true;
                            do{
                                Console.WriteLine("Comando não encontrado, digite entre [s]Sim e [n]Não");
                                calculator_control = Convert.ToChar(Console.ReadLine());
                                if(calculator_control == 's')
                                {
                                    do_control = false;
                                    continue;
                                }else if(calculator_control == 'n')
                                {
                                    do_control = false;
                                    program_control = false;
                                    continue;
                                }
                                
                            }while(do_control);
                            break;
                        }
                    case 3:
                        Console.Write("\nDigite o valor de A para a multiplicação: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("\nDigite o valor de B para a multiplicação: ");
                        b = int.Parse(Console.ReadLine());
                        mult = a * b;
                        Console.WriteLine("\nResultado da operação:");
                        Console.WriteLine($"{a} * {b} = {mult}\n", mult);
                        Console.Write("Deseja fazer outra operação?[s]Sim [n]Não: ");
                        calculator_control = Convert.ToChar(Console.ReadLine());

                        if(calculator_control == 'n')
                        {
                            program_control = false;
                            continue;
                        }else if(calculator_control == 's')
                        {
                            Console.WriteLine("\nReiniciando o programa...\n");
                            continue;
                        }else
                        {
                            bool do_control = true;
                            do{
                                Console.WriteLine("Comando não encontrado, digite entre [s]Sim e [n]Não");
                                calculator_control = Convert.ToChar(Console.ReadLine());
                                if(calculator_control == 's')
                                {
                                    do_control = false;
                                    continue;
                                }else if(calculator_control == 'n')
                                {
                                    do_control = false;
                                    program_control = false;
                                    continue;
                                }
                                
                            }while(do_control);
                            break;
                        }
                    case 4:
                        Console.Write("\nDigite o valor de A para a divisão: ");
                        a = int.Parse(Console.ReadLine());
                        double aConvert = a;
                        Console.Write("\nDigite o valor de B para a divisão: ");
                        b = int.Parse(Console.ReadLine());
                        double bConvert = b;
                        div = aConvert / bConvert;
                        div_mod = aConvert %  bConvert;
                        Console.WriteLine("\nResultado da operação:");
                        Console.WriteLine($"{a} / {b} = {div}", div);
                        Console.WriteLine($"Resto da divisão:\n{div_mod}", div_mod);
                        Console.Write("Deseja fazer outra operação?[s]Sim [n]Não: ");
                        calculator_control = Convert.ToChar(Console.ReadLine());

                        if(calculator_control == 'n')
                        {
                            program_control = false;
                            continue;
                        }else if(calculator_control == 's')
                        {
                            Console.WriteLine("\nReiniciando o programa...\n");
                            continue;
                        }else
                        {
                            bool do_control = true;
                            do{
                                Console.WriteLine("Comando não encontrado, digite entre [s]Sim e [n]Não");
                                calculator_control = Convert.ToChar(Console.ReadLine());
                                if(calculator_control == 's')
                                {
                                    do_control = false;
                                    continue;
                                }else if(calculator_control == 'n')
                                {
                                    do_control = false;
                                    program_control = false;
                                    continue;
                                }
                                
                            }while(do_control);
                            break;
                        }    
                }

            }while(program_control);
            Console.WriteLine("Programa Finalizado!");
            Console.ReadLine();
        }
    }
}
