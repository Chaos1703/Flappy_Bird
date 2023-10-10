using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pipe_spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float timer = 0;
    public float height = 10;

    private void Start()
    {
        spawn();
    }
    private void Update()
    {
        if(spawnrate > timer){
            timer = timer + Time.deltaTime;
        }

        else{
            spawn();
            timer = 0;
        }
    }
    void spawn(){
        float lowest_point = transform.position.y - height;
        float highest_point = transform.position.y + height;

        Instantiate(pipe , new Vector3(transform.position.x , Random.Range(lowest_point , highest_point) , 0) , transform.rotation);
    }
}
