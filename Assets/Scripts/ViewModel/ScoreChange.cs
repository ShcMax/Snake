using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public sealed class ScoreChange : IScoreCount
{
    public ITake Take { get; }

    public event Action<int> OnTakeFood;


    public ScoreChange(ITake take)
    {
        Take = take;
    }

    public void TakeFood(int food)
    {
        Take.Score += food;
        OnTakeFood?.Invoke(Take.Score);
    }

}
