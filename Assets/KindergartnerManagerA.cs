using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KindergartnerManagerA : MonoBehaviour
{
  public Text label; 
  public GameObject particle;

    // Update is called once per frame
    void Update()
    {
        float y = 0;
         if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.UpArrow)){
            y = 0.1f;
         }
            
        //float z = Input.GetAxis("Vertical");
        
        float positionZ = transform.position.z;//e
        positionZ = positionZ + y;//e
  
        transform.position = new Vector3(0, 0, positionZ);
        string message = "";
        if (positionZ > 2){
            message = "赤ちゃんはあらゆる物事の始まり";
        }

        if (positionZ > 6){
            message = "";
        }
       
        if (positionZ > 7){
            message = "母の腕は優しさで出来ていて";
        }

        if (positionZ > 11){
            message = "";
        }
       
        if (positionZ > 12){
            message = "子は母の袂でぐっすり眠る";
        }

        if (positionZ > 16){
            message = "";
        }
       
        if (positionZ > 17){
            message = "赤ちゃんは天使のように純粋で";
        }

        if (positionZ > 20){
            message = "";
        }
       
        if (positionZ > 21){
            message = "咲く花のように新しい";
        }
        
        if (positionZ > 26){
            message = "";
        }

        if(positionZ > 27){
    
            FindObjectOfType<MySceneManager>().toBlack();

        }

        if(positionZ > 20){
            particle.SetActive(true);
        }



        label.text= message;

        audioSource.volume = 1 - Mathf.Clamp(positionZ / 33, 0, 1);
    
    }

    public AudioSource audioSource;
}
