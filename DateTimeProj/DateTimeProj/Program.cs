using System;

namespace DateTimneProj
{
    class Program
    {
        public static void Main(String[] args)
        {
            DateTime dateTime = new DateTime(2020, 1, 19);
            System.Diagnostics.Debug.WriteLine(dateTime);

            TimeSpan timeSpan = new TimeSpan(1, 2, 0);
            System.Diagnostics.Debug.WriteLine(timeSpan.Hours);
            System.Diagnostics.Debug.WriteLine(timeSpan.Minutes);
            System.Diagnostics.Debug.WriteLine(timeSpan.Seconds);

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));

            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm tt"));
        }
    }
}
