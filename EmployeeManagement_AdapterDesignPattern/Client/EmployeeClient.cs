using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EmployeeManagement_AdapterDesignPattern
{
    public class EmployeeClient
    {
        private IXMLTarget _xmlTarget;
        public EmployeeClient(IXMLTarget xmlTarget)
        {
            _xmlTarget = xmlTarget;
        }
        public XmlDocument GetEmployeeXmlData()
        {
            return _xmlTarget.GetEmployeeListInXml();
        }
    }
}
