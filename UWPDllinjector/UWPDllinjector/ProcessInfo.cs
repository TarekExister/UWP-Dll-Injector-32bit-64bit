using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UWPDllinjector
{
    public class ProcessInfo
    {
        public static int GetProcessID(string ProcessName)
        {
            Process[] ProcessList = Process.GetProcesses();
            int ProcessID = 0;
            foreach (Process _this_process in ProcessList)
            {
                if (ProcessName == _this_process.ProcessName) { ProcessID = _this_process.Id; }
            }
            return ProcessID;
        }
    }
}
