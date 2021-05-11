using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EmployeeManagement_AdapterDesignPattern
{
    public interface IXMLTarget
    {
        XmlDocument GetEmployeeListInXml();
    }
}
