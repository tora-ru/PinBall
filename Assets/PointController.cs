using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text scoreText;

    //LargeStarのポイント
    const int StarPointL = 1;
    //SmallCroudのポイント
    const int CloudPointS = 5;
    //LargeCloudのポイント
    const int CloudPointL = 15;
    //全てのポイント
    int AllPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Point").GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LargeStarTag")
        {
            AllPoint += StarPointL;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            AllPoint += CloudPointS;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            AllPoint += CloudPointL;
        }

        this.scoreText.text = this.AllPoint.ToString();
    }
}

