using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.Machine_Learning
{
    public interface IPythonScript
    {
        string ScriptPath { get; set; }
        string SetScript();
    }
}
