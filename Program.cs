using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Survey
{
    internal static class Program
  {
    public static readonly Main main = new Main();
    public static readonly Code code = new Code();
    public static readonly Result result = new Result();
    public static readonly Check check = new Check();
    public static readonly Login login = new Login();
    public static readonly Chart chart = new Chart();
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    [STAThread]
        static void Main()
        {
          Application.EnableVisualStyles();
          Application.Run(main);
        }
    }
}
