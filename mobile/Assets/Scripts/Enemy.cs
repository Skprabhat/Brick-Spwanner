using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("line"))
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
      
    }
}
