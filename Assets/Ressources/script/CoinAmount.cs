﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{

    // Use this for initialization
    
    public void Score()
    {
        PlayerPrefs.SetInt("CoinsAmount", int.Parse(GameObject.FindGameObjectWithTag("CoinAmount").GetComponent<Text>().text));
        GameObject.FindGameObjectWithTag("scoreFinal").GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }
}
