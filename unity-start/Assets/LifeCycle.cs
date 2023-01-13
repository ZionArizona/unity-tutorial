using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{   
    
    //1.Initialize
    //Awake:게임 오브젝트 생성할 때, 최초 실행
   void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    //Activate(Between Initialize and physic)
    void OnEnable()  //OnEnable: When gameObject activates this function is called.
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void start() //업데이트 시작 직넉, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    
    //2.physica
    void FixedUpdate()  //FixedUpdate: 물리 연산 업데이트, this function uses a lot of cpu operation.
    {
        Debug.Log("이동~");
    }

    //3.GameLogic
    void Update() //Update: Game Logic Update. Difference between FixedUpdate is that Update function works depends on the computer hardware. 
                       //It could be better or worse.  
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate()  //LateUpdate: After every date finishes LateUpdate function is called. 
    {
        Debug.Log("경험치 획득.");
    }


    //Disactive(Between GameLogic and Disalble)
    void OnDisable()   //OnDisable: When GameObject is disactivae this function is called.
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    //4.Disable
    void OnDestroy()  //OnDestroy: this function is used when gameObject is deleted.
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }


}
