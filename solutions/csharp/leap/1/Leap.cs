public static class Leap
{
    public static bool IsLeapYear(int year)
    {
       if (year % 400 ==0)
       {
           Console.WriteLine(" Leap Year",year);
               return true;
       }
        if (year % 100 == 0)
        {
            Console.WriteLine("not leap year",year);
                return false;
        }
         return year % 4 == 0;
    }
}