using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour {

    public Text highScoreText; //ハイスコアを表示するText
    public Text ScoreText; //ハイスコアを表示するText
    public static int score = 0; //ハイスコア用変数
    private int highScore = 0; //ハイスコア用変数
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー

    public void OnClickStart() {
        Debug.Log("Click");
        SceneManager.LoadScene("StartScene");
    }

    public void OnClickClose() {
        PlayerPrefs.DeleteAll();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    void Start() {
        //Debug.Log(score);
        highScore = PlayerPrefs.GetInt(key, 0);
        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = highScore.ToString();
        //ハイスコアを表示
    }

    void Update() {
        ScoreText.text = score.ToString();

        //ハイスコアより現在スコアが高い時
        if (score > highScore) {
            highScore = score;
            //ハイスコア更新
            PlayerPrefs.SetInt(key, highScore);
            //ハイスコアを保存
            highScoreText.text = highScore.ToString();
            //ハイスコアを表示
        }
    }
}