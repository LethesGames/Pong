using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    private float movementSpeed = 10f;
    private Vector3 currentPosition;
    
    private void Awake()
    {
        currentPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        if (Input.GetKey("w") && currentPosition.y < 3.68f )
        {
            transform.Translate(new Vector3(0, 1, 0) * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s") && currentPosition.y > -3.68f )
        {
            transform.Translate(new Vector3(0, -1, 0) * movementSpeed * Time.deltaTime);
        }


    }
}
