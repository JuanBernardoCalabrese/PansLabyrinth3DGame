using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishScript : MonoBehaviour
{
    GameObject startScreen;
    GameObject playingScreen;
    GameObject finishedScreen;
    // Start is called before the first frame update
    void Start()
    {
        startScreen = GameObject.FindWithTag("Start");
        playingScreen = GameObject.FindWithTag("playingScreen");
        finishedScreen = GameObject.FindWithTag("finish");
        finishedScreen.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 7)
        {
            finishedScreen.SetActive(true);
            startScreen.SetActive(false);
            playingScreen.SetActive(true);
        }

    }
    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
