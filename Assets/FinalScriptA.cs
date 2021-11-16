using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScriptA : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextScene", 30f);
    }

    // Update is called once per frame
    void NextScene()
    {
       FadeManager.Instance.LoadScene ("Babyroom", 1.0f);
       
       //UnityEngine.SceneManagement.SceneManager.LoadScene("Babyroom");

    }
}