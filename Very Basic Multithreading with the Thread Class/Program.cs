using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Very_Basic_Multithreading_with_the_Thread_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread01 = new Thread(ThreadStartingPoint);
            myThread01.Start();       // .Net will spawn the thread and call ThreadStartingPoint()

            // We can't use myThread01 again so we'll make more Thread objects
            Thread myThread02 = new Thread(ThreadStartingPoint);
            myThread02.Start();       // .Net will spawn the thread and call ThreadStartingPoint()

            Thread myThread03 = new Thread(ThreadStartingPoint);
            myThread03.Start();       // .Net will spawn the thread and call ThreadStartingPoint()
        }

        private static void ThreadStartingPoint()
        {
            Console.WriteLine("I am your thread");
            // Do some processing here
        }
    }
}
