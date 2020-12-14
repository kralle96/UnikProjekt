using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Machine_Learning
{
    public interface IPythonScript
    {
        string ScriptPath { get; set; }
        string SetScript();
    }
}
