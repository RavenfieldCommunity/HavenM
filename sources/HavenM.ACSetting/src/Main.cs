using System;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

namespace HavenM
{
    /// <summary>
    /// ::: HavenM
    /// ::: Licensed under MIT
    /// ::: Powerer by RavenfieldCommmunity
    /// </summary>
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Main : BaseUnityPlugin
    {
        public ConfigEntry<bool> thisisABool;
        private void Awake()
        {
            logger = Logger;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            //register config: tag, name, value, description
            thisisABool = Config.Bind<bool>("General", "thisisABool", true, "Enable plugin?");
            //register config update solver
            Config.SettingChanged += this.OnSettingChanged;

            UnionPatch.Patch();
        }

        //Event subscriber to solve plugin configs changes
        private void OnSettingChanged(object sender, SettingChangedEventArgs e)
        {
            
        }
    }
}