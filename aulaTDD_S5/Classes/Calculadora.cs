using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaTDD_S5.Classes
{
    public static class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static bool DivisivelPor(int dividendo, int divisor)
        {
           if (dividendo % divisor == 0)
            {
                return true;
            }
           return false;
        }

        public static double Somar(decimal v1, decimal v2)
        {
            throw new NotImplementedException();
        }

        public static float Somar(float v1, float v2)
        {
            throw new NotImplementedException();
        }
    }
}
