using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine
{
    // Base "Object" so many Unity types can inherit from it (and be passed to Destroy).
    public class Object { }

    // Minimal Vector3
    public struct Vector3
    {
        public float x,y,z;
        public Vector3(float X, float Y, float Z) { x=X; y=Y; z=Z; }
        public static Vector3 zero => new Vector3(0,0,0);
    }

    // Minimal Quaternion
    public struct Quaternion
    {
        public float x,y,z,w;
        public Quaternion(float X,float Y,float Z,float W) { x=X; y=Y; z=Z; w=W; }
        public static Quaternion identity => new Quaternion(0,0,0,1);
    }

    public struct Color
    {
        public float r,g,b,a;
        public Color(float r,float g,float b,float a=1f){ this.r=r; this.g=g; this.b=b; this.a=a; }
    }

    // Texture2D inherits Object so it can be passed to Object.Destroy
    public class Texture2D : Object
    {
        public Texture2D(int w,int h) {}
        public void SetPixel(int x,int y, Color c) {}
        public void Apply() {}
    }

    public class ObjectHelpers
    {
        public static void Destroy(Object o) {}
    }

    // Keep the same static Destroy signature used in UnityEngine.Object
    public static class ObjectEx
    {
        public static void Destroy(Object o) {}
    }

    // Minimal Transform
    public class Transform
    {
        public Vector3 position;
        public Quaternion rotation;
    }

    // GameObject and Camera inherit from Object so they match Destroy param expectations
    public class GameObject : Object
    {
        public Transform transform = new Transform();
        public static GameObject Find(string name) => null;
    }

    public class Camera : Object
    {
        public Transform transform = new Transform();
        public static Camera main => null;
    }

    public static class Input
    {
        public static bool GetButton(string name) => false;
    }

    // WaitForSeconds used as IEnumerator yield instruction
    public class WaitForSeconds : IEnumerator
    {
        public WaitForSeconds(float seconds) {}
        public object Current => null;
        public bool MoveNext() => false;
        public void Reset() {}
    }

    public static class GUI
    {
        public static void DrawTexture(Rect r, Texture2D tex) {}
    }

    public struct Rect
    {
        public float x,y,width,height;
        public Rect(float x,float y,float w,float h){ this.x=x; this.y=y; this.width=w; this.height=h; }
    }

    // Make MonoBehaviour a real class that exposes StartCoroutine and Destroy abilities.
    public class MonoBehaviour : Object
    {
        public IEnumerator StartCoroutine(IEnumerator routine) { return routine; }
        public void StopCoroutine(IEnumerator routine) { }
    }

    public class QuaternionWrapper { } // placeholder if referenced

    // minimal Mathf
    public static class Mathf
    {
        public static float Clamp01(float v) { return v < 0 ? 0 : (v > 1 ? 1 : v); }
    }
}
