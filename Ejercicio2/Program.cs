using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;
            Boolean mantenerAbierto = true;

            

            while (mantenerAbierto)
            {

                Console.WriteLine("Escriba una cuenta o 'Q' para salir");
                String cuenta = Console.ReadLine();
                if (cuenta.Equals("Q"))
                {
                    mantenerAbierto = false;
                }
                else
                {
                    try
                    {
                        resultado = Calculadora.Calcular(cuenta, resultado);
                        Console.WriteLine("RESULTADO: " + resultado);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Error: No ingresaste una cuenta!!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    
                }
            }
            
            
        }
    }
}
