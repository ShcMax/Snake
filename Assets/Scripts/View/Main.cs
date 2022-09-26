using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

internal sealed class Main : MonoBehaviour
{
    [SerializeField] private Snake _snake;
    [SerializeField] private Food _food;

    [SerializeField] private Text _text;
    private UIDisplayBonus _displayScore;

    private int _scoreCount;


    private void Awake()
    {
        _displayScore = new UIDisplayBonus(_text);
    } 
    
    void Update()
    {
        _snake.SnakeMove();
        _snake.SnakeRotate();
    }

    public void AddScore(int value)
    {
        _scoreCount += value;
        _displayScore.Display(_scoreCount);
    }
   
}
