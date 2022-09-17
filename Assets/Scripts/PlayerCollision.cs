using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float mass;
    Rigidbody rb;

    void Start()
    {

    rb = GetComponent<Rigidbody>();
    mass = rb.mass;
        
    }

 void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "edible"){
            var edibleObject = collision.gameObject.GetComponent<EdibleObject>();
            float growthSize = edibleObject.Size;

            if (growthSize < mass)
            {
                Destroy(collision.gameObject);

                mass += growthSize;

                gameObject.transform.localScale += new Vector3(growthSize, growthSize, growthSize);
                gameObject.transform.position += new Vector3(0, growthSize / 2, 0);

            }
        }
    }
}
