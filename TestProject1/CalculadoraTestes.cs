using aulaTDD_S5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public  class CalculadoraTestes
    {
        [Fact]
        public void Soma_Int_Int()
        {
            
            int a = 2;
            int b = 3;
            int resultadoEsperado = 5;

           
            int resultado = Calculadora.Somar(a, b);

           
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Soma_Double_Double()
        {
          
            double a = 2.5;
            double b = 3.5;
            double resultadoEsperado = 6.0;

            
            double resultado = Calculadora.Somar(2.5M, 3.5M);

            
            Assert.Equal(resultadoEsperado, resultado, 2);
        }

        [Fact]
        public void Soma_Float_Float()
        {
            
            float a = 2.5F;
            float b = 3.5F;
            float resultadoEsperado = 6.0F;

            
            float resultado = Calculadora.Somar(2.5F, 3.5F);

            
            Assert.Equal(resultadoEsperado, resultado, 2);
        }

        [Fact]
        public void Soma_Decimal_Decimal()
        {
            
            decimal a = 2.5M;
            decimal b = 3.5M;
            decimal resultadoEsperado = 6.0M;

           
            decimal resultado = (decimal)Calculadora.Somar(a, b);

            
            Assert.Equal(resultadoEsperado, resultado, 2);
        }

        [Fact]
        public void Soma_Long_Long()
        {
            
            long a = 2147483647L;
            long b = 2147483647L;
            long resultadoEsperado = 4294967294L;

           
            long resultado = Calculadora.Somar(a, b);

           
            Assert.Equal(resultadoEsperado, resultado);
        }

    }
}
