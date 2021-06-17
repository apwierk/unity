using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 이동 공식 P = P0 * vt
        // transform.position += Vector3.up * 5 * Time.deltaTime;

        // 1. 사용자의 입력(방향)에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 방향을 만들고
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // right : [0,0,0]  [1,0,0] [-1,0,0]
        // up    : [0,0,0]  [0,1,0] [0,-1,0]

        //문제 발생 !
        // 대각으로 이동시 더 빠르다
        // 벡터를 정규화 한다. a + b = c c의 크기는 루트 2 이기 때문에;
        dir.Normalize();


        // 3. 그 방향으로 플레이어를 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
        

    }
}

