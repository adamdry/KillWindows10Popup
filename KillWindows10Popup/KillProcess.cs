using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace KillWindows10Popup
{
    class KillProcess
    {
        public void Start(String procName)
        {

            while (true)
            {
                Process[] procsByName = Process.GetProcessesByName(procName);

                foreach (Process procByName in procsByName)
                {
                    procByName.Kill();
                }

                RefreshSysTray.RefreshTrayArea();

                Thread.Sleep(10000);
            }
        }
    }
}
