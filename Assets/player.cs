using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed = 600f;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
       movement = Input.GetAxisRaw("Horizontal");   
    }
    private void FixedUpdate()
    {
      
    }
}
