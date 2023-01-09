using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 0.01f;
    public float deadZone = -0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed);

        if(transform.position.x < deadZone) {
            Debug.Log("Destroying");
            Destroy(gameObject);
        }
    }
}
