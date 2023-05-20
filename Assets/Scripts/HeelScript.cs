using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelScript : MonoBehaviour
{
    GameObject player;
    public int heelValue = 10;
    PlayerHealth playerHealth;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponentInChildren<PlayerHealth>();
        //Debug.Log("Awake");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // sound.Play();
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // Increase the health of player by score value.
            playerHealth.Heel(heelValue);
            Destroy(gameObject, 0f);

        }
    }
}
