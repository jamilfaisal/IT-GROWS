using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float size;
    [SerializeField] private Transform _playerTransform;
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "edible")
        {
            EdibleObject edibleObject = collision.gameObject.GetComponent<EdibleObject>();
            float growthSize = edibleObject.Size;

            if (size > 0.8) {
                size += 0.15f;
                scoreManager.UpdateScore(edibleObject.Score);
                
                gameObject.transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
                gameObject.transform.position += new Vector3(0, 0.15f / 2, 0);
                Destroy(collision.gameObject);
            }
            else if (growthSize < size)
            {
                size += growthSize;
                scoreManager.UpdateScore(edibleObject.Score);
                
                gameObject.transform.localScale += new Vector3(growthSize, growthSize, growthSize);
                gameObject.transform.position += new Vector3(0, growthSize / 2, 0);
                Destroy(collision.gameObject);
            }
        }
    }
}
