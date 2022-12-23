using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;

    public float snakeSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Debug.Log("Starting Snake Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
