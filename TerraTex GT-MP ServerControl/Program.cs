using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraTex_GT_MP_ServerControl
{
    static class Program
    {
        public static CheckProcess Worker = null;
        public static CheckSocket CheckSocket = null;
        public static Thread WorkerThread = null;
        public static Thread CheckSocketThread = null;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
