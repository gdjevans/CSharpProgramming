using System;

namespace LoopsProj
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (3 < 5)
            {
                System.Diagnostics.Debug.WriteLine("3 is thess than 5");
            }
            else if (2 < 4)
            {
                System.Diagnostics.Debug.WriteLine("2 is thess than 4");
            }


            bool condition = true;
            int x = 0;

            if condition{
                x = 5;
            }
            else
            {
                x = 3;
            }
            System.Console.WriteLine(x);
             int value = 11;
            switch(value)
            {
                case 0:
                    System.Diagnostics.Debug.WriteLine("0");
                    break;
                case 1:
                    System.Diagnostics.Debug.WriteLine("1");
                    break;
                case 2:
                    System.Diagnostics.Debug.WriteLine("2");
                    break;
                case 3:
                    System.Diagnostics.Debug.WriteLine("3");
                    break;
                case 4:
                    System.Diagnostics.Debug.WriteLine("4");
                    break;
                case 5:
                    System.Diagnostics.Debug.WriteLine("5");
                    break;
                case 6:
                    System.Diagnostics.Debug.WriteLine("6");
                    break;
                case 7:
                    System.Diagnostics.Debug.WriteLine("7");
                    break;
                case 8:
                    System.Diagnostics.Debug.WriteLine("8");
                    break;
                default: 
                    System.Diagnostics.Debug.WriteLine("Other");
                    break;
            }
                    
            for(int i = 0; i < 5; i++)
            {
                System.Diagnostics.Debug.WriteLine("Hello World!");
            }

            for(int i = 0; i < 100; i++)
            {
                x += i;
            }
            System.Console.WriteLine(x);

            foreach(char s in "abc")
            {
                System.Diagnostics.Debug.WriteLine(s);
            }

            int i = 0;
            while(i < 5)
            {
                System.Diagnostics.Debug.WriteLine(i);
                i++;
            }

            int x = 3;
            while(x > 0)
            {
                System.Console.WriteLine(x);
                x-=1;
            }

            int i = 0;
            do
            {
                System.Diagnostics.Debug.WriteLine(i.ToString());
                i++;
            } while(x < 5);

            
        }
    }
}
