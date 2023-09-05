using System.ComponentModel;

namespace SBS_BarthLogistic.Classes.Database
{
    public class Column
    {
        public Column(Table table, string columnName, string tableSchema, string columnDefault,
            string isNullable, SqlTypes dataType)
        {
            Table = table;
            ColumnName = columnName;
            TableSchema = tableSchema;
            ColumnDefault = columnDefault;
            IsNullable = isNullable == "YES";
            DataType = dataType;
        }

        [Browsable(false)]
        public Table Table { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("ცხრილის სახელი")]
        public string TableName
        {
            get { return Table.TableName; }
        }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("ველის სახელი")]
        public string ColumnName { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("სქემის სახელი")]
        public string TableSchema { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("Default მნიშვნელობა")]
        public string ColumnDefault { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("NULLABLE")]
        public bool IsNullable { get; set; }

        [Browsable(false)]
        public SqlTypes DataType { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [DisplayName("ველის ტიპი")]
        public string Type
        {
            get { return DataType.DataType + ":" + DataType.CharacterMaximumLength; }
        }
    }
}