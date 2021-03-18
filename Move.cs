using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Move : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;

    void Start()
    {
        speedModifier = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        
        {
          touch = Input.GetTouch(0);
          if (touch.phase == TouchPhase.Moved)
          {
            transform.position = new Vector3(
              transform.position.x + touch.deltaPosition.x  * speedModifier,
              transform.position.y + touch.deltaPosition.y * speedModifier);
              // transform.position.z + touch.deltaPosition.y * speedModifier);
          }
        }
    }
}
