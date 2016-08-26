using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FB
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            FormManager manager = new FormManager();
            manager.Run();
        }
    }
}
