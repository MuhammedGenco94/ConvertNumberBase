using System;
namespace ConvertNumberBase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a Decimal Number: ");
                    int starting;
                    while (!Int32.TryParse(Console.ReadLine(), out starting))
                    {
                        Console.Write("Enter a Decimal Number: ");
                    }

                    Console.Write("Enter base conversion: ");
                    int radix;
                    while (!Int32.TryParse(Console.ReadLine(), out radix))
                    {
                        Console.Write("Enter base conversion: ");
                    }

                    var Base = "";
                    var output = "";
                    var number = starting;
                    switch (radix)
                    {
                        case 2:
                            Base = "Binary";
                            break;
                        case 8:
                            Base = "Octal";
                            break;
                        case 16:
                            Base = "Hexadecimal";
                            break;
                        default:
                            Base = "Decimal";
                            radix = 10;
                            break;
                    }

                    if (Base != "Hexadecimal")
                    {
                        while (number != 0)
                        {
                            var remainder = number % radix;
                            number /= radix;
                            output = remainder.ToString() + output;
                        }
                    }
                    else
                    {
                        while (number != 0)
                        {
                            var remainder = number % radix;
                            number /= radix;
                            var remainderStr = remainder.ToString("X");
                            output = remainderStr + output;
                        }
                    }

                    Console.WriteLine($"\"{starting}\" in {Base} Base is \"{output}\" \n");
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
