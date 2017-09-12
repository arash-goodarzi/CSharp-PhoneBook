using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Project.LOGIC
{
    public class DataXMLBinary
    {
        public static string FileName = "../../Data/Files/DataBinary.xml";

        public static List<Contact> ReadXML_List(string xmlFileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
            StreamReader reader = new StreamReader(xmlFileName);

            List<Contact> people = (List<Contact>)xmlSerializer.Deserialize(reader);
            reader.Close();

            return people;
        }

        public static void WriteXML_List(List<Contact> people, string xmlFileName)
        {
            using (var writer = XmlWriter.Create(xmlFileName))
            {
                var serializer = new XmlSerializer(typeof(List<Contact>));
                serializer.Serialize(writer, people);
            }
        }
        
        public static void WriteXML_Object(Contact person)
        {
            
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Contact));

            System.IO.FileStream file = System.IO.File.Create("../../Data/Files/Contact.xml");

            writer.Serialize(file, person);
            file.Close();
        }
        
        
    }
}
