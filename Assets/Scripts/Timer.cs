using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    public AudioSource Lose;
    public AudioSource Win;
    public Text countdownText;
    public GameObject YouLose;
    public GameObject TorchWin;

    void Start()
    {
        currentTime = startingTime;
        YouLose.SetActive(false);
        TorchWin.SetActive(true);
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            GameLost();
        }
    }

    void GameLost()
    {
        YouLose.SetActive(true);
        Lose.Play();
        Destroy(this.gameObject);
    }

    void GameWon()
    {
        Win.Play();
        Destroy(this.gameObject);
    }
}
