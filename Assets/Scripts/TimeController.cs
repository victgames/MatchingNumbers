using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    private float time = 4.0f;
    private float oneTime = 1.0f;
    private string str;
    public AudioClip soundCountdown;
    private AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        //aud.PlayOneShot(soundCountdown);
    }

    void Update()
    {
        if (this.oneTime < 0.0f | this.oneTime >= 1.0f) {
            Debug.Log("Countdown");
            aud.PlayOneShot(soundCountdown);
            this.oneTime = 1.0f;
        }
        this.time -= Time.deltaTime;
        this.oneTime -= Time.deltaTime;

        if (this.time >= 1) {
            int intTime = (int)this.time;
            this.str = intTime.ToString();
            gameObject.GetComponent<Text>().text = this.str;
        }
        if (this.time < 1) {
            SceneManager.LoadScene("GameScene");
        }
        

    }
}
