using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    GameObject startScreen;
    GameObject playingScreen;
    //GameObject finishedScreen;
    // Start is called before the first frame update
    void Start()
    {
        startScreen = GameObject.FindWithTag("Start");
        playingScreen = GameObject.FindWithTag("playingScreen");
        //finishedScreen = GameObject.FindWithTag("finish");
        startScreen.SetActive(true);
        playingScreen.SetActive(false);
        //finishedScreen.SetActive(false);

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
            startScreen.SetActive(true);
            playingScreen.SetActive(false);
            //finishedScreen.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
            startScreen.SetActive(false);
            playingScreen.SetActive(true);
            //finishedScreen.SetActive(false);
    }
}
