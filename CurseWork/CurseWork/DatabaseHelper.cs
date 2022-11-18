using System.Data.OleDb;
using System.Text;

namespace CurseWork
{
    public static class DatabaseHelper
    {
        public static string DeleteRecordSqlQuery(string tableToDelete, ColumnValue whereCondition)
        {
            var sqlQuery = $"DELETE FROM {tableToDelete} WHERE {whereCondition.GetQueryValue()}";
            return sqlQuery;
        }

        public static string UpdateRecordSqlQuery(string tableToUpdate, ColumnValue whereCondition, params ColumnValue[] columnValues)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"UPDATE {tableToUpdate} SET ");
            for (int i = 0; i < columnValues.Length; i++)
            {
                if (i == columnValues.Length - 1)
                {
                    stringBuilder.Append($"{columnValues[i].GetQueryValue()} WHERE {whereCondition.GetQueryValue()}");
                    break;
                }

                stringBuilder.Append($"{columnValues[i].GetQueryValue()}, ");
            }
            
            var sqlQuery = stringBuilder.ToString();
            return sqlQuery;
        }

        public static string CreateRecordSqlQuerry(string tableToAddNewRow, params ColumnValue[] columnValues)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"INSERT INTO {tableToAddNewRow} (");
            for (int i = 0; i < columnValues.Length; i++)
            {
                if (i == columnValues.Length - 1)
                {
                    stringBuilder.Append($"{columnValues[i].ColumnName}) VALUES( ");
                    break;
                }

                stringBuilder.Append($"{columnValues[i].ColumnName}, ");
            }

            foreach (ColumnValue columnValue in columnValues)
            {
                stringBuilder.Append($"{columnValue.GetValue()}, ");
            }

            string sqlQuery = $"{stringBuilder.ToString().Trim(' ').Trim(',')}{")"}";
            return sqlQuery;
        }
        public static void SaveToDataBaseWithoutResult(string valueToSave, OleDbConnection dbConnection)
        {
            OleDbCommand dbCommand = new OleDbCommand(valueToSave, dbConnection);
            dbCommand.ExecuteNonQuery();
        }
        public static ColumnValue[] GetColumnValues(string[] columsName, string[] types, string[] values)
        {
            ColumnValue[] columnValues = new ColumnValue[values.Length];
            for (int i = 0; i < columnValues.Length; i++)
            {
                columnValues[i] = new ColumnValue(columsName[i], types[i], values[i]);
            }
            return columnValues;
        }
    }
}
