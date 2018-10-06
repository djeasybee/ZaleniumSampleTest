using System;
using System.Collections.Generic;
using System.IO;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using Excel;



namespace ZaleniumSampleTest
{
    class ExcelLib
    {

        private static DataTable ExcelToDataTable(string fileName)

        {
            //open file and return Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            // Createopenxmlreader via ExcelFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //Set the First Row as Name
            //excelReader.IsFistRowAsColumnNames = true;


          



            //Run as DataSet
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true

                }


            });

            //Get all the tables
            DataTableCollection table = result.Tables;

            //Store 

            DataTable resultTable = table["Sheet1"];

            //
            return resultTable;
        }





      static  List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col <= table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        
public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public  class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }
    }
}
