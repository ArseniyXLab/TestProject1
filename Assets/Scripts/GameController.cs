using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }
    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Key X pressed ");
        }
    }
}
