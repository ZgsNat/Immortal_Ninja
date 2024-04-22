using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuSystem : MonoBehaviour
{
    public GameObject menuPause;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
                menuPause.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Pause").style.display = DisplayStyle.None;

            }
            else
            {
                UnityEngine.Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
                menuPause.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Pause").style.display = DisplayStyle.Flex;
            }
        }
    }
}
