using System;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public ScoreManager  scoreManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
            {
                scoreManager.AddScore();
            Destroy(other.gameObject);
            };
        

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
