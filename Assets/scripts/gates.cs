using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gates : MonoBehaviour
{
    public Text Score;
    private int score = 0;
    public GameObject Ball;
    public Transform Spawn;


    void Start()
    {
        score = 0;
    }

   
    private void OnTriggerEnter(Collider other)
    {
if (other.gameObject.CompareTag("Ball"));
{
    Destroy (other.gameObject);
    score +=1;
    Score.text = "Очки игрока: " + score;
    Instantiate(Ball, Spawn.position, transform.rotation);
}        
    }
}
