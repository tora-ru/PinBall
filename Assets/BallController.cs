using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\�������邚���̍ő�l
    private float visiblePosZ = -6.5f;

    //Game�I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;

    //Use this for inialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g�擾
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o�[��\������
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
        }
    }
}
