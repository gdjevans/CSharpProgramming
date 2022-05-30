using System;

namespace ConvertFtoC
{
    class Program
    {
        public static void Main()
        {
            //char char1 = 'a';
            //char char2 = '\n';
            //string s1 = "abc";
            int i = 200;
            System.Diagnostics.Debug.WriteLine(i);
            ChangeValue(i);
            System.Diagnostics.Debug.WriteLine(i);
        }

        int fahrenheit = 0;
        public static class convertToCelcius(fahrenheit)
        {
            return (fahrenheit - 32) * (5 / 9);
        }

        public static class Exercise
        {
            public static void StringChallenge()
            {
                string s = "Hello World";
                Console.WriteLine(s.Substring(0, 5));
            }
        }

        public static class Exercise2
        {
            public static void BoxingChallenge()
            {
                int example = 1;
                object o = example;
                int example2 = (int)o;
            }
        }

        static void ChangeValue(int num)
        {
            num = 500;
            System.Diagnostics.Debug.WriteLine(num);
        }

    }

}
