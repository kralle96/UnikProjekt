using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.Machine_Learning
{
    //interface til CPythonBinder - kører en givet python.py fil så længe script, filepath og parametre gives
    public interface ICPythonBinder
    {
        string MakePrediction(string script, string pyPath, List<object> parameters);
    }
}
