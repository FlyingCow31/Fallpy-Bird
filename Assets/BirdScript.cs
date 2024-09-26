using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //public to make it visible, the second is to store it. 
    //to establish a line of communation between the two.
    public Rigidbody2D MyRigidBody;
    // Start is called before the first frame update
    //Runs at the start of the game and runs once.
    public float flapStrength;
    void Start()
    {

    }

    // Update is called once per frame
    // Runs every frame constently. 
    void Update()
    {
        // one = to make the thing the same, two to check if it's the same
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigidBody.velocity = Vector2.up * flapStrength;
            //to get the bird to fly up 
            //test
        }
    }
}
