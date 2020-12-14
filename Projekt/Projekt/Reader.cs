using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Reader
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:\\Sample.txt", Encoding.Default);
            string szoveg;
            while (!reader.EndOfStream)
            {
                szoveg = reader.ReadLine();
                Console.WriteLine(szoveg);
            }
            reader.Close();
            Console.ReadLine();
        }
    }
}
