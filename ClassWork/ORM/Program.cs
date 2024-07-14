using Attrributes;
using System.Reflection;
namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("E:\\Ms.NET\\ConsoleApp\\Database.sql", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream); ;

            Console.WriteLine("Enter The Path of POCO Library to generate Queries");
            string path = Console.ReadLine();

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (!type.Name.Contains("Attribute"))

                {
                    string queryText = "create table";

                    IEnumerable<Attribute> attributesOnType = type.GetCustomAttributes();
                    foreach (Attribute attribute in attributesOnType)
                    {
                        if (attribute is Table)
                        {
                            Table table = (Table)attribute;
                            queryText=queryText+table.TableName + "(";
                            break;
                        }
                    }
                    PropertyInfo[] allproperties = type.GetProperties();
                    foreach (PropertyInfo property in allproperties)
                    {
                        IEnumerable<Attribute> allpropertiesOnType = property.GetCustomAttributes();

                        foreach (Attribute attribute in allpropertiesOnType)
                        {
                            if (attribute is Column)
                            {
                                Column column = (Column)attribute;
                                queryText=queryText+ column.ColumnName + " "
                                    +column.ColumnType + " ";
                                break;
                            }
                        }
                    }
                    queryText = queryText.TrimEnd(',');
                    queryText = queryText + " )";
                    Console.WriteLine(queryText);
                    writer.WriteLine(queryText);
                }

            }
                writer.Close();
                stream.Close();
                Console.ReadLine();
            
        }
    }
}
