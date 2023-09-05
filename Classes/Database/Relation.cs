namespace SBS_BarthLogistic.Classes.Database
{
    public class Relation
    {
        public Relation(string fkName, Column columnA, Column columnB)
        {
            FkName = fkName;
            ColumnA = columnA;
            ColumnB = columnB;
        }

        public string FkName { get; set; }
        public Column ColumnA { get; set; }
        public Column ColumnB { get; set; }
    }
}