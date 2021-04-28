using System;

public class Example2
{
   public static void Main()
   {
    System.DateTime moment = new System.DateTime(2021, 4, 28, 15, 10, 32, 11);

	Console.WriteLine("year = " +moment.Year);

	Console.WriteLine("month = " +moment.Month);

	Console.WriteLine("day = " +moment.Day);

	Console.WriteLine("hour = " +moment.Hour);

	Console.WriteLine("minute = " +moment.Minute);

	Console.WriteLine("second = " +moment.Second);

	Console.WriteLine("millisecond = " +moment.Millisecond);
    
   }
}