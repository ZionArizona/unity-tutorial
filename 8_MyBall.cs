using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //Learning about RigidBody
    //rigidbody 선언
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<T>(): 자신의 T타입 컴포넌트를 가져옴.
        //초기화
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); //캐릭터 점프에 대부분 사용되는 코드
    }

    //RigidBody 관련 코드는 FixedUpdate에 작성. 하지만 큰 상관은 없다. 
    void FixedUpdate()
    {
        //1.속력 바꾸기
        //velocity:현재 이동 속도
        /*rigid.velocity = Vector3.right;
        rigid.velocity = new Vector3(2, 4, 3);*/

        //2. 힘을 가하기
        /*
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
            );

            rigid.AddForce(vec, ForceMode.Impulse);
        */
        //3. 회전력
        //AddTorque(Vec): Vec방향을 축으로 회전력이 생김.
        //rigid.AddTorque(Vector3.back);
       
    }
   
}
