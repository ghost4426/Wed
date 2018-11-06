
namespace WebAdmin.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public int StoreId { get; set; }
        public string TableKey { get; set; }
        public string TableName { get; set; }
        public string StoreName { get; set; }
        public int IsAvailable { get; set; }
    }
}