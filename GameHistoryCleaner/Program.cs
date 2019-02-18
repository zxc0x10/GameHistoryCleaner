using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GameHistoryCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 5;
            Console.WindowWidth = 50;

            Console.WriteLine("Steam Game History Cleaner - github.com/zxc0x10 \n");
            System.Threading.Thread.Sleep(5000);
            Process.Start("steam://friends/status/offline");
            System.Threading.Thread.Sleep(3000);
            Process.Start("steam://run/413851");
            System.Threading.Thread.Sleep(3000);
            Process.Start("steam://run/413857");
            System.Threading.Thread.Sleep(3000);
            Process.Start("steam://run/413859");
            System.Threading.Thread.Sleep(3000);
            Process.Start("steam://run/413856");
            System.Threading.Thread.Sleep(5000);

            System.Diagnostics.Process.Start("taskkill.exe", " /f /im steam" + ".exe");

            foreach (var process in Process.GetProcessesByName("html5app_steam"))
            {
                process.Kill();
            }

            System.Threading.Thread.Sleep(3000);
            Process.Start("steam://url/SteamIDMyProfile");

            Console.WriteLine("Successfully cleaned recent game history.");
            Console.ReadKey();
        }
    }
}