using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{

    public float delay = 3f;

    float countdown;

    public float radius = 5f;

    public float explosionForce = 70;

    bool exploded = false; 







    void Start()
    {
        countdown = delay;   
    }

    
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0 && exploded == false)
        {

            Explode();
            exploded = true; 



        } 
      



   
    }


    void Explode()
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (var rangeObjects in colliders)
        {

            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();

            if ( rb!= null)
            {
                rb.AddExplosionForce(explosionForce * 10, transform.position, radius); 
            }


        }


        Destroy(gameObject); 

    }



}




