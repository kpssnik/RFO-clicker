using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFO_Clicker
{
    public static class Config
    {
        // private static string configFileName = "config.json";

        public static Keys PressButton { get; set; } = Keys.F10;
        public static int IntervalMinTime { get; set; } = 64;
        public static int IntervalMaxTime { get; set; } = 500;

        public static string TargetProcessName { get; } = "RF_Online.bin";
    }
}
