namespace _03Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBFactory dBFactory = new DBFactory();
            Console.WriteLine("1: SQL , 2: MySQL");
            int choice = Convert.ToInt32(Console.ReadLine());

            Database database = dBFactory.GetDatabase(choice);

            Console.WriteLine(  "1: Insert, 2: Delete");
            int opChoice = Convert.ToInt32(Console.ReadLine());

            if (opChoice == 1)
            {
                database.Insert();
            }
            else
            {
                database.Delete();
            }

            Console.ReadLine();
        }
    }


    public class DBFactory
    {
        public Database GetDatabase(int choice)
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else
            {
                return new MySQL();
            }
        }
    }

    //public interface IDatabase
    //{
    //    void Insert();
    //    void Delete();
    //}

    public abstract class Database
    {
        protected abstract void DoInsert();
        protected abstract void DoDelete();
        protected abstract string GetDatabaseName();

        private string databaseName;
        public Database()
        {
            databaseName = GetDatabaseName();
        }
        public void Insert()
        {
            DoInsert();
            Console.WriteLine("Logged at " +
                DateTime.Now.ToString() +
                " - Data Inserted in " + databaseName);
        }
        public void Delete()
        {
            DoDelete();
            Console.WriteLine("Logged at " +
               DateTime.Now.ToString() +
               " - Data Deleted in "+ databaseName);
        }
    }


    //tejas
    public class SQLServer : Database
    {
        public SQLServer()
        {
            
        }
        protected override string GetDatabaseName()
        {
            return "SqlServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("SQL Server Insert Done");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("SQL Server Delete Done");
        }
    }

    //shubham
    public class MySQL : Database
    {
        protected override string GetDatabaseName()
        {
            return "MYSQL";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("MYSQL Insert Done");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("MYSQL Delete Done");
        }
    }
}
