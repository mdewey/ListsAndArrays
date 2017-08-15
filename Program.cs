using System;
// name space for lists
using System.Collections.Generic;
// name space for Linq;
using System.Linq;

namespace ListsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        { 
            // an array is a datastructure that holds a bunch of values of the same type
            /*
                in js:
                let arr = [1,2,3,4,5,"Billy", false, {}]
             */


            var arr = new string[2];
            arr[0] = "Billy";
            arr[1] = "Bob";
            //arr[5] =" Susan";

            var initialValues = new string[] {"hello", "world", "this", "is", "an", "array"}; 

            var scores = new int[] {1,2,3,4,5,5};

            //Console.WriteLine(initialValues[0] + "," + initialValues[1]);

            // List is a more useful form of an array. 
            // - an inherant order (access values using [])
            // - no size restrictiongs, i can Add to it al day long

            var myFirstList = new List<int>();

            myFirstList.Add(1);
            myFirstList.Add(100);
            myFirstList.Add(2000);
            myFirstList.Add(123);
            myFirstList.Add(333);
            myFirstList.Add(193643);
            myFirstList.Add(34);

            var otherList = new List<int>();
          
            myFirstList.ForEach(item => {
                //Console.WriteLine(item);
                otherList.Add(item * item);
            });

            foreach (var item in otherList)
            {
                //Console.WriteLine(item);
            }

            // WHERE is how we filter a list in .NET ( this is filter in js)
            var evenNumbers = myFirstList.Where(w => w % 2 == 0 );

            // SELECT this is === .map in js
            var squares = evenNumbers.Select(s => s * s);

            foreach(var sq in squares){
                Console.WriteLine(sq);
            }

            // Other Linq methods that are cool
            // .First
            // .OrderBy
            // .Mix .Max
            // .All
            // .Any


            // IEnumerables
            // List
            // Stack ?!?!


           // Console.WriteLine("Hello World!");
        }
    }
}
