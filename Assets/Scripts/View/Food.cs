using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal sealed class Food : MonoBehaviour
{
    [SerializeField] private Text _text;
    private IScoreChange _scoreChange;
    

    public void Initialize(IScoreChange scoreChange)
    {
        _scoreChange = scoreChange;
        
    } 
}

