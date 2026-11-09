using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{

    public AudioClip coin1;
    public AudioClip coin2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.score += 1;
            AudioManager.instance.PlayRandomSFX(coin1, coin2);
            Debug.Log("Score: " + PlayerStats.score);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
