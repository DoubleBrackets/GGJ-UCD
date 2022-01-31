using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillingThingLOL : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerEntity>();
        if(player != null)
        {
            player.TakeDamage(10000);
        }
    }
}
