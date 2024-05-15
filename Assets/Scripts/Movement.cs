using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speedMultiplier = 2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speedMultiplier *  Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speedMultiplier * Time.deltaTime;
        transform.Translate(x,0,z);
    }
}
