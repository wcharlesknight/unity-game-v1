using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;


public class Disappear : MonoBehaviour
{
 
  public void ToggleVisibility()
  {
  
  Renderer rend = gameObject.GetComponent<Renderer>();
  Debug.Log(rend);
  if (rend.enabled)
    rend.enabled = false;
  else
    rend.enabled = true;
  }
}
