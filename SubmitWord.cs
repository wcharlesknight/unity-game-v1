using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON; 
using UnityEngine.Networking;
using System.IO;

public class SubmitWord : MonoBehaviour
{
    public void Submit()
    {
      StartCoroutine(SubmitW());
    }

    IEnumerator SubmitW()
    {
      UnityWebRequest word = UnityWebRequest.Get("https://wordsapiv1.p.rapidapi.com/words/" + GlobalState.GaWord.ToLower());
      word.SetRequestHeader("x-rapidapi-key",  "a87f5b1016mshe5a42db9c818a58p1f3c56jsn8b59ca641ffc");
      word.SetRequestHeader("x-rapidapi-host", "wordsapiv1.p.rapidapi.com");
      word.SetRequestHeader("useQueryString", "true");
      yield return word.SendWebRequest();
      JSONNode letterInfo = JSON.Parse(word.downloadHandler.text); 
      Debug.Log(letterInfo); 
    }

}
