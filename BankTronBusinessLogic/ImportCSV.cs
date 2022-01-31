using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace BankTronBusinessLogic
{
    public static class ImportCSV
    {
        public static DataTable GetRBCTransactions(String filePath)
        {
            DataTable dtRawTransactions = new DataTable();
            List<string[]> transactionList = File.ReadAllLines(filePath).Select(x => x.Split(',')).ToList();

            //import column headers then remove header row
            for (int i = 0; i < transactionList[0].Length; i++)
            {
                StringBuilder colHeader = new StringBuilder(transactionList[0].ElementAt(i));
                //colHeader.Remove(0, 1);
                //colHeader.Remove(colHeader.Length - 1, 1);
                dtRawTransactions.Columns.Add(colHeader.ToString());
            }
            transactionList.RemoveAt(0);

            //import each transaction
            transactionList.ForEach(t => {
                DataRow dr = dtRawTransactions.NewRow();
                //only import the same number of columns as there were column headers
                for (int i = 0; i < dtRawTransactions.Columns.Count; i++)
                    dr[i] = t[i];
                dtRawTransactions.Rows.Add(dr);
            });


            DataTable dtProcessedTransactions = new DataTable();
            dtProcessedTransactions.Columns.Add("Account Type");
            dtProcessedTransactions.Columns.Add("Account Number");
            dtProcessedTransactions.Columns.Add("Transaction Date");
            dtProcessedTransactions.Columns.Add("Description");
            dtProcessedTransactions.Columns.Add("Amount (CAD$)");

            foreach (DataRow row in dtRawTransactions.Rows)
            {
                DataRow dr = dtProcessedTransactions.NewRow();
                dr["Account Type"] = row["Account Type"];
                dr["Account Number"] = row["Account Number"];
                dr["Transaction Date"] = DateTime.Parse((String)row["Transaction Date"]);
                dr["Description"] = row["Description 1"] + " | " + row["Description 2"];
                dr["Amount (CAD$)"] = Decimal.Parse((String)row["CAD$"]);
                dtProcessedTransactions.Rows.Add(dr);
            }

            return dtProcessedTransactions;

        }
    }
}
