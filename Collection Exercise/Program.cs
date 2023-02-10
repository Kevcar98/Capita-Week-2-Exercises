using System.Xml.Linq;
using System;
using System.Security.AccessControl;

namespace Collection_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var objs = new List<object>();
            objs.Add(2.5d);
            objs.Add(2.0d);
            objs.Add(3);
            objs.Add(2);
            objs.Add("Hello ");
            objs.Add("world");
            int IntSum=0;
            double DoubleSum=0;
            string StringSum="";

            foreach (var i in objs)
            {
                Console.WriteLine(i.GetType());
                //Console.WriteLine(i);

                if (i is int)
                {
                    IntSum += Convert.ToInt32(i);
                }

                
                if (i is Double)
                {
                    DoubleSum+= Convert.ToDouble(i);
                }
                if (i is String)
                {
                    StringSum+= i;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine("Print out sum");
            Console.WriteLine("sum of ints : "+IntSum);
            Console.WriteLine("sum of doubles : "+DoubleSum);
            Console.WriteLine("sum of strings : "+StringSum);




        }
    }
}
