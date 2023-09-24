using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodDeveloper
{
    /// <summary>
    /// The class <c>View</c> contains a method to write to the console, as well as callouts informing the user of current processes.
    /// </summary>
    internal class View
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void AnalyseDataCallout()
        {
            Print("Analysing data... \n");
        }

        public void DataAnalysedCallout()
        {
            Print("Data has been analysed. \n");
        }
    }
}
