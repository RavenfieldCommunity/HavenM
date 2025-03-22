using System;
using BepInEx;
using System.IO;
using System.Net;
using SimpleJSON;
using UnityEngine;
using System.Reflection;
using BepInEx.Configuration;
using System.Threading;

namespace HavenM.ACUpdater
{
    /// <summary>
    /// ::: HavenM.ACUpdater is a BepinEX Plugin powered by RavenfieldCommunity, some code is from RavenM
    /// ::: Docs at `https://RavenfieldCommunity.github.io/docs`
    /// ::: Licensed under MIT
    /// </summary>
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Main : BaseUnityPlugin
    {
        private Stream MakeRequest(string url)
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.Accept = "application/vnd.github+json";
            req.UserAgent = "Def-Not-HavenM";
            req.Timeout = 5000;
            return req.GetResponse().GetResponseStream();
        }

        private static ConfigEntry<bool> useBaseUpdate;
        private static bool isCNRegion = false;


        private void Awake()
        {
            /*del it
            var yes = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\636480", "Name", null) as string 
                                    ?? Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\Valve\Steam\Apps\636480", "name", null) as string;
        if (yes == null)
        {
            var path1 = $"{Application.dataPath}\\error_t.txt";
            using (StreamWriter writer = new StreamWriter(path1)) {
                writer.Write("Unspported player");
			    writer.Close();
            }
            System.Diagnostics.Process.Start("notepad",$"'{path1}'");
            Application.Quit();
        }*/
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            var lastQuitForUpdate = Config.Bind("Data", "lastQuitForUpdate", false, "Game's last quit is for update?(If yes then ignore check update)");
            var lastACUpdateTime = Config.Bind("Data", "lastACUpdateTime", "", "Last udpate time");
            //var isFirstStartup = Config.Bind("Data", "isFirstStartup", "", "Is first time startup");

            useBaseUpdate = Config.Bind("General", "Force use base update", false, "");
            var forceDisableCNTrubo = Config.Bind("General", "Force disable CNTrubo", false, "Force disable network booster service for chinese players.");
            var disableAutoUpdate = Config.Bind("General", "Disable auto update", false, "Disable auto update.");

            if (!forceDisableCNTrubo.Value) isCNRegion = System.Threading.Thread.CurrentThread.CurrentCulture.Name == "zh-CN";

            
            if (lastQuitForUpdate.Value || disableAutoUpdate.Value) {
                Logger.LogWarning("Ignore check update!");
                lastQuitForUpdate.Value = false;
            }
            else {
                try {
                    Logger.LogInfo("Checking updates for Updater ...");
                    Stream response = null;
                    if ( !isCNRegion ) response = MakeRequest("https://api.github.com/repos/RavenfieldCommunity/HavenM/releases");
                    else response = MakeRequest("https://api.kkgithub.com/repos/RavenfieldCommunity/HavenM/releases");
                    var json = JSON.Parse(new StreamReader(response).ReadToEnd());
                    //var acTime = json["assets"][0]["updated_at"];
                    foreach (JSONNode node in json)
                    {
                        if (node["tag_name"] == "ACUpdaterRelease")
                        {
                            var fileInfo = new FileInfo( Paths.PluginPath );
                            var lastUpdaterTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Ticks;
                            //Logger.LogInfo(lastUpdaterTime);
                            var updaterTime = new DateTime( node["assets"][0]["updated_at"] ).Ticks;
                            ///Logger.LogInfo(updaterTime);
                            if (updaterTime > lastUpdaterTime)
                            {
                                Logger.LogInfo("Update Updater!");
                                var path1 = $"{Paths.GameRootPath}\\havenmacupdater_e.txt";
                                using (StreamWriter writer = new StreamWriter(path1)) {
                                    if ( !isCNRegion ) writer.Write("Update of ACUpdater si availdable.\nplz open HavenM's github site to re-install HavenM as update.");
                                    else writer.Write("发现 自动更新插件ACUpdater 有更新可用\n请手动访问我们的站点重新安装HavenM作为更新.");
				                    writer.Close();
                                }
                                System.Diagnostics.Process.Start("notepad",$"'{path1}'");
                            }
                            break;
                        }
                    }                    
                }
                catch (Exception e) { Logger.LogError(e.ToString());  Logger.LogWarning("Cannot check update or update for Updater!"); } 

                try {
                    Logger.LogInfo("Checking updates for HavenM ...");
                    Stream response = null;
                    if ( !isCNRegion ) response = MakeRequest("https://api.github.com/repos/RavenfieldCommunity/HavenM/releases/latest");
                    else response = MakeRequest("https://api.kkgithub.com/repos/RavenfieldCommunity/HavenM/releases/latest");
                    var json = JSON.Parse(new StreamReader(response).ReadToEnd());
                    if (json["assets"][0]["updated_at"] != lastACUpdateTime.Value)
                    {
                        Logger.LogInfo("Update HavenM!");
                        lastQuitForUpdate.Value = true;
                        lastACUpdateTime.Value = json["assets"][0]["updated_at"];
                        UpdateACDll();
                    }
                    else { Logger.LogInfo("No update for HavenM!"); }
                    
                }
                catch (Exception e) { Logger.LogError(e.ToString()); Logger.LogWarning("Cannot check update or update HavenM!"); }
            }

            GameObject.Destroy(this);
        }

         /*public void UpdateUpdater()
        {
            /*System.Diagnostics.Process.Start("powershell",$" -c \"Write-Host 'HavenM Base Updater\nDownloading and installing HavenM(if it takes too long, plz restart) ...';Wait-Process -Name 'ravenfield';Copy-Item '{path2}' '{Paths.GameRootPath}\\ravenfield_Data\\Managed\\Assembly-CSharp.dll';Write-Host 'Finished.';if ( $(tasklist | findstr 'steam') -ne $null ){{start 'steam://launch/636480/dialog';}}");
            var req = MakeRequest("https://github.com/RavenfieldCommunity/HavenM/releases/latest/download/Assembly-CSharp.dll");

            if ( req.Length > 3000 ) using (StreamWriter writer = new StreamWriter(path2)) { 
                        //var a = new byte[req.Length];
                        writer.Write(new StreamReader(req).ReadToEnd()); 
                        writer.Close(); 
                    }
        }*/

        public void UpdateACDll()
        {
            var success = false;
            if ( !useBaseUpdate.Value ) try {
                Logger.LogInfo("Way1 start");
                var p = System.Diagnostics.Process.Start("powershell"," -c \"$isUpdate=$true;$w=(New-Object+System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;\"");
                Thread.Sleep(150);
                if (p.HasExited != true){
                    success = true;
                    Logger.LogInfo("Quit game ...");
                    Application.Quit();
                }
            } catch (Exception e)
            { 
                useBaseUpdate.Value = true;
                Logger.LogError(e.ToString());
                Logger.LogError("Way1 failed");
            }

            if  (success != true)
            {
                Logger.LogInfo("Way2 start");
                var pathTemp = $"{Paths.GameRootPath}\\havenm_temp.zip";
                var path = $"{Paths.GameRootPath}\\havenm.zip";
                try { File.Delete(pathTemp); } catch {}
                File.Delete(path);
                try{
                    if ( !isCNRegion ) System.Diagnostics.Process.Start("powershell",$" -c \"Write-Host 'HavenM Base Updater';Write-Host 'DO NOT close the game or this window while processing!';Write-Host 'If the game cannot start normally, plz visit the github site of HavenM and re-install as update or fix.';Write-Host 'Downloading and installing HavenM, if it takes too long, plz quit and restart ...';Wait-Process -Name 'ravenfield';Copy-Item '{path}' '{Paths.GameRootPath}\\ravenfield_Data\\Managed\\Assembly-CSharp.dll';Write-Host 'Finished. You can close this window new.';if ( $(tasklist | findstr 'steam.exe') -ne $null ){{Write-Host 'Relaunching game ...';start 'steam://launch/636480/dialog';}};Read-Host;\"");
                    else System.Diagnostics.Process.Start("powershell",$" -c \"Write-Host 'HavenM 基本更新服务';Write-Host '运行时请不要关闭游戏或本窗口!';Write-Host '如果游戏无法正常启动，请手动访问我们的站点重新安装HavenM作为更新或修复';Write-Host '正在下载与安装HavenM, 如果很长时间没反应就直接关了并重开游戏 ...';Wait-Process -Name 'ravenfield';Copy-Item '{path}' '{Paths.GameRootPath}\\ravenfield_Data\\Managed\\Assembly-CSharp.dll';Write-Host '完成. 您现在可以关闭窗口了';if ( $(tasklist | findstr 'steam.exe') -ne $null ){{Write-Host '正在重开游戏 ...';start 'steam://launch/636480/dialog';}};Read-Host;\"");

                    Stream req = null;
                    if ( !isCNRegion ) req = MakeRequest("https://github.com/RavenfieldCommunity/HavenM/releases/latest/download/Assembly-CSharp.dll");
                    else req = MakeRequest("https://gh.llkk.cc/https://github.com/RavenfieldCommunity/HavenM/releases/latest/download/Assembly-CSharp.dll");

                    if ( req.Length > 3000000 ) using (FileStream fs = File.Create(pathTemp)) { 
                        req.CopyTo(fs);
                        fs.Close();
                    }

                    try { Assembly.LoadFile(pathTemp); }
                    finally {
                        File.Copy(pathTemp,path);
                        Logger.LogInfo("Quit game ...");
                        Application.Quit();
                    }

                } catch (Exception e)
                {
                    Logger.LogError(e.ToString());
                    Logger.LogError("Way2 failed");
                    var path1 = $"{Paths.GameRootPath}\\havenm_e.txt";
                    using (StreamWriter writer = new StreamWriter(path1)) {
                        if ( !isCNRegion ) writer.Write("Cannot update HavenM automatically.\nplz open HavenM's github site to re-install HavenM as update!");
                        else writer.Write("无法自动更新HavenM.\n请手动访问我们的站点重新安装HavenM作为更新!");
				        writer.Close();
                    }
                    System.Diagnostics.Process.Start("notepad",$"'{path1}'");
                }
            }
        }
    }
}
