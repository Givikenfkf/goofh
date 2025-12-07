using System;

namespace UnityEngine
{
    public class Object
    {
        public string name;

        public static void Destroy(Object obj) { /* stub */ }
        public static T Instantiate<T>(T obj) where T : Object => obj;
    }

    public struct Vector3
    {
        public float x, y, z;
        public Vector3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public static Vector3 zero => new Vector3(0,0,0);
    }

    public struct Quaternion
    {
        public float x, y, z, w;
        public static Quaternion identity => new Quaternion();
    }

    public struct Color
    {
        public float r, g, b, a;
        public static Color white => new Color { r=1, g=1, b=1, a=1 };
    }

    public class MonoBehaviour
    {
        public void Invoke(string methodName, float time) { /* stub */ }
        public void StartCoroutine(System.Collections.IEnumerator routine) { /* stub */ }
    }

    public class Transform
    {
        public Vector3 position;
        public Quaternion rotation;
    }

    public class GameObject
    {
        public string name;
        public Transform transform = new Transform();
        public GameObject(string name = "") { this.name = name; }
    }

    public class Camera { }
    public class Texture2D { }

    public struct Rect
    {
        public float x, y, width, height;
    }

    public class WaitForSeconds
    {
        public WaitForSeconds(float seconds) { }
    }

    public static class Debug
    {
        public static void Log(object message) { /* stub */ }
        public static void LogWarning(object message) { /* stub */ }
        public static void LogError(object message) { /* stub */ }
    }

    public static class GUI
    {
        public static void Label(Rect rect, string text) { /* stub */ }
    }
}
