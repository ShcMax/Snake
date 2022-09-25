using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IScoreChange
{
    ITake Take { get; set; }

    void ScoreChange(int score);


    event Action<int> OnScoreChange;
}
