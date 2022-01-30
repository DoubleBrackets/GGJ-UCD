using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileA : AbstractProjectile
{
    public override void InitializeProjectile(Vector3 moveVector, float index)
    {
        base.InitializeProjectile(moveVector, index);
        MoveVector = moveVector;
        UpdateVelocity();
        Destroy(gameObject, 30f);
    }

    public override void OnCollision(Collision hit)
    {
        base.OnCollision(hit);
        var entity = hit.gameObject.GetComponent<Entity>();
        if(entity != null)
        {
            entity.TakeDamage(Damage);
        }
        StopVFX();
        Destroy(gameObject,0.75f);
    }


}
