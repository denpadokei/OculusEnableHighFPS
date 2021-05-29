using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OculusEnableHighFPS.Patches
{
    [HarmonyPatch(typeof(VRRenderingParamsSetup), "OnEnable")]
    public class VRRenderingParamsSetupOnEnablePatch
    {
        public static void Postfix()
        {
            OVRPlugin.systemDisplayFrequency = 120f;
        }
    }
}
