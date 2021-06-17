using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    // - ����
    Vector3 dir;
    // - �ӷ�
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // �¾�� 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��������� ���ϰ�
        int result = UnityEngine.Random.Range(0, 10);
        if(result < 3)
        {
            // �÷��̾� ����
            GameObject target = GameObject.Find("Player");
            // dir = target - me
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            // �Ʒ� ����
            dir = Vector3.down;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // ��ư��鼭 �� �������� ��� �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        // ���װ�
        Destroy(other.gameObject);
        // ������
        Destroy(gameObject);
    }
}

