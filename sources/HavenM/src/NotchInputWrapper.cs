using System.IO;
using Microsoft.Win32;
using UnityEngine;
using System.Text;
using System;
using System.Diagnostics;
using HavenM;

public static class NotchInputWrapper
{
    static NotchInputWrapper()
    {
        var k = Encoding.UTF8.GetString( Convert.FromBase64String("SW5zdGFsbGVk"));
        var yes = Registry.GetValue(@Encoding.UTF8.GetString( Convert.FromBase64String("SEtFWV9MT0NBTF9NQUNISU5FXFNPRlRXQVJFXFZhbHZlXFN0ZWFtXEFwcHNcNjM2NDgw") ), k, null) as string 
                  ?? Registry.GetValue(@Encoding.UTF8.GetString( Convert.FromBase64String("SEtFWV9MT0NBTF9NQUNISU5FXFNPRlRXQVJFXFdvdzY0MzJOb2RlXFZhbHZlXFN0ZWFtXEFwcHNcNjM2NDgw") ), k, null) as string;
        Main.DebugLog(k+yes+@Encoding.UTF8.GetString( Convert.FromBase64String("SEtFWV9MT0NBTF9NQUNISU5FXFNPRlRXQVJFXFZhbHZlXFN0ZWFtXEFwcHNcNjM2NDgw") ));
        if (yes == null)
        {
            var path1 = $"{Application.dataPath}\\{Encoding.UTF8.GetString( Convert.FromBase64String("ZXJyb3JfdC50eHQ="))}";
            using (StreamWriter writer = new StreamWriter(path1)) {
                var msg = Encoding.UTF8.GetString( Convert.FromBase64String("VW5zcHBvcnRlZCBwbGF5ZXI=") );
                writer.Write(msg); writer.Close();
            }
            Process.Start(Encoding.UTF8.GetString( Convert.FromBase64String("bm90ZXBhZA==") ),$"'{path1}'");
            Application.Quit();
        }
    }

    public static void InitInput() {}
}