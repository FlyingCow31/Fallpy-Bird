using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public LogicScript logic;
    //public to make it visible, the second is to store it. 
    //to establish a line of communation between the two.
    public Rigidbody2D MyRigidBody;
    // Start is called before the first frame update
    //Runs at the start of the game and runs once.
    public float flapStrength;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    // Runs every frame constently. 
    void Update()
    {
        // one = to make the thing the same, two to check if it's the same
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            MyRigidBody.velocity = Vector2.up * flapStrength;
            //to get the bird to fly up 
            //test
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdIsAlive = false;
    }

}
