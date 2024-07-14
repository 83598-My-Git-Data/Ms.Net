using MathLib;

namespace _00Demo_MenuDrivenApp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Maths obj = new Maths();

            while (true)
            {
                Console.WriteLine("Enter Value of X");
                string xValue = Console.ReadLine();
                int x = Convert.ToInt32(xValue);

                Console.WriteLine("Enter Value of Y");
                string yValue = Console.ReadLine();
                int y = Convert.ToInt32(yValue);


                Console.WriteLine("Choose Operation:1 : Add, 2: Sub");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (opChoice)
                {
                    case 1:
                        result = obj.Add(x, y);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = obj.Sub(x, y);
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string choice = Console.ReadLine();
                if (choice != "y")
                {
                    break;
                }
            }
            Console.WriteLine("Hit Enter to Close App");
            Console.ReadLine();
        }
    }

   
}
