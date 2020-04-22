﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float speed;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((new Vector3(-1,0,0))*speed*Time.deltaTime);
        if(transform.position.x < -13.665)
            transform.position = startPos;
        

    }
}
