using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

                DataSet dataSet = new DataSet("ShopDB");

                DataTable dataTableOne = new DataTable("Orders");

                DataTable dataTableTwo = new DataTable("Customers");

                DataTable dataTableThree = new DataTable("Employees");

                DataTable dataTableFour = new DataTable("OrderDetails");

                DataTable dataTableFive = new DataTable("Products");

                DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
                idColumn.Unique = true;
                idColumn.AllowDBNull = false; 
                idColumn.AutoIncrement = true; 
                idColumn.AutoIncrementSeed = 1; 
                idColumn.AutoIncrementStep = 1;  

                DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));

                DataColumn priceColumn = new DataColumn("Price", Type.GetType("System.Int32"));                

               

                dataTableFive.Columns.Add(idColumn);
                dataTableFive.Columns.Add(nameColumn);
                dataTableFive.Columns.Add(priceColumn);

            DataColumn idColumnThree = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumnThree.Unique = true;
            idColumnThree.AllowDBNull = false;
            idColumnThree.AutoIncrement = true;
            idColumnThree.AutoIncrementSeed = 1;
            idColumnThree.AutoIncrementStep = 1;

            DataColumn nameColumnThree = new DataColumn("Name", Type.GetType("System.String"));

            DataColumn phoneColumnThree = new DataColumn("Phone", Type.GetType("System.String"));

            dataTableThree.Columns.Add(idColumnThree);
                dataTableThree.Columns.Add(nameColumnThree);
                dataTableThree.Columns.Add(phoneColumnThree);

            DataColumn idColumnTwo = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumnTwo.Unique = true;
            idColumnTwo.AllowDBNull = false;
            idColumnTwo.AutoIncrement = true;
            idColumnTwo.AutoIncrementSeed = 1;
            idColumnTwo.AutoIncrementStep = 1;

            DataColumn nameColumnTwo = new DataColumn("Name", Type.GetType("System.String"));

            DataColumn phoneColumnTwo = new DataColumn("Phone", Type.GetType("System.String"));

            dataTableTwo.Columns.Add(idColumnTwo);
                dataTableTwo.Columns.Add(nameColumnTwo);
                dataTableTwo.Columns.Add(phoneColumnTwo);

            DataColumn idColumnFour = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumnFour.Unique = true;
            idColumnFour.AllowDBNull = false;
            idColumnFour.AutoIncrement = true;
            idColumnFour.AutoIncrementSeed = 1;
            idColumnFour.AutoIncrementStep = 1;

            DataColumn commentColumnFour = new DataColumn("All", Type.GetType("System.String"));

            dataTableFour.Columns.Add(idColumnFour);
            dataTableFour.Columns.Add(commentColumnFour);

            DataColumn idColumnOne = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumnOne.Unique = true;
            idColumnOne.AllowDBNull = false;
            idColumnOne.AutoIncrement = true;
            idColumnOne.AutoIncrementSeed = 1;
            idColumnOne.AutoIncrementStep = 1;

            DataColumn idProductsColumn = new DataColumn("idProducts", Type.GetType("System.Int32"));

            DataColumn idCustomersColumn = new DataColumn("idCustomers", Type.GetType("System.Int32"));

            DataColumn idOrderDetailsColumn = new DataColumn("idOrderDetails", Type.GetType("System.Int32"));

            DataColumn idEmployeesDetailsColumn = new DataColumn("idEmployees", Type.GetType("System.Int32"));

            dataTableOne.Columns.Add(idColumnOne);
                dataTableOne.Columns.Add(idProductsColumn);
                dataTableOne.Columns.Add(idCustomersColumn);
                dataTableOne.Columns.Add(idOrderDetailsColumn);
                dataTableOne.Columns.Add(idEmployeesDetailsColumn);

                dataSet.Tables.Add(dataTableOne);
                dataSet.Tables.Add(dataTableTwo);
                dataSet.Tables.Add(dataTableThree);
                dataSet.Tables.Add(dataTableFour);
                dataSet.Tables.Add(dataTableFive);

                dataSet.Relations.Add("idProducts_f", dataTableFive.Columns["Id"], dataTableOne.Columns["idProducts"]);
                dataSet.Relations.Add("idCustomers_f", dataTableTwo.Columns["Id"], dataTableOne.Columns["idCustomers"]);
                dataSet.Relations.Add("idOrderDetails_f", dataTableFour.Columns["Id"], dataTableOne.Columns["idOrderDetails"]);
                dataSet.Relations.Add("idEmployees_f", dataTableThree.Columns["Id"], dataTableOne.Columns["idEmployees"]);

            
        }
    }
}
