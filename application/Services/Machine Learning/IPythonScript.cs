using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.Machine_Learning
{
    //indeholder path til python.py fil og en metode til at sætte et script i
    public interface IPythonScript
    {
        string ScriptPath { get; set; }
        string SetScript();
    }
}
