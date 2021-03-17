using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisappearText : MonoBehaviour
{
  // public Text text; 
  public void ToggleVisibility()
  {
  
  Text text = gameObject.GetComponent<Text>();
  Debug.Log(text);
  if (text.enabled)
    text.enabled = false;
  else
    text.enabled = true;
  }
}

