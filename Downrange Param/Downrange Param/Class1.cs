using System;
using System.Reflection;
using UnityEngine;

[KSPAddon(KSPAddon.Startup.Instantly, true)]
public class DebugLoader : MonoBehaviour
{
    void Start()
    {
        try
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            asm.GetTypes();
        }
        catch (ReflectionTypeLoadException ex)
        {
            Debug.LogError("[Downrange] LoaderExceptions:");
            foreach (var e in ex.LoaderExceptions)
            {
                Debug.LogError("[Downrange] " + e.Message);
            }
        }
    }
}
