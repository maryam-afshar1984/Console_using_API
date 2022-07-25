using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntitySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call Building Get method from REST Web API with parameter
            #region building
            Console.WriteLine("Please insert the building name:");
            string builingname = Console.ReadLine();

            ConsumeBuildingAsync get = new ConsumeBuildingAsync();
            // Call REST Web API with parameter.  
            DataTable responseObj = get.GetInfo(builingname).Result;

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("------------------Calling Get Building---------------------");

            //show the result of calling get method from API
            foreach (DataRow row in responseObj.Rows)
            {
                System.IO.StringWriter sw;
                sw = new System.IO.StringWriter();
                foreach (DataColumn col in responseObj.Columns)
                    sw.Write(row[col].ToString() + "\t");
                string output = sw.ToString();
                Console.WriteLine(output);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            #endregion /building

            //Call Group Get method from REST Web API with parameter
            #region group
            Console.WriteLine("Please insert the Group name:");
            string groupname = Console.ReadLine();

            ConsumeGroupASync consumeGroupASync = new ConsumeGroupASync();
            // Call REST Web API with parameter.  
            DataTable groupObj = consumeGroupASync.GetInfo(groupname).Result;

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("------------------Calling Get Group---------------------");

            //show the result of calling get method from API
            foreach (DataRow row in groupObj.Rows)
            {
                System.IO.StringWriter sw;
                sw = new System.IO.StringWriter();
                foreach (DataColumn col in groupObj.Columns)
                    sw.Write(row[col].ToString() + "\t");
                string output = sw.ToString();
                Console.WriteLine(output);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            #endregion /group

            //Call Lock Get method from REST Web API with parameter
            #region Lock
            Console.WriteLine("Please insert the Lock name:");
            string Lockname = Console.ReadLine();

            ConsumeLockASync consumeLockASync = new ConsumeLockASync();
            // Call REST Web API with parameter.  
            DataTable lockObj = consumeLockASync.GetInfo(Lockname).Result;

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("------------------Calling Get Lock---------------------");

            //show the result of calling get method from API
            foreach (DataRow row in lockObj.Rows)
            {
                System.IO.StringWriter sw;
                sw = new System.IO.StringWriter();
                foreach (DataColumn col in lockObj.Columns)
                    sw.Write(row[col].ToString() + "\t");
                string output = sw.ToString();
                Console.WriteLine(output);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            #endregion /Lock

            //Call Media Get method from REST Web API with parameter
            #region Media
            Console.WriteLine("Please insert the Media type:");
            string MediaType = Console.ReadLine();

            ConsumeMediaASync consumeMediaASync = new ConsumeMediaASync();
            // Call REST Web API with parameter.  
            DataTable MediaObj = consumeMediaASync.GetInfo(MediaType).Result;

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("------------------Calling Get Media---------------------");

            //show the result of calling get method from API
            foreach (DataRow row in MediaObj.Rows)
            {
                System.IO.StringWriter sw;
                sw = new System.IO.StringWriter();
                foreach (DataColumn col in MediaObj.Columns)
                    sw.Write(row[col].ToString() + "\t");
                string output = sw.ToString();
                Console.WriteLine(output);
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadKey();
            #endregion /Media
        }
    }
}
