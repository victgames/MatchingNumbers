using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverDirector : MonoBehaviour
{
    private float time = 0.0f;
    public AudioClip soundExplosion;
    private AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.PlayOneShot(soundExplosion);
    }

    void Update()
    {
        this.time += Time.deltaTime;
        if (this.time > 4.0f) {
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("SelectScene");
        }
        
    }
}
