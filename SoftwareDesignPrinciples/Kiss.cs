namespace SoftwareDesignPrinciples;

public class Kiss
{
    public void NonKiSSExample(string yearInput)
    {
        string input = yearInput;
        int year = int.Parse(input);

        bool isLeapYear = false;
        if (year % 4 == 0)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                isLeapYear = true;
            }
        }

        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }


    public void KiSSExample(string yearInput)
    {
        int year = int.Parse(yearInput);
        bool isLeapYear = (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        Console.WriteLine(isLeapYear ? $"{year} is a leap year." : $"{year} is not a leap year.");
    }
}