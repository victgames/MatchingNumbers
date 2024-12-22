using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {
    private Vector3 initialPosition; // 初期位置
    private Quaternion initialRotation; // 初期回転
    string thisTagName;
    string otherTagName;
    private GameObject canvas;
    private BlockTimeController btc;
    private GameDirector gd;
    private BlockGenerator bg;


    void Start() {
        thisTagName = this.gameObject.tag;
        otherTagName = "other";
        initialPosition = gameObject.transform.position;
        initialRotation = gameObject.transform.rotation;

        canvas = transform.Find("Canvas").gameObject;
        btc = GetComponentInChildren<BlockTimeController>();
        bg = GameObject.Find("BlockGenerator").GetComponent<BlockGenerator>();
        gd = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    void OnMouseDrag() {
        Vector3 thisPosition = Input.mousePosition;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(thisPosition);
        worldPosition.z = 0f;
        this.transform.position = worldPosition;

        canvas.transform.position = worldPosition;
        //Debug.Log("x:" + canvas.transform.position.x);
    }

    void OnMouseUp() {
        Debug.Log(thisTagName + " " + otherTagName);
        if (thisTagName == otherTagName) {
            //Debug.Log(gameObject.name);
            int block = int.Parse(gameObject.name);
            bg.blocks[block] = false;
            //Debug.Log(btc.restTime);
            gd.GetPoint(btc.intRestTime);
            Destroy(gameObject);
        }
        else {
            gameObject.transform.position = initialPosition; // 位置の初期化
            gameObject.transform.rotation = initialRotation; // 回転の初期化
            //Destroy(canvas);
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        otherTagName = other.tag;
    }

    void OnTriggerExit2D(Collider2D other) {
        otherTagName = "other";
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //音(sound1)を鳴らす
            Debug.Log("Sound");
            //aud.PlayOneShot(soundPoint);
        }

            //Debug.Log(btc.restTime);
            if (btc.gameOverFlug == true) {
            gd.GameOver();
        }   
    }
}