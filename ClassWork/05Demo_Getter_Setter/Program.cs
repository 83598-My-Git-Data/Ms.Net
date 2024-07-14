namespace _05Demo_Getter_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp emp = new Emp();
            //emp.setName("Mahesh");
            //Console.WriteLine(emp.getName());

            //Emp emp = new Emp();
            //emp.Name = "Test";
            //Console.WriteLine(  emp.Name);
            //Console.ReadLine();

            Emp emp = new Emp();
            emp.No = 1;
            emp.Name = "test";
            emp.Address = "pune";

            //Console.WriteLine(  emp.No);
            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.Address);
            Console.WriteLine(emp.GetDetails());
            Console.ReadLine();
        }
    }

    public class Emp
    {
        #region Java way of writing getter setter

        //private string _Name;

        //public string getName()
        //{
        //    return _Name;
        //}

        //public void setName(string name)
        //{
        //    _Name = name;
        //}

        #endregion

        #region .NET Way of writing getter / setter :Property
        //private string _Name;
        //public string Name
        //{
        //    get { return _Name; }
        //    set { _Name = value; }
        //}
        #endregion

        #region Private Members
        private int _No;
        private string _Name;
        private string _Address;
        #endregion

        #region Properties
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        #endregion

       public string  GetDetails()
        {
            return No.ToString() + Name + Address;
        }

    }
}
