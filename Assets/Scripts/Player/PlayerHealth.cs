using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    public GameObject deathScreen;


    AudioSource playerAudio;
    bool isDead;
    bool damaged;


    void Awake ()
    {
        playerAudio = GetComponent <AudioSource> ();
        currentHealth = startingHealth;
    }


    void Update ()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }
    }

    public void Heel(int amount)
    {
        if (currentHealth < 100)
        {
            currentHealth += amount;
        }

        healthSlider.value = currentHealth;

    }


    void Death ()
    {
        isDead = true;

        deathScreen.SetActive(true);

        playerAudio.clip = deathClip;
        playerAudio.Play ();
    }


    public void RestartLevel ()
    {
        Application.LoadLevel (Application.loadedLevel);
    }
}
