using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Async/await
//used for easily writing asynchronous code
//Async keyword is applied to method
//applying Async declares we will use Await

//we want all the methods to work parallely
//we will have output parallely

namespace AsyncAndAwait
{
    class Program
    {
        //-------------------------------------------
        //Example1
        //create 2 static methods
        public static async void Demo1()
        {
            await Task.Run(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("demo1 run");
            });
         
        }

        public static async void Demo2()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("demo2 run");
            });
        }
            //---------------------------------------------------

            //Example2
            public static async Task<int> Demo3()
            {
            int result = 10;
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Demo3 run");
                result = 20;
            });
            //return result
            return result;
            }
            

        
      
        //-------------------------------------------------
        static void Main()
        {
            //for example1
            Demo1();
            Demo2();
            test();
            Console.ReadLine();
        }
     //----------------------------------------------------

        //for example2 create 1 static method  and assign our result to await function
        public static async void test()
        {
         int result = await Demo3();
         
        }
    } 
}
