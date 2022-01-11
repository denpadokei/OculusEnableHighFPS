using HarmonyLib;

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
