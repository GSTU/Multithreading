using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolExample {
  class Program {

    static void Square(Object number) {
      try {
        Int32 num = (Int32)number;

        Console.WriteLine("{0} = {1}" ,num,  num * num);

      } catch (InvalidCastException ex) {
        Console.WriteLine(ex.Message);
      }

    }

    static void Main(string[] args) {

      for (int i = 0; i < 10; i++) {
        ThreadPool.QueueUserWorkItem(Square, i+1);
      }

      
      Thread.Sleep(6000);
      Console.ReadKey();
    }
  }
}
