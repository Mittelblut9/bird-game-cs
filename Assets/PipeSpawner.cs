using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.4f;
    public float highOffset = 4f;
    public float timer = 0;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnPipe();
    }

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
        float lowestPoint = transform.position.y - highOffset;
        float highestPoint = transform.position.y + highOffset;
        
        if(!logic.getDead()) {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
        }
    }
}
