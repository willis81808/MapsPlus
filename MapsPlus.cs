using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using BepInEx;
using UnityEngine;

namespace MapsPlusPlugin
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, "0.0.2")]
    [BepInProcess("Rounds.exe")]
    public class MapsPlus : BaseUnityPlugin
    {
        private const string ModId = "com.willis.rounds.mapsplus";
        private const string ModName = "Maps Plus";

        void Awake()
        {
            Unbound.RegisterGUI(ModName, DrawGUI);
        }
        void Start()
        {
            Unbound.BuildLevel(Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("customlevel", typeof(MapsPlus).Assembly));
        }

        private void DrawGUI()
        {
            GUILayout.Label("WARNING: ABSOLUTELY NOT COMPATIBLE WITH ONLINE PLAY UNLESS ALL PLAYS HAVE THIS MOD!");
            GUILayout.Label("To load a specific level in Sandbox mode type /<MapName> into chat\n" +
                                "Example: /WillisCircles");
            GUILayout.Label("Currently Available Maps:\n" +
                                "- WillisCircles");
        }
    }
}
