using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            transform.Translate(new Vector3(0, 1, 0) * movementSpeed * Time.deltaTime);    
        }
        if(Input.GetKey("down")){
            transform.Translate(new Vector3(0, -1, 0) * movementSpeed * Time.deltaTime);    
        }
    
    }
}
