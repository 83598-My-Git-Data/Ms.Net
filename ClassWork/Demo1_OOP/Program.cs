namespace Demo1_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReportFactory factory = new ReportFactory();

            Console.WriteLine("1:PDF,2:DOCX");
            int choice = Convert.ToInt32(Console.ReadLine());
            Report report = factory.GetReport(choice);
            report.GenerateReport();
            Console.ReadLine();
        }
    }

    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            if (choice == 1)
            {
                return new PDF();
            }
            else
            {
                return new DOCX();

            }
        }
    }
    public abstract class Report
    {
        protected abstract void Create();
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public virtual void GenerateReport()
        {
            Create();
            Parse();
            Validate();
            Save();
        }

    }

    public class PDF : Report
    {
        protected override void Create()
        {
            Console.WriteLine("Pdf File Created..");
        }
        protected override void Parse()
        {
            Console.WriteLine("Pdf File Parsed..");
        }
        protected override void Validate()
        {
            Console.WriteLine("Pdf File Validated..");
        }
        protected override void Save()
        {
            Console.WriteLine("Pdf File Saved.");
        }
    }
    public class DOCX : Report
    {
        protected override void Create()
        {
            Console.WriteLine("DOCX File Created");
        }

        protected override void Parse()
        {
            Console.WriteLine("DOCX Data Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("DOCX Data Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }

    }
}