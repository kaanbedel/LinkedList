using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DizilerKaanBedel
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 1000000;
            LinkedList<int> listLinked = new LinkedList<int>();
            Random rnd = new Random(1000000);

            for (int i = 0; i < capacity; i++)
            {
                listLinked.AddLast(rnd.Next());
            }

            //Daha sonra, çıkardığımız ilk elemana ekleyeceğimiz değeri bir değişkende tutuyoruz.
            var firstValue = listLinked.First;
            var stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            listLinked.Remove(listLinked.First);
            listLinked.AddFirst(firstValue);
            stopWatch1.Stop();
            Console.WriteLine("İlk LinkedList Elemanı Çıkarma/Ekleme İşlemi: {0} Milisaniye Sürdü.", stopWatch1.Elapsed.TotalMilliseconds); Console.WriteLine();

            //Ortadaki Linked List Node elamanı bulunur.
            LinkedListNode<int> linkedListMiddle = GetMiddleNode(listLinked.First, listLinked.Count / 2 - 1);

            var stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            listLinked.AddAfter(linkedListMiddle, linkedListMiddle.Value + 1);
            listLinked.Remove(linkedListMiddle);
            stopWatch2.Stop();
            Console.WriteLine("Ortadaki LinkedList Elemanı Çıkarma/Ekleme İşlemi: {0} Milisaniye Sürdü.", stopWatch2.Elapsed.TotalMilliseconds); Console.WriteLine();

            //Daha sonra, çıkardığımız son elemana ekleyeceğimiz değeri bir değişkende tutuyoruz.
            var lastValue = listLinked.Last;
            var stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            listLinked.Remove(listLinked.Last);
            listLinked.AddLast(lastValue);
            stopWatch3.Stop();
            Console.WriteLine("Sonuncu LinkedList Elemanı Çıkarma/Ekleme İşlemi: {0} Milisaniye Sürdü.", stopWatch3.Elapsed.TotalMilliseconds);

            Console.Read();
        }
        protected static LinkedListNode<int> GetMiddleNode(LinkedListNode<int> middleNode, int middleIndex)
        {
            for (int i = 0; i < middleIndex; i++)
            {
                middleNode = middleNode.Next;
            }
            return middleNode;
        }
    }
}
