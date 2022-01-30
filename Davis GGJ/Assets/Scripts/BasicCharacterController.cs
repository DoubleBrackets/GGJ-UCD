using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BasicCharacterController : MonoBehaviour
{
    public CapsuleCollider col;
    //Components
    private Rigidbody rb;
    public LayerMask GroundedLayers;

    public Vector2 horizontalVelocity
    {
        get { return new Vector2(rb.velocity.x, rb.velocity.z); }
    }
    //RB Values
    private float linearFriction;

    private void Awake()
    {
        StoreRBValues();
    }

    private void StoreRBValues()
    {
        rb = GetComponent<Rigidbody>();
        linearFriction = rb.drag;
    }

    public void SetVelocity(Vector2 vel)
    {
        rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.y);
    }

    public void SetVelocity(Vector3 vel)
    {
        rb.velocity = vel;
    }

    public void SetVelocityHorizontal(Vector3 vel)
    {
        rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.z);
    }

    public void SetFrictionMultiplier(float val)
    {
        rb.drag = val * linearFriction;
    }
    
    public void Jump(float jumpVel)
    {
        //Grounded check
        var p1 = transform.TransformPoint(col.center) + (col.height/2 - col.radius) * Vector3.up;
        var p2 = transform.TransformPoint(col.center) - (col.height / 2 - col.radius) * Vector3.up;
        if(Physics.CapsuleCast(
            p1, p2, col.radius-0.1f,
            Vector3.down,0.25f,
            GroundedLayers
            ))
        {
            rb.velocity = new Vector3(rb.velocity.x,jumpVel, rb.velocity.z);
        }
    }
}
