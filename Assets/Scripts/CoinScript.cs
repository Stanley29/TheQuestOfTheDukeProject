using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    GameObject player;
    public int scoreCoinValue = 2;
     AudioSource sound;

    // Use this for initialization
    void Start () {
		
	}

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // Increase the score by the enemy's score value.
            ScoreManager.score += scoreCoinValue;

            Debug.Log("Sound");

            Destroy(gameObject, 0f);
            
        }
    }
}
