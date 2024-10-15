using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ak47script : MonoBehaviour
{
    
    [SerializeField] private Animator gunanim;
     [SerializeField] private Transform gun;

    [Header("Bullet")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;





    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousepos - gun.position;

        gun.rotation = Quaternion.Euler(0,0,Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        // rotates the gun , uses the Mathf (used to calculate the angle), Atan2 (used to calculate the angle) and Rad2Deg (used to convert the radian to degrees)  
    
        if(Input.GetMouseButtonDown(0)) {
            Shoot(direction);
        }
    }

    public void Shoot(Vector3 direction) {
        gunanim.SetTrigger("Shoot");

        GameObject newBullet =Instantiate(bulletPrefab, gun.position, Quaternion.identity);
        // Creates a bullet (bullet Prefab) at the position of the gun, with the rotation of the gun.
        newBullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * bulletSpeed;
    
        Destroy(newBullet, 5);
    }
}
