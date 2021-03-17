using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.iOS;

public class TouchToPlay : MonoBehaviour
{
  public void MoveScene()
  {
    SceneManager.LoadScene("Blue-sky");
  }
}
