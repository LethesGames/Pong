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
    private MenuController menuController;
    public GameObject player2;

    private void Awake()
    {
        menuController = GameObject.Find("MenuManager").GetComponent<MenuController>();

        if (menuController.GetAiControlled())
        {
            player2.GetComponent<Player2AIController>().enabled = true;
            player2.GetComponent<Player2Controller>().enabled = false;
        }
        else
        {
            player2.GetComponent<Player2AIController>().enabled = false;
            player2.GetComponent<Player2Controller>().enabled = true;
        }

        Destroy(GameObject.Find("MenuManager"));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddGoal(string side)
    {
        if ("right".Equals(side))
        {
            player1Score++;
            player1ScoreTxt.text = player1Score.ToString();
        }
        else
        {
            player2Score++;
            player2ScoreTxt.text = player2Score.ToString();
        }

        ball.GetComponent<BallController>().RespawnBall(side);
    }

}
