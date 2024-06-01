
using Task2;

public class Program
{
    static void Main()
    {

        int month = Convert.ToInt32(Console.ReadLine());
        {
            switch (month)
            {
                case (int)Months.January:
                case (int)Months.February:
                case (int)Months.December:
                    Console.WriteLine("winter");
                    break;

                case (int)Months.March:
                case (int)Months.April:
                case (int)Months.May:
                    Console.WriteLine("spring");
                    break;
                case (int)Months.June:
                case (int)Months.July:
                case (int)Months.August:
                    Console.WriteLine("summer");
                    break;

                case (int)Months.September:
                case (int)Months.October:
                case (int)Months.November:
                    Console.WriteLine("autumn");
                    break;
            }
        }
    }
}