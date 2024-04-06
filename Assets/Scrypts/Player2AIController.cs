using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2AIController : MonoBehaviour
{

    private float movementSpeed = 10f;
    public GameObject ball;
    private BallController ballController;

    private void Awake()
    {
        ballController = ball.GetComponent<BallController>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > 0)
        {
            if (transform.position.y < 3.68f && transform.position.y > -3.68f)
            {
                MoveTowardsBall();
            }
            else if (transform.position.y >= 3.68f && ballController.GetVerticalBallSpeed() < 0)
            {
                MoveTowardsBall();
            }
            else if (transform.position.y <= -3.68f && ballController.GetVerticalBallSpeed() > 0)
            {
                MoveTowardsBall();
            }
        }else {
            transform.position = Vector3.MoveTowards(
                        transform.position,
                        new Vector3(
                            transform.position.x,
                            0f,
                            transform.position.z),
                        movementSpeed * Time.deltaTime);
        }




    }

    private void MoveTowardsBall()
    {
        transform.position = Vector3.MoveTowards(
                        transform.position,
                        new Vector3(
                            transform.position.x,
                            ball.transform.position.y,
                            transform.position.z),
                        movementSpeed * Time.deltaTime);
    }
}
