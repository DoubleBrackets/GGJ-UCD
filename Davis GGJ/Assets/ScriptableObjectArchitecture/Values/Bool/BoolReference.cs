using UnityEngine;
[System.Serializable]
public class BoolReference : GenericReference<bool>
{
    public BoolReference(bool value) : base(value) { }

    public static implicit operator bool(BoolReference reference)
    {
        return reference.Value;
    }
}   