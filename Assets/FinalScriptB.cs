using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScriptB : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("NextScene", 10f);
    }

    // Update is called once per frame
    void NextScene()
    {
       FadeManager.Instance.LoadScene ("FinalTree", 1.0f);
       
       //UnityEngine.SceneManagement.MySceneManager.LoadScene("FinalTree");

    }
}