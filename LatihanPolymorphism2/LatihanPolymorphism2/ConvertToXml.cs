using System;
using System.Xml.Serialization;

namespace LatihanPolymorphism2;

public class ConvertToXml : ConvertObject
{
    public override void Convert(Mahasiswa mhs)
    {
        using (StringWriter writer = new StringWriter()) //fungsinya sama seperti membuat objek baru.
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
            serializer.Serialize(writer, mhs);

            string xml = writer.ToString();
            
            Console.WriteLine("Hasil konversi ke XML : \n");
            Console.WriteLine(xml);
        }
        
        
    }
}