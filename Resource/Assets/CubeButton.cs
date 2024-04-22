using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeButton : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Option;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseUpAsButton()
    {
        Option.SetActive(false);
        Menu.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("StartMenu").style.display = DisplayStyle.Flex;
    }
}
