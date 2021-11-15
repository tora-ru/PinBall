using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngel = -20;

    //Use this for initialization
     void Start ()
    {
        //HingeJoint�R���|�l�[�g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    //Update is called once per frame
    void Update()
    {
     //�����L�[�����������ɍ��t���b�p�[�𓮂���
     if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle (this.flickAngel);
        }
     //�E���L�[�����������Ƀt���b�p�[�𓮂���
     if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle (this.flickAngel);
        }
     //���L�[�����ꂽ���Ƀt���b�p�[�����Ƃɖ߂�
     if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
     if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
    
}