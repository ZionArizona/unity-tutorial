using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        //오브젝트 재질 접근은 MeshRenderer를 통해서.
        mat = mesh.material;
    }
    //CollisionEnter: 물리적 충돌이 시작할 때 호출되는 함수.
    
    //실제 물리적인 충돌로 발생하는 이벤트
    //void OnCollisionEnter(Collision collision) {}
    //void OnCollisionStay(Collision collision) {}
    //void OnCollisionExit(Collision collision) {}
    
    
    
    //Collision: 충돌 정보 클래스
    private void OnCollisionEnter(Collision coll)
    {
        //Color: 기본 색상 클래스, Color32: 255 색상 클래스.
        //충돌한 게임오브젝트의 이름이 Sphere일 경우 검정색으로 변한다.
        if(coll.gameObject.name == "Sphere")
            mat.color = new Color(0, 0, 0);
    }



    private void OnCollisionStay(Collision collision)
    {

    }



    //OnCollisionExit:물리적 충돌이 끝났을 때 호출되는 함수.
    private void OnCollisionExit(Collision collision)
    {

    }
}
