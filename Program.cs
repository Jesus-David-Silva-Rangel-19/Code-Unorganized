using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Juego por consola";
            Random NumberRan = new Random();
            int Number;
            int NumberSecret = NumberRan.Next(1, 20);
            Console.WriteLine("\n\t                                  Bienvenido al programa.");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tNOTA ACLARATORIA:");
            Console.ResetColor();
            Console.Write("\n\tEste programa le permite interactuar por consola en la búsqueda de un número secreto.");
            Console.WriteLine(" ");
            Console.Write("\n\tOprima enter para continuar . . .");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
            Number = int.Parse(Console.ReadLine());
            while (Number > 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.Write("\n\t¡Error!");
                Console.ResetColor();
                Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                Console.WriteLine(" ");
                Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                Console.ReadKey();    
                Console.Clear();
                Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                Number = int.Parse(Console.ReadLine());
                while (Number > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                }
                while (Number <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                    
                }
            }
            while (Number <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.Write("\n\t¡Error!");
                Console.ResetColor();
                Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                Console.WriteLine(" ");
                Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                Console.ReadKey();             
                Console.Clear();
                Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                Number = int.Parse(Console.ReadLine());
                while (Number > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                    while (Number > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                    }
                    while (Number <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                        
                    }
                }
            }
            while ( Number < NumberSecret)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write("\n\tPISTA:");
                Console.ResetColor();
                Console.Write("\n\tEl número digitado es menor al número secreto");
                Console.WriteLine(" ");
                Console.Write("\n\tOprima enter para intentar de nuevo . . .");
                Console.ReadKey();
                Console.Clear();
                Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                Number = int.Parse(Console.ReadLine());               
                while (Number > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                }
                while (Number <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                    if (Number == NumberSecret)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\n\tFelicitaciones");
                        Console.ResetColor();
                        Console.Write("\n\tha encontrado el número secreto");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            while (Number > NumberSecret  )
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tPISTA:");
                Console.ResetColor();
                Console.Write("\n\tEl número digitado es mayor que el número secreto");
                Console.WriteLine(" ");
                Console.Write("\n\tOprima enter para intentar de nuevo . . .");
                Console.ReadKey();
                Console.Clear();
                Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                Number = int.Parse(Console.ReadLine());              
                while (Number > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                    while (Number > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                    }
                    while (Number <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                        if (Number == NumberSecret)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\n\tFelicitaciones");
                            Console.ResetColor();
                            Console.Write("\n\tha encontrado el número secreto");
                            Console.ReadKey();
                            return;
                        }
                    }
                }
                while (Number <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.Write("\n\t¡Error!");
                    Console.ResetColor();
                    Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());
                    while (Number > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number= int.Parse(Console.ReadLine());
                        while (Number > 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ");
                            Console.Write("\n\t¡Error!");
                            Console.ResetColor();
                            Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                            Console.WriteLine(" ");
                            Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                            Number = int.Parse(Console.ReadLine());
                        }
                        while (Number <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ");
                            Console.Write("\n\t¡Error!");
                            Console.ResetColor();
                            Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                            Console.WriteLine(" ");
                            Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                            Number = int.Parse(Console.ReadLine());
                            if (Number == NumberSecret)
                            {
                                Console.WriteLine("\n\tFelicitaciones, ha encontrado el número secreto");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                while (Number < NumberSecret  )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\tPISTA:");
                    Console.ResetColor();
                    Console.Write("\n\tEl número digitado es menor al número secreto");
                    Console.WriteLine(" ");
                    Console.Write("\n\tOprima enter para intentar de nuevo . . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                    Number = int.Parse(Console.ReadLine());                 
                    while (Number > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                    }
                    while (Number <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" ");
                        Console.Write("\n\t¡Error!");
                        Console.ResetColor();
                        Console.WriteLine("\n\tSolo se aceptan números en una escala del 1 al 20.");
                        Console.WriteLine(" ");
                        Console.Write("\n\tOprima enter para comenzar de nuevo . . .");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("\n\tDigite un número en una escala del 1 al 20: ");
                        Number = int.Parse(Console.ReadLine());
                        if (Number==NumberSecret  )
                        {
                            Console.WriteLine("\n\tFelicitaciones, ha encontrado el número secreto");
                            Console.ReadKey();
                        }
                    }
                }

            }
            if (Number == NumberSecret)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\tFelicitaciones");
                Console.ResetColor();
                Console.Write("\n\tha encontrado el número secreto");
                Console.ReadKey();
                return;
            }
        }
    }
}