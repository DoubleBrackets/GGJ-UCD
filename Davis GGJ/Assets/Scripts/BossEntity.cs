using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEntity : Entity
{

    protected override void OnDeath()
    {
        Destroy(gameObject);
    }
}
