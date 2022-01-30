
using UnityEngine;
using UnityEngine.Events;

public class GenericGameEventListener<T> : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GenericGameEvent<T> Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent<T> Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(T param)
    {
        Response.Invoke(param);
    }
}
