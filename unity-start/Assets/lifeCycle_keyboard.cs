using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeCycle_keyboard : MonoBehaviour
{

    // Input:게임 내 입력을 관리하는 클래스
    void Update()
    {
        if (Input.anyKeyDown)     //anyKeyDown:아무 입력을 최초로 받을 때 true
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }

        if (Input.anyKey)     //anyKey:아무 입력을 받으면 true
        {
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        }


        //키보드 입력 함수 down, stay, up

        //GetKey: 키보드 버튼 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return))    //Return은 엔터를 의미한다. 즉, 키코드에서 엔터를 누르면 문자열 출력.
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");


        //mouse  입력 함수
        //GetMouse: 마우스 번튼 입력을 받으면 true

        if (Input.GetMouseButtonDown(0))   //0은 마우스 왼쪽 버튼, 1은 오른쪽 버튼
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중....");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!");


        //GetButton: Input버튼 입력을 받으면 true
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if(Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중.......");

        if(Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!");


        //GetAxis: 수평,수직 버튼 입력을 받으면 float
        //GetAxisRaw: 0,1,-1 값을 출력 중간값(float)값은 출력하지 않음.
        if (Input.GetButton("Horizontal"))
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));

        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동 중..." + Input.GetAxis("Vertical"));


    }
}
