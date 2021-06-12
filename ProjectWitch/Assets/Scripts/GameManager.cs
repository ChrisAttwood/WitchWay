using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverText;
    public static GameManager instance;
    public bool IsGameOver { get; private set; }
    public int Timer;
    public TMP_Text TimerText;

    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGameOver)
        {
            Timer++;
            TimerText.text = (Timer/60).ToString();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void AddScore(int amount)
    {
        Timer += amount;
    }

    public void GameOver()
    {
        IsGameOver = true;
        GameOverText.SetActive(true);
    }
}
