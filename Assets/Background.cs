using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// offset을 y방향으로 스크롤 하고싶다.
public class Background : MonoBehaviour
{

    public float speed = 0.1f;

    Material mat;
    // MeshRenderer > Material > OffsetY
    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때MeshRenderer을 가져와서
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        // 그 안에 있는 Material 을 기억하고 싶다.
        mat = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        // 살아가면서 Material 의 OffsetY값을 증가시키고 싶다. 
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
