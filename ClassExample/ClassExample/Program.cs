public class ClassExample
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Start();
        car.Drive();
        car.Stop(); 
    }


    public static class Car
    {
        int speed;
        string color;
        float price;

        public static void Start()
        {
            System.Diagnostics.Debug.WriteLine("Car Started");
        }

        public static void Drive()
        {
            System.Diagnostics.Debug.WriteLine("Car is Driving");
        }

        public static void Stop()
        {
            System.Diagnostics.Debug.WriteLine("Car Stopped");
        }
    }
}