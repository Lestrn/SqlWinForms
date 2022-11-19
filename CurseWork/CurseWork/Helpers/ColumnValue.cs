using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork
{
    public class ColumnValue
    {
        public ColumnValue(string columnName, string columnType, string value)
        {
            ColumnName = columnName;
            ColumnType = columnType;
            Value = value;
        }

        public string ColumnName { get; set; }

        public string ColumnType { get; set; }

        public string Value { get; set; }

        public string GetValue()
        {
            if (ColumnType == "string")
            {
                return $"\"{Value}\"";
            }

            return Value;
        }

        public string GetQueryValue()
        {
            string result = $"{ColumnName}={GetValue()}";
            return result;
        }
    }
}
