using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLetter : MonoBehaviour
{
    public GameObject[] containers; 
    int currentLe = -1;
    
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.enabled = false; 
    }

    void Update()
    {
      if (currentLe >= 0)
      {
      transform.position = Vector3.MoveTowards(transform.position, containers[currentLe].transform.position, 0.4f);
      }
    }
    
    
    public void ToggleAnimation()
    {
      currentLe = GlobalState.LettersPicked;
      StartCoroutine(AddOne()); 
    }

    IEnumerator AddOne()
    { 
      yield return new WaitForSeconds(0.5f);
      yield return GlobalState.LettersPicked += 1; 
    }
}
