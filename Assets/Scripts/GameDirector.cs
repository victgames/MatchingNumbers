using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    private GameObject pointText;
    private int point = 0;

    public AudioClip soundPoint;
    private AudioSource aud;
    //private StartDirector sd;

    public void GetPoint(int restTime) {

        aud.PlayOneShot(soundPoint);
        //Debug.Log("restTime:" + restTime);
        point = point + restTime;
    }

    public void GameOver() {
        //pointText.GetComponent<Text>().text = "GameOver";
        SceneManager.LoadScene("GameOverScene");
    }

    void Start()
    {

        aud = GetComponent<AudioSource>();
        pointText = GameObject.Find("Point");
        //sd = GameObject.Find("StartDirector").GetComponent<StartDirector>();
    }

    void Update()
    {


        //Debug.Log(StartDirector.score);
        StartDirector.score = point;
        pointText.GetComponent<Text>().text = point.ToString() + " point";
    }
}
