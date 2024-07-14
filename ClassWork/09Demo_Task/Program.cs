namespace _09Demo_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            B obj2 = new B();

            obj1.M1();
            Console.ReadLine();
        }
    }

    public class A
    {
        public void M1() //one parameter is allowed here
        {
            //Call B's M2 method here
            //and print output of M2 here

            //1. You will not create B object here
            //2. You will not make B or m2 or anything static
            //3. Allowed parameter in m1 will not be object
            //4. Allowed parameter in m1 will not be B's object
            //5. Allowed parameter in m1 will not be B's string
            //6. No inheritance of A into B or B into A is allwoed
            //7. No other class should be inherited anyehere
            //8. No overloading, overriding, abstract, interface, sealed, getter setter is not allwoed
            //9. Events is not allowed
            //10: Nothing other than taught in sessions in allowed 
            //11. Nothing hard coded needs to be printed like "abcd"
        }
    }

    public class B
    {
        public string M2()
        {
            return "ABCD";
        }
    }
}
