using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class line : MonoBehaviour
{
    public Text scoreText;
    private int score=0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}
