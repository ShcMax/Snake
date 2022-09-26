using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

internal sealed class Snake : MonoBehaviour
{
    [SerializeField] Main _main;

    [SerializeField] Text text;

    private int _scoreCount;   

    private float _horizontal;
    private float _speedRotate = 100;

    private Food _food;    

    void Start()
    {
        
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
        if(other.gameObject.CompareTag("Food"))
        {
            Debug.Log("wwww");           
            _food.AddScores += AddScore;
            _main.AddScore(_scoreCount);            
        }
    }
    private void AddScore(int value)
    {
        _scoreCount += value;
    }
    
    
    
}
