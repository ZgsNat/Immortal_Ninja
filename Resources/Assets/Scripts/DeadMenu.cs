using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class DeadMenu : MonoBehaviour
{
    public UIDocument document;
    public GameObject ScoreMenu;
    private Button back;
    private Button restart;
    private Label HiScore;
    private Label Score;
    private Label Quote;
    float checkScore = 0;
    public string[] gameOverMessages = {
        "Game Over!",
        "Try Again!",
        "Better Luck Next Time!",
        "You Lose!"
    };
    // Start is called before the first frame update
    void Start()
    {
        document.rootVisualElement.Q<VisualElement>("Pause").style.display = DisplayStyle.None;
        HiScore = new Label();
        Score = new Label();
        Quote = new Label();
        Quote = document.rootVisualElement.Q<Label>("Quote");
        Quote.text = gameOverMessages[UnityEngine.Random.Range(0, gameOverMessages.Length)];
        Score = document.rootVisualElement.Q<Label>("Score");
        Score.text = ScoreMenu.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Score").text;
        Match match = Regex.Match(Score.text, @"\d+(\.\d+)?");
        if (match.Success)
        {
            // Extract the matched number
            float number = float.Parse(match.Value);

            // Use the extracted number
            checkScore = number;
        }
        if (checkScore >= PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", checkScore);
        }
        HiScore = document.rootVisualElement.Q<Label>("HiScore");
        HiScore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore").ToString();
        
        back = new Button();
        back = document.rootVisualElement.Q<Button>("Back");
        back.clicked += Back;
        restart = new Button();
        restart = document.rootVisualElement.Q<Button>("Restart");
        restart.clicked += Restart;
        
    }

    private void Restart()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Back()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*        if (document.rootVisualElement.Q<VisualElement>("Pause").style.display == DisplayStyle.Flex)
                {
                    Time.timeScale = 0f;
                }*/
        Score = document.rootVisualElement.Q<Label>("Score");
        Score.text = ScoreMenu.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Score").text;
        Match match = Regex.Match(Score.text, @"\d+(\.\d+)?");
        if (match.Success)
        {
            // Extract the matched number
            float number = float.Parse(match.Value);

            // Use the extracted number
            checkScore = number;
        }
        if (checkScore >= PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", checkScore);
        }
    }
}
