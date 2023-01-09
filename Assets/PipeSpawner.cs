using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.4;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
        timer = 0;
           spawnPipe();
        }
    }

    void spawnPipe()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
