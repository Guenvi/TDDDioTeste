using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        private List<string> listahistorico;
        private string data;

        public CalculadoraImplementacao(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            
            listahistorico.Insert( 0, Convert.ToString(resultado) + data);

            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            
            listahistorico.Insert( 0, Convert.ToString(resultado) + data);

            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            
             listahistorico.Insert( 0, Convert.ToString(resultado) + data);

            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1/num2;

             listahistorico.Insert( 0, Convert.ToString(resultado) + data);
            
            
            return resultado;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            
            return listahistorico;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}