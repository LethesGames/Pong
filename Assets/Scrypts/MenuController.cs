using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    private bool aiConrolled = false;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public bool GetAiControlled()
    {
        return aiConrolled;
    }

    public void set1PlayerControls()
    {
        aiConrolled = true;
        SceneManager.LoadScene("GameScene");
    }

    public void set2PlayersControls()
    {
        aiConrolled = false;
        SceneManager.LoadScene("GameScene");
    }
}
