using System;

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
