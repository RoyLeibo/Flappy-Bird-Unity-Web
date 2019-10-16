﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGamePlayScript : MonoBehaviour
{
    public static AudioGamePlayScript gamePlayAudioScript = null;
    public static AudioGamePlayScript GamePlayAudioScript
    {
        get { return gamePlayAudioScript; }
    }

    void Awake()
    {
        Debug.Log("Before first condition");
        if (gamePlayAudioScript != null && gamePlayAudioScript != this)
        {
            Debug.Log("inside first if");
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Debug.Log("inside else");
            gamePlayAudioScript = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
