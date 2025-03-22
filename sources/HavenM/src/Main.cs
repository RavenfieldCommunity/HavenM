using System;
using BepInEx;
using BepInEx.Logging;
using System.IO;
using System.Net;
using SimpleJSON;
using UnityEngine;
using System.Reflection;
using System.Threading;

namespace HavenM
{
    /// <summary>
    /// ::: HavenM is a BepInEX Plugin powered by RavenfieldCommunity, some code is from RavenM
    /// ::: Docs at `https://RavenfieldCommunity.github.io/docs`
    /// ::: Licensed under MIT
    /// </summary>
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Main : BaseUnityPlugin
    {
        private static ManualLogSource beplo = null;

        private void Awake()
        {
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            beplo = Logger;
            //var useBaseUpdate = Config.Bind("General", "Force use base update", false, "");
            try { UnionPatch.Patch(); } catch (Exception e) { Main.ErrorLog(e.ToString()); }
            try {this.gameObject.AddComponent<A>();} catch (Exception e) { Main.ErrorLog(e.ToString()); }
        }

        public static void DebugLog(string text)
        {
            Main.beplo.LogInfo(text);
        }

        public static void ErrorLog(string text)
        {
            Main.beplo.LogError(text);
        }
    }

    public class A:MonoBehaviour{}

    public class B:A{}
}
