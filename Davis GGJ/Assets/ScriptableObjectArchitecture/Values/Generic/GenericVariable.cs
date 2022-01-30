using UnityEngine;

public abstract class GenericVariable<T> : ScriptableObject
{
    public T Value;
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif
}
