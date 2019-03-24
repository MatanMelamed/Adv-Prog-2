using System;
using System.IO;

namespace UtilsLib {

    public class ConsoleToFileManager {

        FileStream fStream;
        StreamWriter sWriter;
        TextWriter tWriter;

        string GetPathInProject(string fileName) {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            return path + "\\" + fileName;
        }

        public void StartWriter(string fileName = "consoleFile.txt") {
            try {
                fStream = File.Create(GetPathInProject(fileName));
                sWriter = new StreamWriter(fStream);
            }
            catch (Exception e) {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            tWriter = Console.Out;
            Console.SetOut(sWriter);
        }

        public void EndWriter() {
            Console.SetOut(tWriter);
            sWriter.Dispose();
            fStream.Dispose();
            Console.WriteLine("ConsoleToFileManager has finished.");
        }
    }

    public class tester {
        public void printTest() {
            Console.WriteLine("tester test print called.");
        }

        public int getTest() {
            return 100;
        }
    }
}
