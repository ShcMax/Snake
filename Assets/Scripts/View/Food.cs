using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

internal sealed class Food : MonoBehaviour
{       
   
    public int Score { get; set; }
    public int ScoreCount { get; }

    int x;
    float y;
    int z;

    private void Awake()
    {
       
    }
    public Food(int scoreCount)
    {
        scoreCount = 1;
        ScoreCount = ScoreCount;
    }  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            x = Random.Range(-7, 7);
            y = Random.Range(0.15f, 0.15f);
            z = Random.Range(-7, 7);

            gameObject.transform.position = new Vector3(x, y, z);
        }
    }
}
