using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    //Learning about RigidBody
    //rigidbody ����
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<T>(): �ڽ��� TŸ�� ������Ʈ�� ������.
        //�ʱ�ȭ
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); //ĳ���� ������ ��κ� ���Ǵ� �ڵ�
    }

    //RigidBody ���� �ڵ�� FixedUpdate�� �ۼ�. ������ ū ����� ����. 
    void FixedUpdate()
    {
        //1.�ӷ� �ٲٱ�
        //velocity:���� �̵� �ӵ�
        /*rigid.velocity = Vector3.right;
        rigid.velocity = new Vector3(2, 4, 3);*/

        //2. ���� ���ϱ�
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
        //3. ȸ����
        //AddTorque(Vec): Vec������ ������ ȸ������ ����.
        //rigid.AddTorque(Vector3.back);
       
    }
   
}
