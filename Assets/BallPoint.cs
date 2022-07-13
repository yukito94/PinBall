using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPoint : MonoBehaviour{

    // Materialを入れる
    //Material myMaterial;

    // 角度
    private int degree = 0;

    //point宣言と初期値(得点)
    int point = 0;
    
    //pointを表示するテキスト
    private GameObject ballpointText;

    // Start is called before the first frame update
    void Start()
    {
        //画面右上に得点を表示
        this.ballpointText = GameObject.Find("BallPointText");

        // タグによってpointを加算してく
    }

    // Update is called once per frame
    /*
    void Update()
    {
        //得点を表示
        this.ballpointText.GetComponent<Text>().text = "Point:" + point;
    }
    */

    void OnCollisionEnter(Collision other)
    {
        //other：ボール
        //other.gameObject.tag：ボール以外のゲームオブジェクト

        // タグによってpointを加算してく
        if (other.gameObject.tag == "SmallStarTag") //小さい星:10点
        {
            point = point + 10;
        }
        else if (other.gameObject.tag == "LargeStarTag") //大きい星:20点
        {
            point = point + 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag") //雲:5点
        {
            point = point + 5;
        }

        this.ballpointText.GetComponent<Text>().text = "Point:" + point;
    }
}