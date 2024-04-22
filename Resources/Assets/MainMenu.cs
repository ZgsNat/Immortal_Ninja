using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MainMenu : MonoBehaviour
{
    public UIDocument document;
    public GameObject mainMenu;
    public GameObject aboutUsMenu;
    public GameObject GuideMenu;
    public AudioSource audioSource;
    private int count = 0;
    Button play;
    Button option;
    Button aboutUs;
    Button guide;
    Button quit;
    // Start is called before the first frame update
    void Start()
    {
        play = new Button();
        option = new Button();
        aboutUs = new Button();
        quit = new Button();
        play = document.rootVisualElement.Q<Button>("Play");
        option = document.rootVisualElement.Q<Button>("Option");
        aboutUs = document.rootVisualElement.Q<Button>("AboutUs");
        quit = document.rootVisualElement.Q<Button>("Quit");
        guide = document.rootVisualElement.Q<Button>("Guide");
        play.clicked += PlayClick;
        option.clicked += OptionClick;
        aboutUs.clicked += AboutUsClick;
        quit.clicked += QuitClick;
        guide.clicked += GuideClick;


    }

    private void GuideClick()
    {
        mainMenu.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("StartMenu").style.display = DisplayStyle.None;
        GuideMenu.SetActive(true);
    }

    private void QuitClick()
    {
        Application.Quit();
    }

    private void AboutUsClick()
    {
        mainMenu.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("StartMenu").style.display = DisplayStyle.None;
        aboutUsMenu.SetActive(true);
    }

    private void OptionClick()
    {
        if(count%2 == 0)
        {
            audioSource.mute = true;
            count++;
        }
        else
        {
            audioSource.mute = false;
            count++;
        }
        
    }

    private void PlayClick()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        //mainMenu.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("StartMenu").style.display = DisplayStyle.None;
        //UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
