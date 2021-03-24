using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using System.Timers;
using TMPro;
using SimpleJSON; 
using UnityEngine.Networking;
using System.IO;

public class TimerC : MonoBehaviour
{   
    public float timeRemaining = 7;
    public bool timerIsRunning = false;
    public GameObject words; 
  
    void Start()
    {   
        timerIsRunning = true;
    }

    void Update()
    { 
      gameObject.GetComponent<TMP_Text>().text = timeRemaining.ToString("0");
      if (timerIsRunning)
      {
        if (timeRemaining > 0)
        {
          timeRemaining -= Time.deltaTime; 
        }
        else
        {
          StartCoroutine(GetLetters());
          timeRemaining = 7; 
        }
      }
    }

    public delegate void WordSetter(JSONNode letter);

    public void SetWord(JSONNode letters)
    { 
      Text text = words.GetComponent<Text>();
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
