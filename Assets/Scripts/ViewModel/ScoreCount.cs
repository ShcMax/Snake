using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

internal sealed class ScoreCount : IScoreChange
{
    public ITake Take { get; set; }

    public event Action<int> OnScoreChange;

    public ScoreCount(ITake take)
    {
        Take = take;
    }

    public void ScoreChange(int score)
    {
        Take.Score += score;

        OnScoreChange?.Invoke(Take.Score);
    }
}
