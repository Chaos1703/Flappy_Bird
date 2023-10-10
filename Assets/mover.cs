using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float flap;
    public GameObject Game_Over;

    public GameObject Pipe;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rigidbody.velocity = Vector2.up * flap;
        }
        if(transform.position.y < -8.4 || transform.position.y > 9.5){
            death();
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {   
        death();
    }
    void death(){
        Time.timeScale = 0f;
        Game_Over.SetActive(true);
    }
}
