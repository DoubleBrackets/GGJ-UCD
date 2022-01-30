using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : Entity
{
    protected override void OnDeath()
    {
        SceneController.instance.ResetScene(1.5f);
        gameObject.SetActive(false);      
    }
}
