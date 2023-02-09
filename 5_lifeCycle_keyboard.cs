using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeCycle_keyboard : MonoBehaviour
{

    // Input:���� �� �Է��� �����ϴ� Ŭ����
    void Update()
    {
        if (Input.anyKeyDown)     //anyKeyDown:�ƹ� �Է��� ���ʷ� ���� �� true
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        }

        if (Input.anyKey)     //anyKey:�ƹ� �Է��� ������ true
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
        }


        //Ű���� �Է� �Լ� down, stay, up

        //GetKey: Ű���� ��ư �Է��� ������ true
        if (Input.GetKeyDown(KeyCode.Return))    //Return�� ���͸� �ǹ��Ѵ�. ��, Ű�ڵ忡�� ���͸� ������ ���ڿ� ���.
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��.");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");


        //mouse  �Է� �Լ�
        //GetMouse: ���콺 ��ư �Է��� ������ true

        if (Input.GetMouseButtonDown(0))   //0�� ���콺 ���� ��ư, 1�� ������ ��ư
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��....");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!");


        //GetButton: Input��ư �Է��� ������ true
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if(Input.GetButton("Jump"))
            Debug.Log("���� ������ ��.......");

        if(Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!");


        //GetAxis: ����,���� ��ư �Է��� ������ float
        //GetAxisRaw: 0,1,-1 ���� ��� �߰���(float)���� ������� ����.
        if (Input.GetButton("Horizontal"))
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));

        if (Input.GetButton("Vertical"))
            Debug.Log("�� �̵� ��..." + Input.GetAxis("Vertical"));


    }
}
