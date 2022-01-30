using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class ExtensionMethods 
{
    /// <summary>
    /// x to x, y to z
    /// </summary>
    /// <returns></returns>
    public static Vector3 ToVector3Y(this Vector2 value)
    {
        return new Vector3(value.x, 0, value.y);
    }

    public static float AngleLerp(this float a, float b, float t)
    {
        float delta = Mathf.DeltaAngle(a, b);
        return Mathf.Lerp(a, a + delta, t);
    }
}
