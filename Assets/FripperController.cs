using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // Use this for initialization
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        //左矢印キーを押した時左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キーを押した時右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //矢印キー離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }


        //タッチ処理に関する処理
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //[Screen.width / 2]画面を2分割し判定
            if (Input.mousePosition.x >= Screen.width / 2)
            {
                // 右側をタップしたら右のフリッパーが動く
                if (touch.phase == TouchPhase.Began && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }
            else
            {
                // 左側をタップしたら左のフリッパーが動く
                if (touch.phase == TouchPhase.Began && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }


            // タッチ終了
            if (touch.phase == TouchPhase.Ended)
            {
            SetAngle(this.defaultAngle);
            }

        }

    }

    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}