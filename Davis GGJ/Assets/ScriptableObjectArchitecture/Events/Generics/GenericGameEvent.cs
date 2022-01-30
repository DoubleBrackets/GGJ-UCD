using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericGameEvent<T> : ScriptableObject
{
    /// <summary>
    /// The list of listeners that this event will notify if it is raised.
    /// </summary>
    private readonly List<GenericGameEventListener<T>> eventListeners =
        new List<GenericGameEventListener<T>>();

#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public void Invoke(T param)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
            eventListeners[i].OnEventRaised(param);
    }

    public void RegisterListener(GenericGameEventListener<T> listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GenericGameEventListener<T> listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}