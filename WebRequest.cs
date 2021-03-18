using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using UnityEngine.UI;
using SimpleJSON;
using TMPro;

public class WebRequest : MonoBehaviour
{   
  // public GameObject box;
  // public Text textElement;
    public void StartCo()
    
    {
      StartCoroutine(GetLetters());
    }

    IEnumerator GetLetters()
    {
      UnityWebRequest letters = UnityWebRequest.Get("http://localhost:3000/letters");
      yield return letters.SendWebRequest();
    
      JSONNode letterInfo = JSON.Parse(letters.downloadHandler.text);
      Text text = gameObject.GetComponent<Text>();
      
      foreach (var element in letterInfo)
      {
      Debug.Log(element["character"]);
      } 
    }

    public void FillWord(words)

    
}
