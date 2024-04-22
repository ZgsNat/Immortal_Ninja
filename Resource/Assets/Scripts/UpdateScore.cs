using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UpdateScore : MonoBehaviour
{
    public UIDocument document;
    private Label scoreLabel;
    private float elapsedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = document.rootVisualElement.Q<Label>("Score");
    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        scoreLabel.text = "Time: " + elapsedTime.ToString("F2");
    }
}
