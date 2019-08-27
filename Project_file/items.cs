using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace Project_file
{
    class items
    {
        public void add_items()
        {
            if (!File.Exists("item.xml"))
            {
                XmlWriter x = XmlWriter.Create("item.xml");

                x.WriteStartDocument();
                x.WriteStartElement("Table");
                x.WriteAttributeString("Name", "items");
                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("1");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Crepe");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("60");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("3");
                x.WriteEndElement();

                x.WriteEndElement();

                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("2");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Pizza");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("100");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("6");
                x.WriteEndElement();

                x.WriteEndElement();


                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("3");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Salad");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("30");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("7");
                x.WriteEndElement();

                x.WriteEndElement();


                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("4");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Chicken");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("45");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("10");
                x.WriteEndElement();

                x.WriteEndElement();


                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("5");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Drink");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("40");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("4");
                x.WriteEndElement();

                x.WriteEndElement();


                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("6");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Zalabya");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("50");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("5");
                x.WriteEndElement();

                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("7");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Beef Burger");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("60");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("12");
                x.WriteEndElement();

                x.WriteStartElement("item");

                x.WriteStartElement("id");
                x.WriteString("8");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Cake");
                x.WriteEndElement();

                x.WriteStartElement("price");
                x.WriteString("40");
                x.WriteEndElement();

                x.WriteStartElement("Ordered");
                x.WriteString("2");
                x.WriteEndElement();

                x.WriteEndElement();
                x.WriteEndDocument();
                x.Close();
            }
        }
    }
}
