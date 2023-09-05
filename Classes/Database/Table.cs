using System.ComponentModel;

namespace SBS_BarthLogistic.Classes.Database
{
    public class Table
    {
        public Table(string tableCatalog, string tableSchema, string tableName)
        {
            TableCatalog = tableCatalog;
            TableSchema = tableSchema;
            TableName = tableName;
        }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("კატალოგი")]
        public string TableCatalog { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("სქემა")]
        public string TableSchema { get; private set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("სახელი")]
        public string TableName { get; private set; }
    }
}