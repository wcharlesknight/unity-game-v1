using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChooseLetter : MonoBehaviour
{
    public GameObject[] containers; 
    int currentLe = -1;
    private Vector3 startingP;
    bool chosen = false;
    bool backToPos = false;
    public GameObject childText; 
    
    void Start()
    {   
        // TMP_Text textM = childText.GetComponent<TMP_Text>();
        // Debug.Log(textM.text); 
        Animator anim = gameObject.GetComponent<Animator>();
        anim.enabled = false; 
        startingP = transform.position; 
    }

    void Update()
    { 
      Debug.Log(GlobalState.GaWord);  
      if (backToPos == true)
      {
        StartCoroutine(MoveBack());
      }
      if (currentLe >= 0 && backToPos == false)
      {
        StartCoroutine(MoveTo());
      }
    }
    
    public void ToggleAnimation()
    {   
      
      if (chosen == true)
      {
      StartCoroutine(SubtractOne()); 
      }
      if (chosen == false)
      {
    
      currentLe = GlobalState.LettersPicked;
      StartCoroutine(AddOne()); 
      }
    }

    IEnumerator MoveBack() 
    {
      yield return transform.position = Vector3.MoveTowards(transform.position, startingP, 0.4f); 
    }

    IEnumerator MoveTo()
    { 
      yield return transform.position = Vector3.MoveTowards(transform.position, containers[currentLe].transform.position, 0.4f);
    }

    IEnumerator AddOne()
    {  
        yield return GlobalState.GaWord += childText.GetComponent<TMP_Text>().text; 
        yield return GlobalState.LettersPicked += 1;
        yield return chosen = true;  
        yield return backToPos = false; 
    }

    IEnumerator SubtractOne()
    { 
      yield return GlobalState.GaWord = GlobalState.GaWord.Remove(GlobalState.GaWord.Length - 1, 1); 
      yield return GlobalState.LettersPicked -= 1; 
      yield return chosen = false; 
      yield return backToPos = true; 
    }
}
