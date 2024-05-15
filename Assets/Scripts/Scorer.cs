using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scorer : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit") 
        {
            score++;
            //points.text = score.ToString();
            Debug.Log(score);
        }

    }
}
