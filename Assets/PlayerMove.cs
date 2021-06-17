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
        // �̵� ���� P = P0 * vt
        // transform.position += Vector3.up * 5 * Time.deltaTime;

        // 1. ������� �Է�(����)�� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. ������ �����
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // right : [0,0,0]  [1,0,0] [-1,0,0]
        // up    : [0,0,0]  [0,1,0] [0,-1,0]

        //���� �߻� !
        // �밢���� �̵��� �� ������
        // ���͸� ����ȭ �Ѵ�. a + b = c c�� ũ��� ��Ʈ 2 �̱� ������;
        dir.Normalize();


        // 3. �� �������� �÷��̾ �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
        

    }
}

