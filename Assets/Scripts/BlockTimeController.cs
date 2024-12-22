using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlockTimeController : MonoBehaviour {

    private int rnd;
    private string str;
    private float time = 0.0f;
    public float restTime = 0.0f;
    public int intRestTime = 0;
    public bool gameOverFlug = false;

    private void Start() {
        this.rnd = UnityEngine.Random.Range(5, 10);
    }

    private void Update() {
        this.time += Time.deltaTime;
        //Debug.Log(this.time + " " + (int)this.time);
        this.restTime = this.rnd - this.time;

        if (this.restTime > 1.0f) {
            intRestTime = (int)this.restTime;
            str = this.intRestTime.ToString();
            gameObject.GetComponent<Text>().text = str;
            //transform.position += new Vector3(0f, 0.03f, 0f);
        }
        else {
            gameOverFlug = true;
        }
    }
}