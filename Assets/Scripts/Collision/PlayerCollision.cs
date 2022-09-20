using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float size;
    [SerializeField] private Transform _playerTransform;
    // private ScoreManager scoreManager;

    void Start()
    {
        size = _playerTransform.localScale[0];
        // scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "edible")
        {
            EdibleObject edibleObject = collision.gameObject.GetComponent<EdibleObject>();
            float growthSize = edibleObject.Size;

            if (growthSize < size)
            {
                size += growthSize;
                // scoreManager.UpdateScore(edibleObject.Score);
                
                gameObject.transform.localScale = new Vector3(size, size, size);
                gameObject.transform.position += new Vector3(0, growthSize / 2, 0);
                Destroy(collision.gameObject);
            }
        }
    }
}
