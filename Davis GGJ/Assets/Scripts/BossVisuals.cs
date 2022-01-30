using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVisuals : MonoBehaviour
{
    public Transform target;

    public MeshRenderer body;

    private Color defaultColor;
    private Color damagedColor = Color.red;

    private void Awake()
    {
        defaultColor = body.material.GetColor("_BaseColor");
    }

    private void Update()
    {
        //Rotate towards target
        gameObject.transform.LookAt(target);
    }

    public void TakeDamageVisual()
    {
        if(damagedRoutine != null)
            StopCoroutine(damagedRoutine);
        damagedRoutine = StartCoroutine(Corout_TakeDamageVisual());
    }
    Coroutine damagedRoutine = null;
    private IEnumerator Corout_TakeDamageVisual()
    {
        var block = new MaterialPropertyBlock();
        body.GetPropertyBlock(block);
        block.SetColor("_BaseColor", damagedColor);
        body.SetPropertyBlock(block);
        yield return new WaitForSeconds(0.1f);
        block.SetColor("_BaseColor", defaultColor);
        body.SetPropertyBlock(block);
    }
}
