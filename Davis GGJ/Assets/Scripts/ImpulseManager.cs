using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class ImpulseManager : MonoBehaviour
{
    public static ImpulseManager instance;
    private void Awake()
    {
        instance = this;
    }
    [ContextMenu("Test")]
    public void Impulse(float mutiplier = 1.5f)
    {
        var source = GetComponent<CinemachineImpulseSource>();
        source.m_ImpulseDefinition.m_AmplitudeGain = mutiplier;
        source.GenerateImpulse();
    }
}
