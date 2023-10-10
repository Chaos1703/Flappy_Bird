using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Trigger : MonoBehaviour
{
    public Player_Score logic;
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Player_Score>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        logic.AddScore(1);
    }
}
