namespace _01Demo_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReportFactory reportFactory = new ReportFactory();
            Console.WriteLine("1: PDF, 2: DOCX, 3: JSON, 4: XML");
            int choice = Convert.ToInt32(Console.ReadLine());

            Report report = reportFactory.GetReport(choice);
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
            else if (choice ==2 )
            {
                return new DOCX();
            }
            else if (choice == 3)
            {
                return new JSON();
            }
            else
            {
                return new XML();
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

    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();

        public override void GenerateReport()
        {
            Create();
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }

    public class PDF : Report
    {
        protected override void Create()
        {
            Console.WriteLine("PDF File Created");
        }

        protected override void Parse()
        {
            Console.WriteLine("PDF Data Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("PDF Data Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
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

    public class JSON : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("JSON File Created");
        }

        protected override void Parse()
        {
            Console.WriteLine("JSON Data Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON Data Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON Saved");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("JSON Revlidated");
        }

    }

    public class XML : SpecialReport
    {
        protected override void Create()
        {
            Console.WriteLine("XML File Created");
        }

        protected override void Parse()
        {
            Console.WriteLine("XML Data Parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("XML Data Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("XML Saved");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("XML Revlidated");
        }

    }
}
