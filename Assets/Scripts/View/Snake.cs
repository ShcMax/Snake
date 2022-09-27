using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

internal sealed class Snake : MonoBehaviour
{
    [SerializeField] Main _main;

    [SerializeField] Text text;  

    private float _horizontal;
    private float _speedRotate = 100;

    private Food _food;
    
    void Start()
    {
        _food = new Food(1);
    }        

    public void SnakeMove()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void SnakeRotate()
    {
        _horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * _horizontal * _speedRotate * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {        
        if(other.CompareTag("Food"))
        {
            AddScore(_food.ScoreCount);
            text.text = _food.Score.ToString();                
        }
    }   
    private void AddScore(int score)
    {
        score = 1;
        _food.Score += score;
    }
}
