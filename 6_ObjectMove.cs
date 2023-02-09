using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Transform: ������Ʈ ���¿� ���� �⺻ ������Ʈ. ������Ʈ�� ���� transform�� �׻� ������ ����.
        //Translate:���� ���� ���� ��ġ�� ���ϴ� �Լ�
        //Vector3 vec = new Vector3(0, 0, 0); //���� ��, x�� �������� 1��ŭ �̵�.
       
        //transform.Translate(vec);   //������
         
        
    }

    void Update()
    {
        Vector3 vec1 = new Vector3(0, 0.1f, 0); //���� ��, y�� �������� 0.1��ŭ �̵�.
        transform.Translate(vec1);   //������


        Vector3 vec2 = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime,  //deltaTime: if frame is small and short delta Time amount is big, if frame is big and long delta Time amount is small.
            Input.GetAxisRaw("Vertical") * Time.deltaTime
            , 0);
        transform.Translate(vec2);


    }

  
}
