using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseDeadMenu : MonoBehaviour
{
    public UIDocument document;
    private Button back;
    private Button restart;
    private Label HiScore;
    // Start is called before the first frame update
    void Start()
    {
        HiScore = new Label();
        HiScore = document.rootVisualElement.Q<Label>("HiScore");
        HiScore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore").ToString();
        document.rootVisualElement.Q<VisualElement>("Pause").style.display = DisplayStyle.None;
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
        
    }
}
