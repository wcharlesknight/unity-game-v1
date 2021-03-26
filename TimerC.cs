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
    public GameObject[] GLetters; 
    public GameObject[] LetterBox;
    
    void Start()
    {   
        // for (int i  = 0; i < 8; i++)
        // {

        // }
        timerIsRunning = true;
    }

    void Update()
    { 
      gameObject.GetComponent<TextMesh>().text = timeRemaining.ToString("0");
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
      List<JSONNode> Glets = new List<JSONNode>();  
      foreach (JSONNode element in letters)
      {
        Glets.Add(element);
      }
      for(int i = 0; i < 8; i++)
      { 
        GLetters[i].GetComponent<TextMeshProUGUI>().SetText(Glets[i]["character"]); 
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

