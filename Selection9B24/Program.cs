namespace Selection9B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 23;
            int num2 = 5047;
            if(num1 != num2)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("They are equal");
            }

            if (num1 < num2)
            {
                Console.WriteLine("Less than");
            }else if(num2 < num1)
            {
                Console.WriteLine("Greater than");
            }else
            {
                Console.WriteLine("Equal to");
            }

            if(num1 > num2)
            {
                if(num2 < 1000)
                {
                    Console.WriteLine("num1 is greater than num2 and num2 is less than 1000");
                }
                else
                {
                    Console.WriteLine("num1 is greater than num2 but num2 is greater than or equal to 1000");
                }
            }
            else
            {
                Console.WriteLine("num1 is not greater than num2");
            }
        }
    }
}
