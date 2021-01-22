using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();//yapı bu
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.add(1903, "Besiktas");
            myDictionary.add(1907, "Fenerbahce");

            
            
        }
    }
}
