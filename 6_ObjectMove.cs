using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Transform: 오브젝트 형태에 대한 기본 컴포넌트. 오브젝트는 변수 transform을 항상 가지고 있음.
        //Translate:벡터 값을 현재 위치에 더하는 함수
        //Vector3 vec = new Vector3(0, 0, 0); //벡터 값, x축 방향으로 1만큼 이동.
       
        //transform.Translate(vec);   //삼차원
         
        
    }

    void Update()
    {
        Vector3 vec1 = new Vector3(0, 0.1f, 0); //벡터 값, y축 방향으로 0.1만큼 이동.
        transform.Translate(vec1);   //삼차원


        Vector3 vec2 = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime,  //deltaTime: if frame is small and short delta Time amount is big, if frame is big and long delta Time amount is small.
            Input.GetAxisRaw("Vertical") * Time.deltaTime
            , 0);
        transform.Translate(vec2);


    }

  
}
