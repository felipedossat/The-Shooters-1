using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform spawnPoint;


    public GameObject bullet;


    public float shotForce = 1500f;

    public float shotRate = 0.5f;

    private float shotRateTime = 0;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
             


                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;  

                Destroy(newBullet, 5);




            





        }

    }


}

