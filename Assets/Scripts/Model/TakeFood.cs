using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class TakeFood : ITake
{
    public int Score { get; set; }

    public TakeFood(int score)
    {
        Score = score;
    }
}
