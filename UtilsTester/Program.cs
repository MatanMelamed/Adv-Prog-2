using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Console application designed to test utilities library from a different project.
///  All code below was written by Matan.
/// </summary>
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
