using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject GameOverMenu;
    public Enemy ene;
    public float timer = 10;
    int timer1;
    public bool isSlowMotion=false,Ispaused=false;
    public Text TimerText;
    public SwipeMovement sm;
    // Start is called before the first frame update
    public void Slowmotion()
    {
        isSlowMotion = true;
       
    }
    public void setnormal()
    {
        //Time.timeScale = 1;
        isSlowMotion = false;
    }
    public void pause()
    {
        Ispaused = true;
        
        PauseMenu.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
    public void home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void Update()
    {
        timer1 =(int) timer;
        TimerText.text = timer1.ToString();
        if (isSlowMotion == true && sm.IsGameOver == false)
        {
            if (timer > 0)
            {
                Time.timeScale = 0.3f;
                timer -= Time.deltaTime;
            }
            else
            {
               Time.timeScale= 1;
            }
        }
        if (isSlowMotion==false&&Ispaused==false&&sm.IsGameOver==false)
        {
            Time.timeScale = 1;
        }
        if(Ispaused==true)
        {
            Time.timeScale = 0;
        }
    }
    
}
