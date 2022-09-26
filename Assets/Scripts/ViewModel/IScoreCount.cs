using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IScoreCount
{
    ITake Take { get;}

    void TakeFood(int food);

    event Action<int> OnTakeFood;
   
}
    

