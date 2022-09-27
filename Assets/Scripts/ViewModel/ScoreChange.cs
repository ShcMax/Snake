using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public sealed class ScoreChange
{
    private TakeFood Take { get; set; }

    public event Action<int> OnTakeFood;


    private ScoreChange(TakeFood take)
    {
        Take = take;
    }

    public void TakeFood(int food)
    {
        Take.Score += food;
        OnTakeFood?.Invoke(Take.Score);
    }

}
