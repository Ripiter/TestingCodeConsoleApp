using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TestingCodeConsoleApp.UsefullStuff
{
    class XmlParser
    {

        public void MakeingXmls()
        {
            // Set the type of encoding unicode = utf16
            Encoding encoding = Encoding.Unicode;
            XElement element = new XElement("Root", 
                               new XElement("Name","Steve"),
                               new XElement("Time","12:00"));

            byte[] xmlByte = ConvertXmlToByteArray(element, encoding);
            XElement el = ConvertByteArrayToXml(xmlByte);

            // gets name and the time from the xml element
            string name = (string)el.Element("Name");
            string time = (string)el.Element("Time");
            Console.WriteLine($"Name {name} send messaged {time} o'clock");
        }

        byte[] ConvertXmlToByteArray(XElement xml, Encoding encoding)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                // Add formatting and other writer options here if desired
                settings.Encoding = encoding;
                settings.OmitXmlDeclaration = true; // No prolog
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    xml.Save(writer);
                }
                return stream.ToArray();
            }
        }

        XElement ConvertByteArrayToXml(byte[] data)
        {
            // Interpret the byte array allowing any encoding
            XmlReaderSettings settings = new XmlReaderSettings();
            // Add validation and other reader options here if desired
            using (MemoryStream stream = new MemoryStream(data))
            using (XmlReader reader = XmlReader.Create(stream, settings))
            {
                return XElement.Load(reader);
            }
        }

        XElement ConvertByteArrayToXml(byte[] data, Encoding encoding)
        {
            // Interpret the byte array according to a specific encoding
            using (MemoryStream stream = new MemoryStream(data))
            using (StreamReader reader = new StreamReader(stream, encoding, false))
            {
                return XElement.Load(reader);
            }
        }
    }
}
