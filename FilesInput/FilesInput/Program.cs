using System;

namespace FilesInput
{
    public class Program
    {
        public static void Main (String[] args)
        {
            Console.WriteLine('Type some text: ');
            string userInput = Console.ReadLine();
            System.Diagnostics.Debug.WriteLine(userInput);

            Console.WriteLine("Hit a key");
            int x = Console.Read();
            System.Diagnostics.Debug.WriteLine(Convert.ToChar(x));

            Console.WriteLine("g = green, r = red, b = blue, w = white ");
            int y = Console.Read();
            char userInput2 = Convert.ToChar(y);

            while (userInput2)
            {
                switch (userInput2)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

                Console.Clear();
                Console.WriteLine("g = green, r = red, b = blue, w = white");
                x = Console.Read();
                userInput = Convert.ToChar(x);

                ConsoleKeyInfo keyInfo;
                Console.TreatControlCAsInput = true;

                do
                {
                    keyInfo = Console.ReadKey();

                    if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                        Console.Write("ALT+");
                    if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                        Console.Write("SHIFT+");
                    if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                        Console.Write("CTRL+");
                } while (keyInfo.Key != ConsoleKey.Escape);

              


            }
        }
    }

}
