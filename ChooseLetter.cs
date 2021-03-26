using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLetter : MonoBehaviour
{
    public GameObject[] containers; 
    int currentLe = -1;
    private Vector3 startingP;
    bool chosen = false;
    bool backToPos = false; 
    
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.enabled = false; 
        startingP = transform.position; 
    }

    void Update()
    {
      if (backToPos == true)
      {
        transform.position = Vector3.MoveTowards(transform.position, startingP, 0.4f); 
      }
      if (currentLe >= 0 && backToPos == false)
      {
      transform.position = Vector3.MoveTowards(transform.position, containers[currentLe].transform.position, 0.4f);
      }
    }
    
    public void ToggleAnimation()
    {  
      Debug.Log(gameObject);
      currentLe = GlobalState.LettersPicked;
      StartCoroutine(AddOne()); 
    }

    IEnumerator AddOne()
    { 
      if (chosen == true)
      {
        backToPos = true; 
        StartCoroutine(SubtractOne());
      }
        yield return new WaitForSeconds(0.5f);
        yield return GlobalState.LettersPicked += 1; 
        yield return chosen = !chosen; 
      
    }

    IEnumerator SubtractOne()
    {
      yield return GlobalState.LettersPicked -= 1; 
      Debug.Log(GlobalState.LettersPicked); 
    }
}
