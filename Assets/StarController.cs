using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    // 回転速度
    private float rotSpeed = 0.5f;  //float型変数使用時は最後に[f]が付く(fは標準で付ける決まりになってるらしい。FPSとは関連性なし)


    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);   
        //(X軸,Y軸,Z軸)    今回はY軸から見て回転するからY軸に具体的数値(Randomだから指定なし)を設定
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, this.rotSpeed, 0);
        //(X軸,Y軸,Z軸)　8行目の設定が反映
    }
}