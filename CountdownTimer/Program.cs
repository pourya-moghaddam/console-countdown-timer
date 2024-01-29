using System;

namespace CountdownTimer
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter countdown hours (0-23): ");
                int hrs = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter countdown minutes (0-59): ");
                int mins = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter countdown seconds (0-59): ");
                int secs = Convert.ToInt32(Console.ReadLine());
                DateTime dateTime = new DateTime(2000, 1, 1, hrs, mins, secs);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;

                int i = 0;
                while (i <= secs + (mins * 60) + (hrs * 3600))
                {
                    Console.Write(dateTime.ToString("HH:mm:ss"));
                    dateTime = dateTime.AddSeconds(-1);
                    Thread.Sleep(1000);
                    Console.Clear();
                    i++;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("[{0}] {1}", ex.GetType().Name, ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("[{0}] {1}", ex.GetType().Name, ex.Message);
            }
        }
    }
}
