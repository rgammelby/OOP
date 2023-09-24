using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace TheGoodDeveloper
{
    /// <summary>
    /// The class <c>Log</c> populates and reads from a text file, and returns exception messages if any are thrown.
    /// </summary>
    internal class Log
    {
        private string _log;
        private string _path;

        public Log(string path)
        {
            _path = path;
            Populate(path);
            _log = ReadLog(_path);
        }

        public string ReadLog(string path)
        {
            string file = "";

            try
            {
                file = File.ReadAllText(path);
            }
            catch (FileNotFoundException e)
            {
                return $"{e.Message} \nThe file either does not exist or does not match the requested file extension. Alternatively, the file path may be incorrect. \n";
            }
            catch (DirectoryNotFoundException d)
            {
                return $"{d.Message} \nThe file could not be found in the specified directory. Please check your file path. \n";
            }


            return file;
        }

        public string GetLog()
        {
            return _log;
        }

        const short ERRORS = 456;

        static void Populate(string path)
        {
            Random rng = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ERRORS; i++)
            {
                sb.Append($"ERROR {rng.Next(0, ERRORS + 1)} \r\n");
            }

            File.AppendAllText(path, sb.ToString());
        }
    }
}
