using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Collections_Dictionary_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IDictionary<string,int> numberNames =new Dictionary<string,int>();
            numberNames.Add("Joe", 22);
            numberNames.Add("Jack", 23);
            numberNames.Add("Tom", 24);
            foreach(KeyValuePair<string,int> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            IDictionary<string,string> objectTypes = new Dictionary<string,string>();
            objectTypes.Add("Fruits","Apple, Banana, Orange, Grapes, Pineapple");
            objectTypes.Add("Vegetables","Sprouts, Carrots, Cauliflower, Peas");
            objectTypes.Add("Furnitures","Table, Chair, Sofa, Stool");
            objectTypes.Add("Hardware","Hammer, Screwdriver, Nails, Screws,crowbar");
            foreach(KeyValuePair<string,string> kvp in objectTypes)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(objectTypes.ElementAt(1).Key);//gets the key for position 1
            Console.WriteLine(objectTypes.ElementAt(1).Value);// gets the values for position 1

            objectTypes["Fruits"] = "Apple, Banana, Orange, Grapes, Pineapple, Pear";//updates all of the values in the key fruit
            Console.WriteLine(objectTypes.ElementAt(0).Value);// gets the values for position 1
            Console.WriteLine("");
            objectTypes.Remove(objectTypes.ElementAt(0).Key);//Deletes everything in position 0 of the dictionary

            Console.WriteLine("After removing Fruits from Dictionary:");
            foreach (KeyValuePair<string, string> kvp in objectTypes)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.ReadLine();

        }
    }
}