using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

internal sealed class Food : MonoBehaviour
{
    public event Action<int> AddScores = delegate (int i) { };
}
