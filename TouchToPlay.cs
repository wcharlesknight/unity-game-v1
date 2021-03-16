using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.iOS;

public class TouchToPlay : MonoBehaviour
{
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.touchCount > 0 ) 
        {
        SceneManager.LoadScene("Blue-sky");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 ) 
        {
          SceneManager.LoadScene("Blue-sky");
        }
    }
}
