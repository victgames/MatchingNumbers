using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreDirector : MonoBehaviour
{
    public Text highScoreText; //�n�C�X�R�A��\������Text
    private int score = 0; //�n�C�X�R�A�p�ϐ�
    private int highScore = 0; //�n�C�X�R�A�p�ϐ�
    private string key = "HIGH SCORE"; //�n�C�X�R�A�̕ۑ���L�[

    void Start() {
        highScore = PlayerPrefs.GetInt(key, 0);
        //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
        highScoreText.text = highScore.ToString();
        //highScoreText.text = "HighScore: " + highScore.ToString();
        //�n�C�X�R�A��\��
    }

    void Update() {
        //�n�C�X�R�A��茻�݃X�R�A��������
        if (score > highScore) {

            highScore = score;
            //�n�C�X�R�A�X�V

            PlayerPrefs.SetInt(key, highScore);
            //�n�C�X�R�A��ۑ�

            highScoreText.text = highScore.ToString();
            //highScoreText.text = "HighScore: " + highScore.ToString();
            //�n�C�X�R�A��\��
        }
    }
}
