﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    [SerializeField] float time = 30;
    [SerializeField] GameManager GameManager;
    bool levelOver = false;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0.1) {
            if(!levelOver)
            {
                levelOver = true;
                GameManager.win();
            }
        }
        int t = (int)time;
        string s = "" + t / 60 + ":";
        int a = t % 60;
        if (a < 10) s = s + "0" ;
        s = s + a;
        text.text = s;
    }
 
}
