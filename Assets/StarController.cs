using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    // ��]���x
    private float rotSpeed = 0.5f;  //float�^�ϐ��g�p���͍Ō��[f]���t��(f�͕W���ŕt���錈�܂�ɂȂ��Ă�炵���BFPS�Ƃ͊֘A���Ȃ�)


    // Use this for initialization
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);   
        //(X��,Y��,Z��)    �����Y�����猩�ĉ�]���邩��Y���ɋ�̓I���l(Random������w��Ȃ�)��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, this.rotSpeed, 0);
        //(X��,Y��,Z��)�@8�s�ڂ̐ݒ肪���f
    }
}