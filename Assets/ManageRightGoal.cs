using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageRightGoal : MonoBehaviour
{
    
    public GameObject gameManagerObject;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        gameManager.AddGoal("right");
    }
}
