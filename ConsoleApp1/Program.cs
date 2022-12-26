using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            // var xml = XElement.Load(@"C:\Users\Александр\Desktop\333.xml");
            Console.WriteLine("Введите путь к файлу XML");
            var path = Console.ReadLine();
            var xml = XElement.Load(path);
            using (StreamWriter sw = new StreamWriter(@"file2.csv"))
            {
                foreach (XElement mod in xml.Elements("module"))
                {
                    XAttribute tag = mod.Attribute("tag");
                    XElement disc = mod.Element("description");
                    Console.WriteLine(tag.Value);


                    sw.WriteLine(tag.Value +" "+ disc.Value);
                    
                }
            }
            Console.WriteLine("Файл сохранен в папку с этим решением(ConsoleApp1/ConsoleApp1/bin/Debug).Нажмите Enter чтобы закрыть консоль");
            Console.ReadKey();
           
        }
    }
}

