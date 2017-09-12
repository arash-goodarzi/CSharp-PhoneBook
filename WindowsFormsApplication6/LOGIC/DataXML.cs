using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Project.LOGIC
{
    public class DataXML
    {
        public static string FileName = "../../Data/Files/DataXML.xml";

        public static List<Contact> ReadXML_List(string xmlFileName)  
        {
           
            List<Contact> people = new List<Contact>();
            Contact person = new Contact(); 

            if (File.Exists(xmlFileName))
            {
                XmlTextReader xmlReader = new XmlTextReader(xmlFileName);
                
                while (xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (String.Compare(xmlReader.Name, "Contact", true) == 0)
                            {
                                person = new Contact(); 
                            }
                            
                            if (String.Compare(xmlReader.Name , "Name", true) == 0)
                            {
                                xmlReader.Read();
                                if (xmlReader.NodeType == XmlNodeType.Text)
                                {
                                    person.Name = xmlReader.Value;
                                }
                                break;
                            }

                            if (String.Compare(xmlReader.Name, "Phone_Cell", true) == 0)
                            {
                                xmlReader.Read();
                                if (xmlReader.NodeType == XmlNodeType.Text)
                                {
                                    person.Phone_cell  = xmlReader.Value;
                                }
                                break;
                            }

                            if (String.Compare(xmlReader.Name, "Phone_Home", true) == 0)
                            {
                                xmlReader.Read();
                                if (xmlReader.NodeType == XmlNodeType.Text)
                                {
                                    person.Phone_home = xmlReader.Value;
                                }
                                break;
                            }

                            if (String.Compare(xmlReader.Name, "Email", true) == 0)
                            {
                                xmlReader.Read();
                                if (xmlReader.NodeType == XmlNodeType.Text)
                                {
                                    person.Email = xmlReader.Value;
                                }
                                break;
                            }

                            if (String.Compare(xmlReader.Name, "Photo", true) == 0)
                            {
                                xmlReader.Read();
                                if (xmlReader.NodeType == XmlNodeType.Text)
                                {
                                    person.Photo = xmlReader.Value;
                                }
                                break;
                            }

                            break;

                        case XmlNodeType.EndElement: //Display the end of the element.
                            
                            if (String.Compare(xmlReader.Name, "Contact", true) == 0) 
                            {
                                people.Add(person);         
                            }
                            break;
                    }
                }
                xmlReader.Close();
            }

            return people;
        }

        public static void WriteXML_List(List<Contact> people, string xmlFileName)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ArrayOfContacts");//Begin of all Contacts

            for (int i = 0; i < people.Count; i++ )
            {
                Contact person = people[i];

                xmlWriter.WriteStartElement("Contact");

                xmlWriter.WriteStartElement("Name");//Begin of Name
                xmlWriter.WriteString( person.Name );
                xmlWriter.WriteEndElement();//End of Name

                xmlWriter.WriteStartElement("Phone_Cell");//Begin of Phone Cell
                xmlWriter.WriteString( person.Phone_cell );
                xmlWriter.WriteEndElement();//End of Phone Cell

                xmlWriter.WriteStartElement("Phone_Home");//Begin of Phone Home
                xmlWriter.WriteString( person.Phone_home );
                xmlWriter.WriteEndElement();//End of Phone Home

                xmlWriter.WriteStartElement("Email");//Begin of Email
                xmlWriter.WriteString( person.Email );
                xmlWriter.WriteEndElement();//End of Email

                xmlWriter.WriteStartElement("Photo");//Begin of Photo
                xmlWriter.WriteString(person.Photo);
                xmlWriter.WriteEndElement();//End of Photo

                xmlWriter.WriteEndElement();//End of Contact
            }       

            xmlWriter.WriteEndDocument();//End of all Contacts
            xmlWriter.Close();
        }
    }
}
