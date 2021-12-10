using System;
using System.Diagnostics;

namespace moja_baza
{
    static class Call_Program
    {
        public static void CallKalkulator()
        {
            var psi = new ProcessStartInfo
            {
                //Jeśli mścieżka do pliku nie jest wpisana, to umieść wywoływany program w tym msamym katalogu co Call_Program.exe
                //                FileName = @"c:\work\test.exe",
                FileName = @"kalkulator.exe",
                Arguments = @"param1 param2",
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            var process = Process.Start(psi);
            if (process.WaitForExit((int)TimeSpan.FromSeconds(10).TotalMilliseconds))
            {
                var result = process.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        public static void CallJitsi()
        {
            var psi = new ProcessStartInfo
            {
                //Jeśli mścieżka do pliku nie jest wpisana, to umieść wywoływany program w tym msamym katalogu co Call_Program.exe
                //                FileName = @"c:\work\test.exe",
                FileName = @"C:\\Program Files\\Mozilla Firefox\\firefox.exe",
                Arguments = @"https://meet.jit.si/ciekawe_projekty",
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            var process = Process.Start(psi);
            if (process.WaitForExit((int)TimeSpan.FromSeconds(10).TotalMilliseconds))
            {
                var result = process.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        public static void CallProgram(String filename)
        {
            var psi = new ProcessStartInfo
            {
                //Jeśli mścieżka do pliku nie jest wpisana, to umieść wywoływany program w tym msamym katalogu co Call_Program.exe
                //                FileName = @"c:\work\test.exe",
                FileName = @filename,
                //               FileName = @"kalkulator.exe",
                Arguments = @"param1 param2",
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            var process = Process.Start(psi);
            if (process.WaitForExit((int)TimeSpan.FromSeconds(10).TotalMilliseconds))
            {
                var result = process.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        public static void GoToSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

    }
}