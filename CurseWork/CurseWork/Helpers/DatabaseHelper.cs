using System;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace CurseWork
{
    public static class DatabaseHelper
    {
        public static string DeleteRecordSqlQuery(string tableToDelete, ColumnValuePair whereCondition)
        {
            var sqlQuery = $"DELETE FROM {tableToDelete} WHERE {whereCondition.GetQueryValue()}";
            return sqlQuery;
        }

        public static string UpdateRecordSqlQuery(string tableToUpdate, ColumnValuePair whereCondition, params ColumnValuePair[] columnValues)
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

        public static string CreateRecordSqlQuerry(string tableToAddNewRow, params ColumnValuePair[] columnValues)
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

            foreach (ColumnValuePair columnValue in columnValues)
            {
                stringBuilder.Append($"{columnValue.GetValue()}, ");
            }

            string sqlQuery = $"{stringBuilder.ToString().Trim(' ').Trim(',')}{")"}";
            return sqlQuery;
        }

        public static void SaveToDataBaseWithoutResult(string valueToSave, OleDbConnection dbConnection)
        {
            try
            {
                OleDbCommand dbCommand = new OleDbCommand(valueToSave, dbConnection);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public static ColumnValuePair[] GetColumnValues(string[] columsName, string[] types, string[] values)
        {
            ColumnValuePair[] columnValues = new ColumnValuePair[values.Length];
            for (int i = 0; i < columnValues.Length; i++)
            {
                columnValues[i] = new ColumnValuePair(columsName[i], types[i], values[i]);
            }
            return columnValues;
        }
    }
}
