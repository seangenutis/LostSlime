using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactTrigger : MonoBehaviour
    
{
    public AudioSource WallHit;

    void Start()
    {
        WallHit = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WallHit.Play();
    }

}