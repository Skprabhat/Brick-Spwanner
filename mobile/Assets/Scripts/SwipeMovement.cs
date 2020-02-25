using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMovement : MonoBehaviour
{
    public float speed;
    private Vector3 touchpos;
    private Rigidbody2D rb;
    public GameObject GameOverMenu;
    //Vector2 startPos, endPos;
    public bool IsGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        Time.timeScale = 1;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //GameTime= Time.timeScale += (float)0.05 * Time.unscaledDeltaTime;
       
        //Time.timeScale = Mathf.Clamp(Time.timeScale, 0, 2.5f);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchpos = Camera.main.ScreenToWorldPoint(touch.position);
            touchpos.z = 0;

            if (touchpos.y > -3.5f)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        //startPos = touch.position;
                        break;
                    case TouchPhase.Moved:
                        transform.position = Vector3.Lerp(transform.position, touchpos, speed * Time.deltaTime);
                        break;
                    //case TouchPhase.Ended:
                        //if(touch.position.x > startPos.x)//Right Swipe
                        //{
                            
                        //}
                        //else if(touch.position.x < startPos.x)//Left Swipe
                        //{
                            
                        //}
                        //break;


                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            IsGameOver = true;
            Time.timeScale = 0;
            GameOverMenu.SetActive(true);
        }
    }
}
