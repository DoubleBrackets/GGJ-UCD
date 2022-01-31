using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    public float Speed;
    public float StartRotation;
    public float Duration;
    private float timer = 0;

    public void OnEnable()
    {
        timer = Duration;
        transform.rotation = Quaternion.Euler(0, StartRotation, 0);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
            gameObject.SetActive(false);
        transform.Rotate(new Vector3(0,Speed * Time.deltaTime,0));
    }
}
