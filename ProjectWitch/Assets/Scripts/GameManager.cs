using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public static GameManager instance;
    public bool IsGameOver { get; private set; }
    public int Timer;
    public TMP_Text TimerText;
    float speed;
    

    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);
        speed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!IsGameOver)
        {
            speed += 0.00002f;
            Timer++;
            TimerText.text = (Timer/60).ToString();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public float Speed()
    {
        return speed;
    }

    public void AddScore(int amount)
    {
        Timer += amount;
    }

    public void GameOver()
    {
        IsGameOver = true;
        GameOverPanel.SetActive(true);
    }
}
