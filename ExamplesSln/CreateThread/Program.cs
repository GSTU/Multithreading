using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CreateThread {

  class Program {


    public static void SimpleThread() {
      Console.WriteLine("I'm thread");
    }

    public static void ThreadWithParams(Object n) {
      Console.WriteLine("I'm thread with params: " + n);
    }

    static void Main(string[] args) {

      Thread thread1 = new Thread(new ThreadStart(SimpleThread));
      Thread thread2 = new Thread(new ParameterizedThreadStart(ThreadWithParams));
      thread2.Start("PARAM");
      thread1.Start();

      Thread.Sleep(1000);
      Console.WriteLine("I'm main thread");

      Console.ReadKey();
    }

  }
}
