using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class RiffAttack : MonoBehaviour
{
    public abstract void OnAttackStart(GameObject target);
    public abstract void OnAttackRelease(GameObject target);
}
