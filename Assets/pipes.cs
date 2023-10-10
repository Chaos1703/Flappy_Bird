using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = -30;

    void Update()
    {
        transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        
        if(transform.position.x < deadzone)
            Destroy(gameObject);
    }
}
