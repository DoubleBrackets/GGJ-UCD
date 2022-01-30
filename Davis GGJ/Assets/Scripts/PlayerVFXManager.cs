using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class PlayerVFXManager : MonoBehaviour
{
    //Fields
    public GameObject DraftActiveVisuals;
    public GameObject WalkActiveVisuals;
    public MeshRenderer DriftGuitarMesh;
    public Color[] GuitarColors;

    public VisualEffect DriftVFX;

    public void StartDriftVFX()
    {
        SetGuitarObjectDrift(true);
        DriftVFX.Play();
    }

    public void StopDriftVFX()
    {
        SetGuitarObjectDrift(false);
        DriftVFX.Stop();
    }

    private void SetGuitarObjectDrift(bool val)
    {
        DraftActiveVisuals.SetActive(val);
        WalkActiveVisuals.SetActive(!val);
    }

    public void UpdateGuitarColor(int octave)
    {
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        DriftGuitarMesh.GetPropertyBlock(block);
        block.SetColor("_EmissionColor", GuitarColors[octave + 1]);
        DriftGuitarMesh.SetPropertyBlock(block);
    }
}
