using System;
using System.Windows.Forms;

namespace Bioskop.UserInterface
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainCoordinator.Instance.frmLogin = new FrmLogin();
            // MainCoordinator.Instance.frmGlavna = new FrmGlavna();

            // MainCoordinator.Instance.frmGlavna.ChangePanel(new Test());
            MainCoordinator.Instance.CreateLogin();
            Application.Run(MainCoordinator.Instance.frmLogin);
        }
    }
}
