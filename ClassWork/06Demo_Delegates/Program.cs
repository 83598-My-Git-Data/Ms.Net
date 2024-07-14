namespace _06Demo_Delegates
{
    delegate bool MyDelegate(int i);

    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directly calling check
            ///bool result = Check(20);

            //Calling Check via Pointer / Function Pointer / Delegate
            MyDelegate pointer = new MyDelegate(Check);
            bool result = pointer(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool Check(int i)
        {
            return i > 10;
        }

    }
}
