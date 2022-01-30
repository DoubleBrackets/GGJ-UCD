using UnityEngine;
[System.Serializable]
public class ActionReference : GenericReference<System.Action>
{
    public ActionReference(System.Action value) : base(value) { }

    public static implicit operator System.Action(ActionReference reference)
    {
        return reference.Value;
    }
}   