using System;

namespace Laba9Lib
{
    public class String1
    {
        private string _str;//переданий рядок
        private char _char;//символ, який шукаємо
        public int num;//скільки разів символ входить у рядок
        public delegate void CharFound(string str, char ch);//делегат
        private CharFound howMany;//екземпляр делегату
        public String1(string str, char ch)//конструктор
        {
            _str = str;
            _char = ch;
            num = 0;
        }
        //пошук кількості входжень символа у рядок (екземплярний)
        public int HowMany(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    num++;
                    howMany?.Invoke(str, ch);//виклик методу 
                }
            }
            return num;
        }
        //спрацьовує на знаходження символа
        public static void HandleOnCharFound(string str, char ch)
        {
            Console.WriteLine($"Oh, I found '{ch}'");
        }
        //пошук кількості входжень символа у рядок (статичний)
        public static int HowMany_Static(string str, char ch)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    num++;
                }
            }
            return num;
        }
        //передаю екзкмпляр делегата, на який підписуємся
        public void RegistrOnHowManyChars(CharFound howMany)
        {
            this.howMany += howMany;
        }
    }
}
