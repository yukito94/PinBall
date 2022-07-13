using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //最小サイズ
    private float minimum = 1.0f;
    //拡大縮小スピード
    private float magSpeed = 10.0f;
    //拡大率
    private float magnification = 0.07f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
        //[Vector]によりそれぞれの軸に力の方向を指定してる。
        //[sin]関数で拡大と縮小を行う。
        //[Mathfクラスsin]関数は引数(ラジアン)に与えた角度をサインの値で返してる。
    }
}
