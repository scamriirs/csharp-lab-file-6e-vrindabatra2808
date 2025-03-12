//Indexer Overloading
using System;

namespace ndexers
{   
    class Program
    {
        class Guides
        {            
            private string[] _guideNames = new string[10];
            
            public string this[int index]
            {
                get { return _guideNames[index]; }
                set { _guideNames[index] = value; }
            }
            
            public string this[float id]
            {
                get { return _guideNames[1]; }
                set { _guideNames[1] = value; }
            }

            public string this[double id]
            {
                get { return "This is read only"; }
                set { }
            }
        }
        static void Main(string[] args)
        {
            Guides writtenGuides = new Guides();
            double k = 10.0;
            writtenGuides[0] = "Written ";
            writtenGuides[1.0f] = "Guides";
            Console.WriteLine(writtenGuides[k]);
            Console.WriteLine(writtenGuides[0]);
            Console.WriteLine(writtenGuides[0] + writtenGuides[1.0f]);
            Console.ReadKey();
            }
    }
}
