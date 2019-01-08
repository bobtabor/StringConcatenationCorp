using System;

namespace StringConcatenationCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine(" String Concatenation Corp");
            Console.WriteLine("     Collections App");
            Console.WriteLine("============================");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("       Name: ");
            string name = Console.ReadLine();

            Console.Write("  Invoice #: ");
            string invoice = Console.ReadLine();

            Console.Write("Amount Owed: ");
            string amount = Console.ReadLine();

            Console.Write("  Date Owed: ");
            string date = Console.ReadLine();            

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Dear " + name + ",");

            Console.WriteLine("");

            Console.Write("It has come to our attention that you have not submitted a payment for invoice ");
            Console.Write(invoice);
            Console.Write(" and your account with String Concatenation Corp is in arrears.  Please submit ");
            Console.Write(amount);
            Console.Write(" by ");
            Console.Write(date);
            Console.WriteLine(" otherwise we shall taunt you a second time.");

            Console.WriteLine("");
            Console.WriteLine("Regards,");
            Console.WriteLine("Bob Tabor");
            Console.WriteLine("Collections Department");
            Console.WriteLine("String Concatenation Corp");

        }
    }
}
