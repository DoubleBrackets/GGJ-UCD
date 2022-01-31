using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttackScript : MonoBehaviour
{
    public Transform Hand1;
    public Transform Hand2;

    private Vector3 startPos1;
    private Vector3 startPos2;

    private void Awake()
    {
        startPos1 = Hand1.position;
        startPos2 = Hand2.position;
    }
    public void PerformHandAttack(float radius, float angle, Vector3 positionOffset)
    {
        ImpulseManager.instance.Impulse(20f);
        float offset = Mathf.PI / 3;
        Vector3 pos1 = radius * new Vector3(Mathf.Cos(angle+offset), 0, Mathf.Sin(angle + offset));
        Vector3 pos2 = radius * new Vector3(Mathf.Cos(angle - offset), 0, Mathf.Sin(angle - offset));
        pos1.y = 1;
        pos2.y = 1;
        Hand1.transform.position = pos1 + positionOffset;
        Hand2.transform.position = pos2 + positionOffset;
        StartCoroutine(Corout_Recover());
    }

    private IEnumerator Corout_Recover()
    {
        yield return new WaitForSeconds(4f);
        Hand1.transform.position = startPos1;
        Hand2.transform.position = startPos2;
    }
}
