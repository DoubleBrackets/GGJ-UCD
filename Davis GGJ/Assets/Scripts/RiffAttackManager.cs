using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiffAttackManager : MonoBehaviour
{
    public GameObject[] AttackPrefabs;
    public Transform attackSource;
    public Transform attackDirection;

    private HashSet<int> RepeatTracker = new HashSet<int>();
    public void Attack(int noteIndex,int projectileType)
    {
        ImpulseManager.instance.Impulse();
        GameObject attack = Instantiate(AttackPrefabs[projectileType], attackSource.position, Quaternion.identity);
        var projectile = attack.GetComponent<AbstractProjectile>();
        projectile.Speed *= 0.6f + 0.8f * noteIndex / 15f;
        //Damage calculations(encourage more notes being played)
        if(RepeatTracker.Contains(noteIndex))
        {
            projectile.Damage = 1;
        }
        else
        {
            projectile.Damage = 8;
            RepeatTracker.Add(noteIndex);
            if(RepeatTracker.Count >= 4)
            {
                RepeatTracker.Clear();
            }
        }


        projectile.InitializeProjectile(attackDirection.forward+new Vector3(Random.Range(-0.1f,0.1f), 
            Random.Range(-0.1f, 0.1f), 
            Random.Range(-0.1f, 0.1f)), 
            noteIndex/15f);
    }

}
