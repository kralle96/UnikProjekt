using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services.Machine_Learning
{
    //Igangsætter pythonscript
    public class CPythonBinder : ICPythonBinder
    {
        public string MakePrediction(string script, string pyPath, List<object> parameters)
        {
            String prg = script;
            StreamWriter sw = new StreamWriter(pyPath);
            sw.Write(prg); //Skriv script til python.py filen
            sw.Close();


            Process p = new Process(); //opsæt processen (python-programmet)
            p.StartInfo.FileName = "python.exe"; //python.exe installeret er et krav
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false; // Gør at vi kan læse output
            foreach (object o in parameters)
            {
                pyPath = pyPath + " " + o; //tilføj parametre til pyPath så de overføres til python-programmet
            }
            p.StartInfo.Arguments = pyPath; // start programmet med alle inputparametre

            p.Start(); // start processen
            StreamReader s = p.StandardOutput; //streamreader til at læse output
            String output = s.ReadToEnd(); //læs output
            
            p.WaitForExit(); //stop processen

            return output;
        }
    }
}
