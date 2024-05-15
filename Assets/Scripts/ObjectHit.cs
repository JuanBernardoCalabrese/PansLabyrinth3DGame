using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{   bool isHit = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (isHit == false)
        {
            if (collision.gameObject.tag == "Player")
            {
                //Debug.Log("Objeto detectado");
                GetComponent<MeshRenderer>().material.color = Color.red;
                gameObject.tag = "Hit";
                isHit = true;
            }
            
        }
        else if (isHit == true)
        {
            //Debug.Log("Objeto detectado anteriormente");
        }
    }
}
