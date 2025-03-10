namespace domasno_1_i_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);
            Console.WriteLine(number1);

            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);
            Console.WriteLine(number2);

            string input33 = Console.ReadLine();
            Console.WriteLine(input33);

            if (input33 == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (input33 == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (input33 == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else if (input33 == "*")
            {
                Console.WriteLine(number1 * number2);
            }

            // ====================================================================

            string input5 = Console.ReadLine();
            double numberr1 = double.Parse(input5);
            Console.WriteLine("num1: " + numberr1);

            string input6 = Console.ReadLine();
            double numberr2 = double.Parse(input6);
            Console.WriteLine("num2: " + numberr2);

            string input7 = Console.ReadLine();
            double numberr3 = double.Parse(input7);
            Console.WriteLine("num3: " + numberr3);

            string input8 = Console.ReadLine();
            double numberr4 = double.Parse(input8);
            Console.WriteLine("num4: " + numberr4 );

            double allnums = numberr1 + numberr2 + numberr3 + numberr4;

            Console.WriteLine("Avr Num: " + allnums / 4);
            Console.ReadLine();





            // ===================================================================
            string prvInput = Console.ReadLine();
            int prvbroj = int.Parse(prvInput);
            Console.WriteLine("First number:" + prvbroj);

            string vtorInput = Console.ReadLine();
            int vtorbroj = int.Parse(vtorInput);
            Console.WriteLine("Second number: " + vtorbroj);

            int tretbroj = default;
            int cetvrtibroj = default;

            cetvrtibroj = vtorbroj;
            cetvrtibroj = prvbroj;

            Console.WriteLine("smeni go prviot broj: " + tretbroj);
            Console.WriteLine("smeni go vtoriot broj: " + cetvrtibroj);
            Console.ReadLine();





            Console.ReadLine();

        }
    }
}
