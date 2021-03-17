using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStart : MonoBehaviour
{

    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.enabled = false;
    }

  
  public void ToggleAnimation()
  {
    Animator anim = gameObject.GetComponent<Animator>();
    anim.enabled = true;
    anim.Play("UpDown", -1, 0f);
  }
}
