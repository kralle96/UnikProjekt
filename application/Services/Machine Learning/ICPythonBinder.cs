using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Machine_Learning
{
    interface ICPythonBinder
    {
        string MakePrediction(string script, string pyPath, List<object> parameters);
    }
}
