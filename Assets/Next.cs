using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("AScene", 15f);
    }

    // Update is called once per frame
    void NextScene()
    {
        FadeManager.Instance.LoadScene ("AScene", 1.0f);
       
        //UnityEngine.SceneManagement.SceneManager.LoadScene("AScene");

    }
}
