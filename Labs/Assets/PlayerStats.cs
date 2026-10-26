using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int health;
    public int lives;   
   private float flickerTime = 0f;
   public float flickerDuration = 0.1f;

private SpriteRenderer sr;
public bool isImmune = false;
private float immunityTime = 0f;
 public float immunityDuration = 2f;

 void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
void SpriteFlicker()
    {
        if (flickerTime < flickerDuration)
        {
            flickerTime += Time.deltaTime;
        }
        else if (flickerTime >= flickerDuration)
        {
            sr.enabled = !(sr.enabled);
            flickerTime = 0;
        }
    }
    void Update()
    {
        if (isImmune)
        {
            SpriteFlicker();
            immunityTime += Time.deltaTime;
            if (immunityTime >= immunityDuration)
            {
                isImmune = false;
                sr.enabled = true;
            }
    }
    }

    public void TakeDamage(int damage)
    {
        if (!isImmune)
        {
            health -= damage;
            if (health <0)
            {
           health = 0;
            }
            if(lives > 0 && health == 0)
            {
                FindObjectOfType<LevelManager>().RespawnPlayer();
                health = 3;
                lives--;
            }
            else if (lives == 0 && health == 0)
            {
                Debug.Log("Game Over");
                Destroy(this.gameObject);
            }
            Debug.Log("Player Health: " + health.ToString() + " Lives: " + lives.ToString());
        }
        isImmune = true;
        immunityTime = 0f;
    }
}