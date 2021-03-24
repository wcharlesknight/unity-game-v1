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

    public delegate void WordSetter(JSONNode letter);

    public void SetWord(JSONNode letters)
    { 
      // List<object> MainLetters = new List<object>();
      Text text = gameObject.GetComponent<Text>();
      text.text = "";
      foreach (JSONNode element in letters)
      {
        text.text += element["character"];
      }
    }

    IEnumerator GetLetters()
    {
      UnityWebRequest letters = UnityWebRequest.Get("http://localhost:3000/letters");
      yield return letters.SendWebRequest();
      JSONNode letterInfo = JSON.Parse(letters.downloadHandler.text); 
      WordSetter del = SetWord;
      del(letterInfo);
    }

}
