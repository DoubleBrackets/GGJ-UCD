using UnityEngine;
[System.Serializable]
public class Vector2Reference : GenericReference<Vector2>
{
    public Vector2Reference(Vector2 value) : base(value) { }

    public static implicit operator Vector2(Vector2Reference reference)
    {
        return reference.Value;
    }
}   