using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreak : MonoBehaviour
{

    private SpriteRenderer sr;

    public Sprite explodedBlock;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && other.GetContact(0).point.y < transform.position.y)
        {
            sr.sprite = explodedBlock;
            Destroy(gameObject, 0.2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
