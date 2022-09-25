using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal sealed class Snake : MonoBehaviour
{    
    [SerializeField] Text _text;
    [SerializeField] private int _score = 1;
    private IScoreChange _scoreChange;        

    public void Initialize(IScoreChange scoreChange)
    {
        _scoreChange = scoreChange;
        _scoreChange.OnScoreChange += OnScoreChange;
        OnScoreChange(_scoreChange.Take.Score);
    }

    private void OnScoreChange(int score)
    {
        _text.text = _scoreChange.Take.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {            
            OnScoreChange(_score);
            Debug.Log(_scoreChange.Take);
        }
    }
    public void Move()
    {
       

    }
}
