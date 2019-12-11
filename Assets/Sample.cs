using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* コンソールウィンドウに表示する */
        // コンソールに「Hello,World」を表示する
        Debug.Log("Hello,World");

        /* 変数への代入 */
        // 変数の宣言
        int age;
        // 変数へ代入
        age = 30;
        // コンソールに表示
        Debug.Log(age);

        /* 変数の初期化と代入 */
        // 変数の宣言
        float height1 = 160.5f;
        float height2;
        // 代入
        height2 = height1;
        // コンソールに表示
        Debug.Log(height2);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
