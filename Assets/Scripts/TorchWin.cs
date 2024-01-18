using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchWin : MonoBehaviour
{
    public AudioSource Win;
    public GameObject YouWin;
    public GameObject YouLose;
    public int currentTime;

    void Start()
    {
        Win = GetComponent<AudioSource>();
        YouWin.SetActive(false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Win.Play();
        YouWin.SetActive(true);
        Application.Quit();
        Debug.Log("Quitting");
    }

}
