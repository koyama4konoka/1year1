using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //toBaby();
        }

         if(Input.GetKeyDown(KeyCode.Space)){
            //toBlack();
        }
        
        if(Input.GetKeyDown(KeyCode.Space)){
            //toDesert1();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toDesert2();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toForest();
        }

         if(Input.GetKeyDown(KeyCode.Space)){
            //toPark();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toAScene();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toBScene();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toButterfly();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toGallery();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            //toBabyroom();
        }

         if(Input.GetKeyDown(KeyCode.Space)){
            //FinalTree();
        }


    }
    public void toBaby(){

        FadeManager.Instance.LoadScene ("Baby", 1.0f);
    
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Baby");
    }

    public void toBlack(){

        FadeManager.Instance.LoadScene ("Black", 1.0f);
    
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Black");
    }
    
     

    public void toDesert1(){
        
        FadeManager.Instance.LoadScene ("Desert1", 1.0f);
        
        //UnityEngine.SceneManagement.SceneManager.LoadScene("toDesert1");
    }

    public void toDesert2(){
        
        FadeManager.Instance.LoadScene ("Desert2", 1.0f);
        
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Desert2");
    }

    public void toForest(){

        FadeManager.Instance.LoadScene ("Forest", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Forest");
    }

    public void toPark(){

        FadeManager.Instance.LoadScene ("Park", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Park");
    }

    public void toAScene(){

        FadeManager.Instance.LoadScene ("AScene", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("AScene");
    }

    public void toBScene(){

        FadeManager.Instance.LoadScene ("BScene", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("BScene");
    }

    public void toButterfly(){

        FadeManager.Instance.LoadScene ("Butterfly", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Butterfly");
    }

    public void toGallery(){

        FadeManager.Instance.LoadScene ("Gallery", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Gallery");
    }


    public void toBabyroom(){

        FadeManager.Instance.LoadScene ("Babyroom", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Babyroom");
    }

    public void toFinalTree(){

        FadeManager.Instance.LoadScene ("FinalTree", 1.0f);

        //UnityEngine.SceneManagement.SceneManager.LoadScene("FinalTree");
    }



}

    