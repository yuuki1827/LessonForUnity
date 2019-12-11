using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyrlinder_Move : MonoBehaviour
{

    // 回転の中心
    Vector3 rotatePoint = Vector3.zero;
    // 回転軸
    Vector3 rotateAxis = Vector3.zero;
    // 回転角度
    float cyrlinderAngle = 0f;

    // シリンダーの大きさの半分
    float cyrlinderSizeHalf;
    // 回転中に立つフラグ。回転中は入力を受け付けない
    bool isRotate = false;

    void Start()
    {
        cyrlinderSizeHalf = transform.localScale.x / 2f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotatePoint = transform.position + new Vector3(cyrlinderSizeHalf, -cyrlinderSizeHalf, 0f);
            rotateAxis = new Vector3(0, 0, -1);
            //cyrlinderAngle = 90f;
            //transform.RotateAround(rotatePoint, rotateAxis, cyrlinderAngle);
            StartCoroutine(MoveCylinder());
        }
    }

    IEnumerator MoveCylinder()
    {
        // 回転中にフラグを立てる
        isRotate = true;

        /* 回転処理 */
        // angleの合計を保存
        float sumAngle = 0f; 

        while (sumAngle < 90f)
        {
            // 回転速度
            cyrlinderAngle = 15f;
            sumAngle += cyrlinderAngle;

            // 90度以上回転しないように値を制限
            if (sumAngle > 90f)
            {
                cyrlinderAngle -= sumAngle - 90f;
            }

            transform.RotateAround(rotatePoint, rotateAxis, cyrlinderAngle);

            yield return null;
        }

        // 回転中のフラグを倒す
        isRotate = false;

        yield break;
    }
}
