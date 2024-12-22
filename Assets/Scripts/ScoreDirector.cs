using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreDirector : MonoBehaviour
{
    public Text highScoreText; //ハイスコアを表示するText
    private int score = 0; //ハイスコア用変数
    private int highScore = 0; //ハイスコア用変数
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー

    void Start() {
        highScore = PlayerPrefs.GetInt(key, 0);
        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScoreText.text = highScore.ToString();
        //highScoreText.text = "HighScore: " + highScore.ToString();
        //ハイスコアを表示
    }

    void Update() {
        //ハイスコアより現在スコアが高い時
        if (score > highScore) {

            highScore = score;
            //ハイスコア更新

            PlayerPrefs.SetInt(key, highScore);
            //ハイスコアを保存

            highScoreText.text = highScore.ToString();
            //highScoreText.text = "HighScore: " + highScore.ToString();
            //ハイスコアを表示
        }
    }
}
