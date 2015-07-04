using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsumerProducerColorSync {
  class Program {
    
    const int REPEAT_TIMES = 10;

    static Object lockObject = new Object();
    
    static int buffer;

    static void Producer() {
      Random random = new Random();
      for (int i = 0; i < REPEAT_TIMES; i++) {
        buffer = random.Next(100);

        lock(lockObject){
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("producer [{0}]: I put {1} in buffer", i, buffer);
          Console.ForegroundColor = ConsoleColor.White;
        }

      }
    }

    static void Consumer() {

      for (int i = 0; i < REPEAT_TIMES; i++) {

        lock (lockObject) {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("consumer [{0}]: I get {1} from buffer", i, buffer);
          Console.ForegroundColor = ConsoleColor.White;
        }

      }
    }


    static void Main(string[] args) {

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
