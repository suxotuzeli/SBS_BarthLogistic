using System;
using System.Data;

namespace SBS_BarthLogistic.Classes.Database
{
    public class SqlTypes
    {
        public SqlTypes(string dataType, string characterMaximumLength, string numericPrecision,
            string numericScale)
        {
            CharacterMaximumLength = characterMaximumLength;
            NumericPrecision = numericPrecision;
            NumericScale = numericScale;
            if (dataType == "numeric")
                DataType = SqlDbType.Decimal;
            else
                DataType = (SqlDbType)Enum.Parse(typeof (SqlDbType), dataType, true);
        }

        public SqlDbType DataType { get; set; }
        public string CharacterMaximumLength { get; set; }
        public string NumericPrecision { get; set; }
        public string NumericScale { get; set; }

        public override string ToString()
        {
            if (NumericPrecision != string.Empty)
                return DataType + "(" + NumericPrecision + "," + NumericScale + ")";
            if (CharacterMaximumLength != string.Empty)
                return DataType + "(" + CharacterMaximumLength + ")";
            return DataType.ToString();
        }
    }
}