using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchToWelcome : MonoBehaviour
{
    private Touch touch;
    
    void Start()
    {
        if (Input.touchCount > 0 ) 
        {
        SceneManager.LoadScene("Welcome");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 ) 
        {
          SceneManager.LoadScene("Welcome");
        }
    }
}
