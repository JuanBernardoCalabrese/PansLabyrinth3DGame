using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreCounter : MonoBehaviour
{
    int score = -2;
    public Text playingScreen;
    public Text finishedScreen;
    // Start is called before the first frame update
    void Start()
    {
        playingScreen = GameObject.FindGameObjectWithTag("points").GetComponent<Text>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            playingScreen.text = score.ToString();
            //Debug.Log(score);
        }

    }
}
