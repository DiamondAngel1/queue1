using System;
using System.Text;

namespace Queue{
    internal class Program{
        static void Main(string[] args){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.AddElement("Середній приорітет", 2);
            queue.AddElement("Низький приорітет", 3);
            queue.AddElement("Високий прорітет", 1);
            Console.WriteLine("Кількість елементів в черзі: " + queue.Count());
            Console.WriteLine("Найвища приоритетність: " + queue.Bigger());
            while (!queue.Empty){
                Console.WriteLine(queue.DelElement());
            }
        }
    }
}
