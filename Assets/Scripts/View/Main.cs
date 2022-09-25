using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Main : MonoBehaviour
{
    [SerializeField] Food _food;
    [SerializeField] Snake _snake;

    private void Awake()
    {        
        var food = new TakeFood(0);
        var scoreCount = new ScoreCount(food);        
        _food.Initialize(scoreCount);
        _snake.Initialize(scoreCount);
    }

    private void Update()
    {
        
    }
}
