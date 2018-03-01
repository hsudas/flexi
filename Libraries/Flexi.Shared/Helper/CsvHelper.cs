using System;
using System.Collections.Generic;
using System.IO;

namespace Flexi.Shared.Helper
{
    public class CsvHelper
    {
        private static readonly Lazy<CsvHelper> lazy = new Lazy<CsvHelper>(() => new CsvHelper());
        public static CsvHelper Instance { get { return lazy.Value; } }

        private CsvHelper()
        {
        }

        public List<String> ReadExcel(string path)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            List<string> headerList = new List<string>();
            //headerList.Add("ASIN");
            //if (!ControlExcelData(headerList, xlRange))
            //{
            //    xlWorkbook.Close();
            //    return;
            //}
            List<String> excelDataList = PrepareDataFromExcel(xlRange);
            xlWorkbook.Close();
            return excelDataList;
        }

        private List<String> PrepareDataFromExcel(Microsoft.Office.Interop.Excel.Range xlRange)
        {
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            string rowString = String.Empty;
            //List<List<String>> strList = new List<List<String>>();
            List<String> rowList = new List<string>();
            //StringBuilder builder = new StringBuilder();
            //string[] strArray = new string[,] { };
            string[][] jagged = new string[][] { };

            for (int i = 2; i <= rowCount; i++)
            {
                rowString = String.Empty;
                for (int j = 1; j < colCount; j++)
                {

                    if (xlRange.Cells[i, j].Value2 != null)
                    {
                        rowString += xlRange.Cells[i, j].Value2.ToString();
                    }
                    rowString = rowString + "|";
                }
                rowList.Add(rowString.Substring(0, rowString.Length - 1));
            }

            return rowList;
        }

        public List<List<string>> ParseTabDelimitedFile(string path, bool isWithHeader = true)
        {
            return ParseDelimitedFile(path, isWithHeader, '\t');
        }

        private List<List<string>> ParseDelimitedFile(string path, bool isWithHeader, char delimiter, bool removeBakslashes = false)
        {
            List<List<string>> rowList = new List<List<string>>();
            using (var file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var delimiters = new char[] { delimiter };
                    var segments = line.Split(delimiters); //, StringSplitOptions.RemoveEmptyEntries);
                    var row = new List<string>();
                    foreach (var segment in segments)
                    {
                        if (removeBakslashes)
                        {
                            row.Add(segment.Replace("\"", string.Empty));
                        }
                        else
                        {
                            row.Add(segment);
                        }
                    }
                    rowList.Add(row);
                }
                file.Close();
            }
            if (!isWithHeader)
            {
                rowList.RemoveAt(0);
            }
            return rowList;
        }

        public List<List<string>> ParseCommaDelimitedFile(string path, bool isWithHeader = true)
        {
            return ParseDelimitedFile(path, isWithHeader, ',', true);
        }
    }
}
