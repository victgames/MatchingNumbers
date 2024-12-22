using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour {

    public Text highScoreText; //�n�C�X�R�A��\������Text
    public Text ScoreText; //�n�C�X�R�A��\������Text
    public static int score = 0; //�n�C�X�R�A�p�ϐ�
    private int highScore = 0; //�n�C�X�R�A�p�ϐ�
    private string key = "HIGH SCORE"; //�n�C�X�R�A�̕ۑ���L�[

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
        //�ۑ����Ă������n�C�X�R�A���L�[�ŌĂяo���擾���ۑ�����Ă��Ȃ����0�ɂȂ�
        highScoreText.text = highScore.ToString();
        //�n�C�X�R�A��\��
    }

    void Update() {
        ScoreText.text = score.ToString();

        //�n�C�X�R�A��茻�݃X�R�A��������
        if (score > highScore) {
            highScore = score;
            //�n�C�X�R�A�X�V
            PlayerPrefs.SetInt(key, highScore);
            //�n�C�X�R�A��ۑ�
            highScoreText.text = highScore.ToString();
            //�n�C�X�R�A��\��
        }
    }
}