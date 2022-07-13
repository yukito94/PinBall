using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPoint : MonoBehaviour{

    // Material������
    //Material myMaterial;

    // �p�x
    private int degree = 0;

    //point�錾�Ə����l(���_)
    int point = 0;
    
    //point��\������e�L�X�g
    private GameObject ballpointText;

    // Start is called before the first frame update
    void Start()
    {
        //��ʉE��ɓ��_��\��
        this.ballpointText = GameObject.Find("BallPointText");

        // �^�O�ɂ����point�����Z���Ă�
    }

    // Update is called once per frame
    /*
    void Update()
    {
        //���_��\��
        this.ballpointText.GetComponent<Text>().text = "Point:" + point;
    }
    */

    void OnCollisionEnter(Collision other)
    {
        //other�F�{�[��
        //other.gameObject.tag�F�{�[���ȊO�̃Q�[���I�u�W�F�N�g

        // �^�O�ɂ����point�����Z���Ă�
        if (other.gameObject.tag == "SmallStarTag") //��������:10�_
        {
            point = point + 10;
        }
        else if (other.gameObject.tag == "LargeStarTag") //�傫����:20�_
        {
            point = point + 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag") //�_:5�_
        {
            point = point + 5;
        }

        this.ballpointText.GetComponent<Text>().text = "Point:" + point;
    }
}