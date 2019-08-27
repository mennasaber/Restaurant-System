using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project_file
{
    class delivery_boy
    {
        internal void assign_delivery_boy(string area_code)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("delivery.xml");
            XmlNodeList list = doc.GetElementsByTagName("delivery");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList c = list[i].ChildNodes;
                if (c[0].InnerText == area_code)
                {
                    int num = int.Parse(c[3].InnerText);
                    num++;
                    c[3].InnerText = num.ToString();
                }
            }
            doc.Save("delivery.xml");

            XmlDocument doc2 = new XmlDocument();
            doc.Load("delivery_boy.xml");
            XmlNodeList list2 = doc.GetElementsByTagName("delivery_boy");
            for (int i = 0; i < list2.Count; i++)
            {
                XmlNodeList c = list2[i].ChildNodes;
                if (c[1].InnerText == area_code)
                {
                    int num = int.Parse(c[3].InnerText);
                    num++;
                    c[3].InnerText = num.ToString();
                }
            }
            doc.Save("delivery_boy.xml");
        }
    }
}
