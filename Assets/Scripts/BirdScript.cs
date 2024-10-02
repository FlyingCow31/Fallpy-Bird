using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public LogicScript logic;
    //public to make it visible, the second is to store it. 
    //to establish a line of communation between the two.
    public Rigidbody2D MyRigidBody;
    // Start is called before the first frame update
    //Runs at the start of the game and runs once.
    public AudioSource bonk;
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
            MyRigidBody.velocity = UnityEngine.Vector2.up * flapStrength;
            //to get the bird to fly up 
            //test
        }
        if (Input.GetKeyDown(KeyCode.W) == true && birdIsAlive == true) {
            MyRigidBody.velocity = UnityEngine.Vector2.up * flapStrength;
        }
        if (Input.GetKeyDown(KeyCode.D) == true && birdIsAlive == true) {
            MyRigidBody.velocity = UnityEngine.Vector2.right * flapStrength;
        }
        if (Input.GetKeyDown(KeyCode.A) == true && birdIsAlive == true) {
            MyRigidBody.velocity = UnityEngine.Vector2.left * flapStrength;
        }
        if (Input.GetKeyDown(KeyCode.S) == true && birdIsAlive == true) {
            MyRigidBody.velocity = UnityEngine.Vector2.down * flapStrength;
        }

        if (Input.GetKeyDown(KeyCode.R) == true && birdIsAlive == true) {
            logic.gameover();
            birdIsAlive = false;
        }


        if (transform.position.y > 16 || transform.position.y < -16) {
            logic.gameover();
            birdIsAlive = false;
            Debug.Log("birdIsAlive");
        }
        if (transform.position.x > 27 || transform.position.x < -27) {
            logic.gameover();
            birdIsAlive = false;
            Debug.Log("birdIsAlive");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdIsAlive = false;
    }

}
