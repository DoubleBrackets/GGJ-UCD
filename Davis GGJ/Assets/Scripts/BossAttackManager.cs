using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackManager : MonoBehaviour
{
    public SpinScript SpinAttackScript;
    public HandAttackScript HandScript;

    public Transform target;

    private float attackDelay = 15f;
    private float attackDelayTimer;

    private List<System.Action> actionList = new List<System.Action>();
    private int attackIndexer = 0;

    private void Awake()
    {
        actionList.Add(HandAttack);
        actionList.Add(SpinnyAttack);
        attackDelayTimer = attackDelay;
    }

    public void Update()
    {
        attackDelayTimer -= Time.deltaTime;
        if(attackDelayTimer <= 0)
        {
            attackDelayTimer = attackDelay;
            actionList[attackIndexer].Invoke();
            attackIndexer = (attackIndexer + 1) % (actionList.Count);
        }
    }

    public void SpinnyAttack()
    {
        SpinAttackScript.StartRotation = transform.rotation.eulerAngles.y + 180;
        SpinAttackScript.gameObject.SetActive(true);
    }

    public void HandAttack()
    {
        Vector3 posFlat = transform.position;
        posFlat.y = 0;
        Vector3 targetPosFlat = target.position;
        targetPosFlat.y = 0;
        float angle = Mathf.Atan2(targetPosFlat.z - posFlat.z, targetPosFlat.x - posFlat.x);
        Vector3 offset = new Vector3(transform.position.x, 0, transform.position.z);
        HandScript.PerformHandAttack((posFlat - targetPosFlat).magnitude, angle, offset);
    }
}
