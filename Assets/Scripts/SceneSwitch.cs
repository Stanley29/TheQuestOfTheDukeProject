using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    int y = SceneManager.GetActiveScene().buildIndex;
    void OnTriggerEnter(Collider ChangeScene)
    {
        if (ChangeScene.gameObject.CompareTag("Player") && ScoreManager.score >= 1)
        {
            SceneManager.LoadScene(y + 1);
        }
    }
}
