using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{

    public GameObject ennemieBird;

    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        } else{
            spawnBird();
            timer = 0;
        }
    }
    void spawnBird() {
        float lowestpoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(ennemieBird, new Vector3(transform.position.x, Random.Range(lowestpoint, highestPoint), 0), transform.rotation);
        //Make spawn the bird on a vector (the 3 numbers) with the basic x position, and a random y position between the two heightOffset, and 0 for z.
    }
}
