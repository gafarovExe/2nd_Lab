using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the number of students: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double sumBOOOOOYs = 0;
        double sumGIIIIIIRls = 0;
        double countBOOOOOOOYs = 0;
        double countGIIIIIIIRLs = 0;
        Console.WriteLine("To enter the height of a boy, enter the letter 'B', to enter the height of a girl, enter the letter 'G'.");
        Console.WriteLine("Enter height in the format: 'Gender' + 'Growth' (Ordinary quotation marks are not required).");
        for (int i=0; i<n; i++)
        {
            char a = Convert.ToChar(Console.Read());
            double x = Convert.ToDouble(Console.ReadLine());
            if (a == 'B') {sumBOOOOOYs = sumBOOOOOYs + x;countBOOOOOOOYs++;}
            else  {sumGIIIIIIRls = sumGIIIIIIRls + x; countGIIIIIIIRLs++;}
        }
        if (countBOOOOOOOYs == 0)
        {
            Console.WriteLine("Average height of Girls = " + sumGIIIIIIRls / countGIIIIIIIRLs);
            return 0;
        }
        if (countGIIIIIIIRLs == 0)
        {
            Console.WriteLine("Average height of Boys = " + sumBOOOOOYs / countBOOOOOOOYs);
            return 0;
        }
        Console.WriteLine("Average height of Boys = " + sumBOOOOOYs/countBOOOOOOOYs);
        Console.WriteLine("Average height of Girls = " + sumGIIIIIIRls / countGIIIIIIIRLs);
        return 0;
    }
}