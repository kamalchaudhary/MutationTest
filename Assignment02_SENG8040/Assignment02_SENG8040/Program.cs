using System;

namespace Assignment02_SENG8040
{
    class Program
    {
        static void Main(string[] args)
        {

            TriangleSolver T = new TriangleSolver();
            int selection = 0;
            int One, Two, Three;
            try {
                while (selection != 2)
                {
                    selection = Menuselection();
                    switch (selection)
                    {
                        case 1:
                            Console.Write("Enter one side of triangle:");
                            One = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second side of triangle:");
                            Two = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter third side of triangle:");
                            Three = Convert.ToInt32(Console.ReadLine());
                            T.Analyze(One, Two, Three);
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
                Console.Write("Please enter Number only");
            }
            
        }

        public static int Menuselection()
        {
            int selection;
            Console.WriteLine();
            Console.WriteLine("1 = Enter triangle dimensions");
            Console.WriteLine("2 = Exit");

            Console.WriteLine();
            Console.WriteLine("Please select the number to perform Operation : ");
            selection = Convert.ToInt32(Console.ReadLine());

            if (selection > 2 || selection < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Please select valid number from the list to perform operation : ");
                Console.WriteLine();
            }

            Console.WriteLine();
            return selection;
        }
    }
}
