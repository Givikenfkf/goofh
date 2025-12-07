using System;

namespace BepInEx
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BepInPluginAttribute : Attribute
    {
        public string GUID;
        public string Name;
        public string Version;
        public BepInPluginAttribute(string guid, string name, string version)
        {
            GUID = guid; Name = name; Version = version;
        }
    }

    public class BaseUnityPlugin : UnityEngine.MonoBehaviour
    {
        public virtual void Awake() { }
        public virtual void OnDestroy() { }
    }

    public class ManualLogger
    {
        public void LogInfo(string msg) { /* stub */ }
        public void LogWarning(string msg) { /* stub */ }
        public void LogError(string msg) { /* stub */ }
    }
}
