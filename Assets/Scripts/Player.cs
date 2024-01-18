using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public AudioSource Lose;
    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    void Movement()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime * playerSpeed);

    }
    
    void GameOver()
    {
        //Game ends if timer hits 0
        Lose.Play();
        Destroy(this.gameObject);
    }
}
