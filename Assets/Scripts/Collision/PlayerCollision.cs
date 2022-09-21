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

            if (size > 0.5) {
                size += 0.08f;
                scoreManager.UpdateScore(edibleObject.Score);
                
                gameObject.transform.localScale += new Vector3(0.08f, 0.08f, 0.08f);
                gameObject.transform.position += new Vector3(0, 0.08f / 2, 0);
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
