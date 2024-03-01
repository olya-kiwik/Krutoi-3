using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Architecture_KC
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new LodinForm());
        }
    }
}
