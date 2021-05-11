using System;
using System.Xml;

namespace EmployeeManagement_AdapterDesignPattern
{
    class Program
    {   
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            string result=employeeManager.GetEmployeeData();
            Console.WriteLine(result);

            IXMLTarget xmlTarget=new EmployeeAdapter();
            EmployeeClient employeeClient = new EmployeeClient(xmlTarget);
            XmlDocument resultXml = employeeClient.GetEmployeeXmlData();
            Console.WriteLine(resultXml);

            Console.WriteLine("Hello World!");
        }
    }
}
