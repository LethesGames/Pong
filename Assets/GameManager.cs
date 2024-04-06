using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{

    private int player1Score = 0;
    private int player2Score = 0;
    public GameObject ball;

    public TMP_Text player1ScoreTxt;
    public TMP_Text player2ScoreTxt;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGoal(string side) {
        if("right".Equals(side)){
            player1Score++;
            player1ScoreTxt.text = player1Score.ToString();
            Debug.Log("Player1Score: " + player1Score);
        }else{
            player2Score++;
            player2ScoreTxt.text = player2Score.ToString();
            Debug.Log("Player2Score: " + player2Score);
        }

        ball.GetComponent<BallController>().RespawnBall(side);
    }
    
}
