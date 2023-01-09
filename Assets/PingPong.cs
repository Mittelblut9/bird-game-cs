using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.name = "PingPong";
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }
}
