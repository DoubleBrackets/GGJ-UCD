using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public abstract class AbstractProjectile : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rb;
    public VisualEffect[] ProjectileVFX;
    public VisualEffect DeathVFX;
    [HideInInspector]
    public Vector3 MoveVector;
    [HideInInspector]
    public Vector3 Target;
    public int Damage;

    public virtual void OnCollision(Collision hit)
    {
        DisableProjectile();
        if(DeathVFX != null)
            DeathVFX.Play();
    }

    public void UpdateVelocity()
    {
        Rb.velocity = MoveVector.normalized * Speed * Random.Range(0.85f,1.15f);
        //rotate towards DO YOU KNOW DA WAE
        transform.rotation = Quaternion.LookRotation(Rb.velocity);
    }

    //THE COLORS OMGAWD
    public virtual void InitializeProjectile(Vector3 moveVector, float hue)
    {
        foreach (var vfx in ProjectileVFX)
        {
            vfx.SetVector3("PrimaryHue", new Vector3(hue,1,1));
            if(vfx.HasFloat("Frequency"))
                vfx.SetFloat("Frequency", hue);
        }
        if(DeathVFX != null)
            DeathVFX.SetVector3("PrimaryHue", new Vector3(hue, 1, 1));
    }

    private void Awake()
    {
        PlayVFX();
    }

    protected void DisableProjectile()
    {
        Rb.Sleep();
    }

    protected void PlayVFX()
    {
        foreach(var vfx in ProjectileVFX)
        {
            vfx?.Play();
        }
    }

    protected void StopVFX()
    {
        foreach (var vfx in ProjectileVFX)
        {
            vfx?.Stop();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        OnCollision(collision);
    }
}
