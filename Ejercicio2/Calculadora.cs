using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Calculadora
    {
        public static Double Calcular(String cuenta, Double resultado) 
        {

            Boolean hayNumero1=false;
            Boolean hayNumero2=false;
            int posSimbolo=0;
            double num1;
            double num2;
            String numero1;
            String numero2;
            String simbolo;
           
            for (int i = 0; i < cuenta.Length; i++)
            {
                String digito = cuenta.Substring(i, 1);

                if (digito.Equals("+") || digito.Equals("-") || digito.Equals("*") || digito.Equals("/"))
                {
                    posSimbolo = i;
                }
                else if (digito.Equals("R") && (posSimbolo < i))
                {   
                    hayNumero2=true;
                }
                else if (digito.Equals("R") && (i==0))
                {
                    hayNumero1=true;
                }
            }

            int sim = posSimbolo + 1;
            simbolo = cuenta.Substring(posSimbolo, 1);

            numero1 = cuenta.Substring(0, posSimbolo);
            numero2 = cuenta.Substring(sim, cuenta.Length - sim);

            if (hayNumero1)
            {
                num1 = resultado;
            }else
            {
                num1 = int.Parse(numero1);
            }

            if (hayNumero2)
            {
                num2 = resultado;
            }else
            {
                num2 = int.Parse(numero2);
            }

            switch (simbolo)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/": if (num2 > 0) { resultado = num1 / num2; } else { Console.WriteLine("NO SE PUEDE DIVIDIR POR 0!"); } break;
                default: resultado = 0; break;
            }

            return (resultado);
        }
    }
}
