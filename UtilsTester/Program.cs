using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsTester {
    class Program {
        static void Main(string[] args) {
            UtilsLib.ConsoleToFileManager cm = new UtilsLib.ConsoleToFileManager();
            cm.StartWriter("testfile.txt");
            Console.WriteLine("try");
            cm.EndWriter();
        }
    }
}
