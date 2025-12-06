using System;

namespace BepInEx
{
    [AttributeUsage(AttributeTargets.Class, Inherited=false)]
    public sealed class BepInPluginAttribute : Attribute
    {
        public BepInPluginAttribute(string id, string name, string version) {}
    }

    // Minimal logger used by plugin at compile-time
    public class ManualLogger
    {
        public void LogInfo(string s) {}
        public void LogWarning(string s) {}
        public void LogError(string s) {}
        public void LogDebug(string s) {}
    }

    // BaseUnityPlugin stub — inherit from UnityEngine.MonoBehaviour so StartCoroutine is available.
    public class BaseUnityPlugin : UnityEngine.MonoBehaviour
    {
        protected ManualLogger Logger { get; } = new ManualLogger();

        // Unity lifecycle methods are empty here; Unity will call the real methods at runtime.
        public virtual void Awake() { }
        public virtual void OnDestroy() { }
    }
}
