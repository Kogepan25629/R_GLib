using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_GeneralLib
{
    class Program
    {
        static void Main(string[] args)
        {
            RG.OutputLog("INFO");
            RG.OutputLog("WARM", RG.WARM);
            RG.OutputLog("ERROR", RG.ERROR);
            RG.OutputLog("INFO", RG.INFO, false);
            RG.OutputLog("WARM", RG.WARM, false);
            RG.OutputLog("ERROR", RG.ERROR, false);
            while (true) {
                Console.Write(">");
                Console.ReadLine();
            }
        }
    }
}
