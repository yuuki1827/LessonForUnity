using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Move : MonoBehaviour
{
    private Vector3 m_pos;
    // Start is called before the first frame update
    void Start()
    {
        // 形状位置の保持
        m_pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // 形状位置の更新
        transform.localPosition = m_pos;
        m_pos.x += 0.05f;
    }
}
