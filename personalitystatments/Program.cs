namespace personalitystatments
{
    internal class Program
    {
        static void Main(string[] args)


        {
            double result = 0;

            Console.WriteLine("enter number1: ");
            double x= double.Parse(Console.ReadLine());

            Console.WriteLine("enter number2 : ");
            double y= double.Parse(Console.ReadLine());


            Console.WriteLine("select select one:");
            Console.WriteLine("\t +  -  *   /   ");

            switch(Console.ReadLine())
            {
                case "+":
                    result = x + y;
                    Console.WriteLine($"{x} + {y} is {result}");
                    break;
                    case "-": result = x - y;
                    Console.WriteLine($"{x} {y} is your {result}");
                    break;
                    case "*": result = x * y;
                    Console.WriteLine($"{x}*{y} is your {result}");
                    break;

                    case "/": result = x / y;
                    Console.WriteLine($"{x} / {y} is your {result}");
                    break;
            }
        }
    }
}

            