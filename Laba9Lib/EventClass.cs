using System;
using System.Collections.Generic;
using System.Text;

namespace Laba9Lib
{
    public class EventClass
    {
        public event DevisionHappened OnDevision; //подія
        public delegate void DevisionHappened(int a, int b);//делегат
        private int _a;
        private int _b;
        public double Result { get; set; }
        public EventClass(int a, int b)//конструктор 
        {
            _a = a;
            _b = b;
        }
        public void Sum()
        {
            Result = _a + _b;
        }
        public void Minus()
        {
            Result = _a - _b;
        }
        public void Multiply() 
        {
            Result = _a * _b;
        }
        public void Devision()
        {
            if (_b == 0)
                throw new DivideByZeroException("Devision by 0."); //перевірка на 0
            Result = (double)_a / _b;
            OnDevision?.Invoke(_a, _b); //якщо не null, то викликаємо подію
        }
        public static void HandleOnDevision(int a, int b)
        {
            Console.WriteLine("Devided succesfully.");
        }
    }
}
