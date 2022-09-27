using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

internal sealed class Main : MonoBehaviour
{
    [SerializeField] private Snake _snake;
    [SerializeField] private Food _food;

   
    void Update()
    {
        _snake.SnakeMove();
        _snake.SnakeRotate();
    }
   
   
}
