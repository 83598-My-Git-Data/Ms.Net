using Attrributes;
namespace POCO
{
    [Table(TableName = "Employee")]

    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        [Column(ColumnName = "Address", ColumnType = "varchar(50)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        [Column(ColumnName = "Name", ColumnType = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Column(ColumnName = "No", ColumnType = "int")]
        public int No
        {
            get { return _No; }
            set { _No = value; }
        }
    }
    [Table(TableName = "Orders")]
    public class Order
    {
        private int _OrderID;
        private string _OrderItem;

        [Column(ColumnName = "OItem", ColumnType = "varchar(200)")]
        public string OrderItem
        {
            get { return _OrderItem; }
            set { _OrderItem = value; }
        }

        [Column(ColumnName = "OrderID", ColumnType = "int")]
        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

    }
}
