using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public RawImage healthBah;

    public void SetValue(float val)
    {
        healthBah.rectTransform.sizeDelta = new Vector2(Screen.width * val, healthBah.rectTransform.sizeDelta.y);
    }
}
