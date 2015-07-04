using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsumerProducerSyncBySemaphore {
  class Program {

    const int REPEAT_TIMES = 10;

    static Object lockObject = new Object();
    static Semaphore isFull;
    static Semaphore isEmpty;

    static int buffer;

    static void Producer() {
      Random random = new Random();
      for (int i = 0; i < REPEAT_TIMES; i++) {


        isEmpty.WaitOne();

        lock (lockObject) {
          buffer = random.Next(100);
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("producer [{0}]: I put {1} in buffer", i, buffer);
          Console.ForegroundColor = ConsoleColor.White;
        }

        isFull.Release();
      }
    }

    static void Consumer() {

      for (int i = 0; i < REPEAT_TIMES; i++) {

        isFull.WaitOne();
        
        lock (lockObject) {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("consumer [{0}]: I get {1} from buffer", i, buffer);
          Console.ForegroundColor = ConsoleColor.White;
        }

        isEmpty.Release();

      }
    }


    static void Main(string[] args) {

      isEmpty = new Semaphore(1, 1);
      isFull = new Semaphore(0, 1);
  
      Thread producer = new Thread(x => Producer());
      Thread consumer = new Thread(x => Consumer());
      producer.Start();
      consumer.Start();

      producer.Join();
      consumer.Join();
      Console.ReadKey();
    }
  }
}
