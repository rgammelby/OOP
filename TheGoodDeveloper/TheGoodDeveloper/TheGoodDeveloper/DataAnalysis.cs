using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodDeveloper
{
    /// <summary>
    /// The class <c>DataAnalysis</c> looks through a log file (or any text string), searching for a particular error code (357).
    /// </summary>
    internal class DataAnalysis
    {
        public string AnalyseData(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.Contains("357"))
                {
                    // implement custom exception
                    return "The log contains a special error code \"357\". \n";
                }
                else
                {
                    return "Log analyzed. \n";
                }
            }
            else
            {
                return "The log file is empty. \n";
            }
        }
    }
}
