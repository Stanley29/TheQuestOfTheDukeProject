﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.


    public Text text;                      // Reference to the Text component.
    public GameObject wintext;
    public GameObject portal;


    void Awake()
    {
        // Reset the score.
        score = 0;

        if (portal == null)
        {

        }
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
        if (score >= 16)
        {
            wintext.SetActive(true);

            if (portal != null)
            {
                portal.SetActive(true);
            }
        }
    }
}
