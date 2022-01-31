using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public RawImage healthBah;

    private float value = 1;

    private void Update()
    {
        SetValue(value);
    }
    public void SetValue(float val)
    {
        value = val;
        healthBah.rectTransform.sizeDelta = new Vector2(Screen.width * val, healthBah.rectTransform.sizeDelta.y);
    }
}
