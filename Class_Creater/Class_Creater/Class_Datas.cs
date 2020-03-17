using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Class_Creater
{
    class Class_Datas
    {
        public static string Title = "GQuote_FutStk_Sub";
        public static string Version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();

        public static string Folder_Log = Path.Combine(Application.StartupPath, "Folder_Log");                                              //  資料夾Log
        public static List<string> List_Folder = new List<string>() { Folder_Log };
    }
}
