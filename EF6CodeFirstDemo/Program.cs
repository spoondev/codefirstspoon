using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new Context())
            {
                var file1 = new FileInfo()
                {
                    FileName = "Mike",
                    FilePath = "Boardman",
                    ContainerPath = "CEO",
                    Volume = "volume",
                    Size = "894793",
                    CTime = "27/10/2010 10:40:06",
                    MTime = "28/10/2010 11:36:02",
                    ATime = "28/10/2010 11:37:10",
                    Md5 = "0x9c45d107f081b22fc4cbf8892c4"

                };


                ctx.Fileinfos.Add(file1);
                ctx.SaveChanges();

                //ctx.Employees
                //    .SqlQuery("INSERT INTO Employees(EmployeeFirst,EmployeeLast,BusinessArea) VALUES ('adham','ruoss','Finance');");
                //ctx.SaveChanges();
            }


            Console.WriteLine("We made it to the end of the main method");


        }

        //public partial class ExcuteScript : Context
        //{
        //    public void Page_Load(object sender, EventArgs e)
        //    {
        //        string sqlConnectionString = @"Data Source=.;database= EF6CodeFirst;Initial Catalog=EF6CodeFirst;Integrated Security=true";

        //        string script = File.ReadAllText(@"C: \Users\George\EF6 - Code - First - Demo\EF6CodeFirstDemo\EF6 employees data.sql");

        //        SqlConnection conn = new SqlConnection(sqlConnectionString);

        //         server = new Server(new ServerConnection(conn));

        //        server.ConnectionContext.ExecuteNonQuery(script);
        //    }
        //}




    }
}


    //public string queryString = File.ReadAllText(@"C:\Users\George\EF6-Code-First-Demo\EF6CodeFirstDemo\EF6 employees data.sql");

    //private static DataSet InsertRows(DataSet dataSet, string connectionString, string queryString)
    //{
    //    Console.WriteLine(queryString);

    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        Console.WriteLine("We made it here");
    //        SqlDataAdapter adapter = new SqlDataAdapter();
    //        adapter.InsertCommand = new SqlCommand(queryString, connection);
    //        adapter.Fill(dataSet);
    //        return dataSet;
    //    }
    //}


//        private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString);

//        private string queryString = File.ReadAllText(@"./EF6 employees data.sql");
//        {
//            using (SqlConnection connection =
//                new SqlConnection(connectionString))
//            {
//                SqlDataAdapter adapter = new SqlDataAdapter();
//                adapter.InsertCommand = new SqlCommand(
//                    queryString, connection);
//                adapter.Fill(dataset);
//                        return dataset;
//            }

//       }


//    }

//}



//private static void InsertData(string connectionString)
//{
//    string queryString = File.ReadAllText(@"C:\Users\George\EF6-Code-First-Demo\EF6CodeFirstDemo\EF6 employees data.sql");
//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        SqlCommand command = new SqlCommand(queryString, connection);
//        connection.Open();
//        SqlDataReader reader = command.ExecuteReader();
//        try
//        {
//            while (reader.Read())
//            {
//                Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
//            }
//        }
//        finally
//        {
//            reader.Close();
//        }
//    }
//}




//private static void Main(string[] args)
//{
//    using (var ctx = new Context())
//    {
//        var file1 = new FileInfo()
//        {
//            FileName = "Mike",
//            FilePath = "Boardman",
//            ContainerPath = "CEO",
//            Volume = "volume",
//            Size = "894793",
//            CTime = "27/10/2010 10:40:06",
//            MTime = "28/10/2010 11:36:02",
//            ATime = "28/10/2010 11:37:10",
//            Md5 = "0x9c45d107f081b22fc4cbf8892c4"

//        };



//        ctx.Fileinfos.Add(file1);
//        ctx.SaveChanges();
//    }
//    Console.WriteLine("Demo completed.");
//    Console.ReadLine();
//    }



//public partial class ExcuteScript : Employee
//{
//    protected async System.Threading.Tasks.Task Page_LoadAsync(object sender, EventArgs e)
//    {
//        SqlConnection connection = new SqlConnection();
//        connection.ConnectionString = @"Data Source=.;database= EF6CodeFirst;Initial Catalog=EF6CodeFirst;Integrated Security=true";
//        await connection.OpenAsync();

//        SqlCommand command = connection.CreateCommand();
//        command.CommandText = File.ReadAllText(@"./EF6 employees data.sql");

//        SqlDataReader reader = await command.ExecuteReaderAsync();

//        await reader.ReadAsync();



//SqlDataReader reader = command.ExecuteReader();



//reader.Close();

//string queryString = "INSERT INTO employees";
//string connectionString = "Server=.\PDATA_SQLEXPRESS;Database=;User Id=sa;Password=2BeChanged!;";

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
//    connection.Open();
//    SqlDataReader reader = command.ExecuteReader();
//    try
//    {
//        while (reader.Read())
//        {
//            Console.WriteLine(String.Format("{0}, {1}",
//            reader["tPatCulIntPatIDPk"], reader["tPatSFirstname"]));// etc
//        }
//    }
//    finally
//    {
//        // Always call Close when done reading.
//        reader.Close();
//    }
//}

//    var employee0 = new Employee()
//    {
//        employeeFirst = "None",
//        employeeLast = "None",
//        businessArea = "None",
//        managerId = 1
//    };

//    var employee1 = new Employee()
//    {
//        employeeFirst = "Mike",
//        employeeLast = "Boardman",
//        businessArea = "CEO",
//        managerId = 1
//    };

//    var file1 = new FileInfo()
//    {
//        FileName = "Mike",
//        FilePath = "Boardman",
//        ContainerPath = "CEO",
//        Volume = "volume",
//        Size = "894793",
//        CTime = "27/10/2010 10:40:06",
//        MTime = "28/10/2010 11:36:02",
//        ATime = "28/10/2010 11:37:10",
//        Md5 = "0x9c45d107f081b22fc4cbf8892c4"

//    };


//    ctx.Employees.Add(employee0);

//    ctx.Employees.Add(employee1);
//    ctx.Fileinfos.Add(file1);
//    ctx.SaveChanges();

