using System;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Database_Model database_model = new Database_Model();

            database_model.Initialize_Database();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
