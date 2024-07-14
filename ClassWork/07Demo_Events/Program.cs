namespace _07Demo_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Button button1 = new Button();
            Student atharva = new Student();

          //EventHandler pointer = new EventHandler(CallMe);
            MyDelegate rohit = new MyDelegate(OnProposalAccepted);
            MyDelegate shantanu = new MyDelegate(OnProposalRejected);
          
          //button1.Click +=pointer;
            atharva.Accepted += rohit;
            atharva.Rejected += shantanu;

            Console.WriteLine("Kuch to bol:");
            string message = Console.ReadLine();

           //below code is like button actually clicked
            atharva.Propose(message);

            Console.ReadLine();
        }

        //public void CallMe(object sender , EventArgs e)
        //{
        // messagebox.show("this is test)
        //}
        public static void OnProposalAccepted()
        {
            Console.WriteLine("PARTY @JW!! ");
        }

        public static void OnProposalRejected()
        {
            Console.WriteLine("PARTY @PYASA!! ");
        }
    }
    //public delegate void EventHandler(object sender, EventArgs e);
    public delegate void MyDelegate();
    public class Student //public class Button
    {
        //public event EventHandler Click;
        public event MyDelegate Accepted;
        public event MyDelegate Rejected;

        public void Propose(string message)
        {
            //If the button is clicked!!..continuous check
            if(message != "i am from sunbeam")
            {
                //if clicked
                Accepted(); //Click(this, new EventArgs());
            }
            else
            {
                Rejected();
            }
        }
    }
}
