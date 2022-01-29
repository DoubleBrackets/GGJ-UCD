using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnableVolumeOnStart : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Volume>().enabled = true;
    }
}
