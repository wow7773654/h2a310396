using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFunction : MonoBehaviour {
    public GameObject Emeny;
    public float time;
    public Text ScoreText;
    public int Score = 0;
    public static GameFunction instance;
    public GameObject GameTitle;
    public GameObject GameOverTitle;
    public GameObject PlayButton;
    public bool isPlaying = false;
    public GameObject RestartButton;
    public GameObject QuitButton;
	// Use this for initialization
	void Start () {
        instance = this;

        GameOverTitle.SetActive(false);
        RestartButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time>0.5f && isPlaying == true)
        {
            Vector3 pos = new Vector3(Random.Range(-2.5f, 2.5f), 4.5f, 0);
            Instantiate(Emeny, pos, transform.rotation);
            time = 0f;
        }
	}
    public void AddScore()
    {
        Score += 10;
        ScoreText.text = "Score:" + Score;
    }
    public void GameStart()
    {
        isPlaying = true;
        GameTitle.SetActive(false);
        PlayButton.SetActive(false);

        QuitButton.SetActive(false);
    }
    public void GameOver()
    {
        isPlaying = false;
        GameOverTitle.SetActive(true);

        RestartButton.SetActive(true);
        QuitButton.SetActive(true);
    }
    public void ResetGame()
    {
        Application.LoadLevel (Application.loadedLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
