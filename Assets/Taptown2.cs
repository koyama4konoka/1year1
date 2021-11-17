using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Taptown2 : MonoBehaviour
{
    float tapCount = 0;
    private int counter = 0;
    public GameObject phone1;
    public GameObject book;
    public GameObject sandclock;
    public GameObject Tree;
    public GameObject Butterfly;
    public GameObject TreeA;
    public GameObject Monitor;
    public GameObject flower01;
    public GameObject flower02;
    public GameObject flower03;
    public GameObject flower04;
    public GameObject flower05;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    public void NextScene(){
         FindObjectOfType<MySceneManager>().toBaby();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)){
           tapCount = tapCount + 1;
       }

       if(tapCount > 0){
          phone1.SetActive(true);
          phone1.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 1){
          book.SetActive(true);
          book.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 2){
          sandclock.SetActive(true);
          sandclock.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 3){
          Tree.SetActive(true);
          Tree.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 4){
          Butterfly.SetActive(true);
          Butterfly.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 5){
          TreeA.SetActive(true);
          TreeA.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 6){
          Monitor.SetActive(true);
          Monitor.transform.DOScale(Vector3.one,1f);//oneアイテムの大きさ、1f出現の速さ
       }

       if(tapCount > 8 && counter == 0){
         FindObjectOfType<MySceneManager>().toPark();
         counter++;
       }

    }
}