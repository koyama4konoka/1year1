using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyBaby : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinCount = 0;
    public Text coinLabel;
    GameObject lasthit;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag=="Coin"){

            Debug.Log(collision.gameObject.name);
            if (collision.gameObject==lasthit){
                //2回ヒットしちゃう時があるから
                return;
            }
            int type=collision.gameObject.GetComponent<Coin>().type;
            if(type==1){
                FindObjectOfType<MySceneManager>().toDesert1();
            }

            if(type==2){
                FindObjectOfType<MySceneManager>().toForest();
            }

            if(type==3){
                FindObjectOfType<MySceneManager>().toButterfly();
            }

            if(type==4){
                FindObjectOfType<MySceneManager>().toButterfly();
            }

            if(type==5){
                FindObjectOfType<MySceneManager>().toGallery();
            }

        }
        
    }
    void bkOnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag=="Coin"){
            if (collision.gameObject==lasthit){
                //2回ヒットしちゃう時があるから
                return;
            }
            lasthit = collision.gameObject;
            Debug.Log("当たった!"+collision.gameObject.tag);
            Destroy(collision.gameObject);
            coinCount = coinCount + 1;
            if(coinCount >= 2){
                //メインシーンに移動
                //シーンマネージャーを経由してメインシーンに移動
                FindObjectOfType<MySceneManager>().toGallery();

            }
            //もしコインカウントが２以上であれば
            coinLabel.text = coinCount.ToString();
            Color c = coinLabel.color;
            c.a = 0f;
            coinLabel.color = c;
            coinLabel.DOFade(1f,0.5f);
        } 
    }



}
