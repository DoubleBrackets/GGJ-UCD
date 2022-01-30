using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiffInputHandler : MonoBehaviour
{
    public RiffAttackManager AttackManager;
    public BoolReference[] LHBindings;
    public IntGameEvent OnOctaveChange;

    public bool RiffActive = false;

    private int octave = 0;

    public void Strum()
    {
        for(int i = 0;i < LHBindings.Length;i++)
        {
            if(LHBindings[i])
            {
                PlayLHRiff(i);
            }
        }
    }

    public void AdjustOctave(int val)
    {
        octave = Mathf.Clamp(octave + val, -1, 1);
        OnOctaveChange.Invoke(octave);
    }

    public void ResetOctave()
    {
        SetOctave(0);
    }

    public void SetOctave(int val)
    {
        octave = val;
        OnOctaveChange.Invoke(octave);
    }

    private void PlayLHRiff(int index)
    {
        if (!RiffActive)
            return;
        AudioManager.instance.PlayLHClipOneShot(index, octave);
        AttackManager.Attack(index + 5 + 5 * octave,0);
    }

}
