using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool alive = true;
    public AudioClip soundScoring;
    public AudioClip soundLosing;
    public AudioSource sound;
    public Text highestScore;

    void Start() {
        sound = GetComponent<AudioSource>();
    }

    [ContextMenu("Keeping score")]
    public void addScore() {
        sound.PlayOneShot(soundScoring);
        score += 1;
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        int highest = PlayerPrefs.GetInt("HighestScore",0);
        if(score>highest) PlayerPrefs.SetInt("HighestScore",score);
        highestScore.text = PlayerPrefs.GetInt("HighestScore",0).ToString();
        gameOverScreen.SetActive(true);
        alive = false;
        sound.PlayOneShot(soundLosing);
    }
}
