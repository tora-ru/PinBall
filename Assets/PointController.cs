using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text scoreText;

    //LargeStar�̃|�C���g
    const int StarPointL = 1;
    //SmallCroud�̃|�C���g
    const int CloudPointS = 5;
    //LargeCloud�̃|�C���g
    const int CloudPointL = 15;
    //�S�Ẵ|�C���g
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

    //�Փˎ��ɌĂ΂��֐�
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

