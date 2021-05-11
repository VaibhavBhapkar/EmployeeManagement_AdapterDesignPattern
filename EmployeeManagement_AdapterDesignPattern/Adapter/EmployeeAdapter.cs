using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EmployeeManagement_AdapterDesignPattern
{
    public class EmployeeAdapter:IXMLTarget
    {
        public XmlDocument GetEmployeeListInXml()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            string jsonEmployeeList = employeeManager.GetEmployeeData();
            XmlDocument xmlEmployeeList = JsonConvert.DeserializeXmlNode("{\"root \":" + jsonEmployeeList + "}", "root");
            return xmlEmployeeList;
        }
    }
}
