using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{   
    
    //1.Initialize
    //Awake:���� ������Ʈ ������ ��, ���� ����
   void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    //Activate(Between Initialize and physic)
    void OnEnable()  //OnEnable: When gameObject activates this function is called.
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void start() //������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }
    
    //2.physica
    void FixedUpdate()  //FixedUpdate: ���� ���� ������Ʈ, this function uses a lot of cpu operation.
    {
        Debug.Log("�̵�~");
    }

    //3.GameLogic
    void Update() //Update: Game Logic Update. Difference between FixedUpdate is that Update function works depends on the computer hardware. 
                       //It could be better or worse.  
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate()  //LateUpdate: After every date finishes LateUpdate function is called. 
    {
        Debug.Log("����ġ ȹ��.");
    }


    //Disactive(Between GameLogic and Disalble)
    void OnDisable()   //OnDisable: When GameObject is disactivae this function is called.
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    //4.Disable
    void OnDestroy()  //OnDestroy: this function is used when gameObject is deleted.
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }


}
