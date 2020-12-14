using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.Machine_Learning
{
    public class CPythonBinder
    {
        public string MakePrediction(string script, string pyPath, List<object> parameters)
        {


            String prg = script;
            StreamWriter sw = new StreamWriter(pyPath);
            sw.Write(prg); // write this program to a file
            sw.Close();


            Process p = new Process(); // create process (i.e., the python program
            p.StartInfo.FileName = "python.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
            foreach (object o in parameters)
            {
                pyPath = pyPath + " " + o;
            }
            p.StartInfo.Arguments = pyPath; // start the python program with two parameters

            p.Start(); // start the process (the python program)
            StreamReader s = p.StandardOutput;
            String output = s.ReadToEnd();
            //      string[] r = output.Split(new char[] { ' ' }); // get the parameter
            p.WaitForExit();

            return output;
        }
    }
}
