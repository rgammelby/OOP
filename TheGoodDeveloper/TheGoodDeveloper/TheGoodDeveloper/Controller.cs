using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodDeveloper
{
    /// <summary>
    /// The class <c>Controller</c> creates the instances and runs the methods necessary for the program to function.
    /// </summary>
    internal class Controller
    {
        View v = new View();

        public void Start()
        {
            var path = @"C:\temp\log.txt";
            Log log = new Log(path);

            v.AnalyseDataCallout();
            DataAnalysis data = new DataAnalysis();
            v.Print(data.AnalyseData(log.GetLog()));
            v.DataAnalysedCallout();
        }
    }
}
