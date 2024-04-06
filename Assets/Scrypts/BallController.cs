using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody2D ballRB;

    // Start is called before the first frame update
    void Start()
    {
        ballRB = ball.GetComponent<Rigidbody2D>();
        ballRB.gravityScale = 0;
        ballRB.velocity = new Vector2(10,Random.Range(-10f, 10f));
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = ballRB.velocity.x;
        float yVelocity = ballRB.velocity.y;

        if(xVelocity > 0){
            ballRB.velocity = new Vector2(+10f, ballRB.velocity.y);
        }else{
            ballRB.velocity = new Vector2(-10f, ballRB.velocity.y);
        }

        if(yVelocity > 0){
            ballRB.velocity = new Vector2(ballRB.velocity.x, +10);
        }else{
            ballRB.velocity = new Vector2(ballRB.velocity.x, -10);
        }        
    }

    public void RespawnBall(string side) {
        transform.position = new Vector3(0, 0,0 );
        if("right".Equals(side)){
            ballRB.velocity = new Vector2(-10,Random.Range(-10f, 10f));
        }else{
            ballRB.velocity = new Vector2(10, Random.Range(-10f, 10f));
        }
    }
}
