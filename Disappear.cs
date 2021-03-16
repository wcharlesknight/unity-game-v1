﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Disappear : MonoBehaviour
{
   

    void Start()
    {
        // if (Input.touchCount > 0 ) 
        // {
        //   gameObject.SetActive(false);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began ) 
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
          RaycastHit hit; 
          if (Physics.Raycast(ray, out hit))
          {
            if(hit.collider != null)
            {
              print(hit.collider);
            }
          }
        }
    }
}
