using System;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //   Application.Run(new MainForm(args));
            //  Application.Run(new Form1());
            Application.Run(new Form_PlayList(args));
        }
    }
}
