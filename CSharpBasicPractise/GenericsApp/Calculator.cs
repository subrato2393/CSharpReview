using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericsApp
{
    public class Calculator<T>
    {
        public T FirstNumber { get; set; }
        public T SecondNumber { get; set; }

        public Calculator(T firstNumber,T secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }
        public T Add<T>(T firstNumber,T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;
            return a + b;
        }
        public void Multiply<T>(T firstNumber, T secondNumber)
        {
            dynamic a = firstNumber;
            dynamic b = secondNumber;
            Console.WriteLine("Multiplication = "+(a+b));
        }
    }
}
