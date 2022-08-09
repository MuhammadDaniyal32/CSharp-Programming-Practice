using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_console
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("C:\\Users\\asp\\Desktop\\xmldaniyal\\Untitled-8.xml");

            XmlNodeList elemlist = doc.GetElementsByTagName("Name");
            XmlNodeList elemlist1 = doc.GetElementsByTagName("Dob");
            XmlNodeList elemlist2 = doc.GetElementsByTagName("Email");

            for(int i = 0; i < elemlist.Count; i++)
            {
                Console.WriteLine("Name={0}\n",elemlist[i].InnerXml);
                Console.WriteLine("Dob={0}\n", elemlist1[i].InnerXml);
                Console.WriteLine("Email={0}\n", elemlist2[i].InnerXml);
            }

            Console.ReadLine();
        }

    }
}
