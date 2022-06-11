namespace Advanced
{

    class Program { 
        static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            } 

            return fib(n - 1) + fib(n - 2);
        }

        public static void Main(String[] args)
        {
            System.Diagnostics.Debug.WriteLine(fib(11));

        }

    }

}