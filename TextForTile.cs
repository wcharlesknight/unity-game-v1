using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TextForTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject text = new GameObject();
        TextMesh t = text.AddComponent<TextMesh>();
        t.text = "L";
        t.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
