using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject blade;

    // Update is called once per frame
    void Update()
    {
        blade.transform.Rotate(0f, 0f, 1f, Space.Self);
    }
}
