using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SalesManageSystem
{
    class XMLHelper
    {
        private XmlDocument xmlDocu;
        public XMLHelper(string xmlfileName)
        {
            xmlDocu = new XmlDocument();
            xmlDocu.LoadXml(xmlfileName);
        }
    }
}
