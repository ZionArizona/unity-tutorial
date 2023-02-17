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
        //������Ʈ ���� ������ MeshRenderer�� ���ؼ�.
        mat = mesh.material;
    }
    //CollisionEnter: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    
    //���� �������� �浹�� �߻��ϴ� �̺�Ʈ
    //void OnCollisionEnter(Collision collision) {}
    //void OnCollisionStay(Collision collision) {}
    //void OnCollisionExit(Collision collision) {}
    
    
    
    //Collision: �浹 ���� Ŭ����
    private void OnCollisionEnter(Collision coll)
    {
        //Color: �⺻ ���� Ŭ����, Color32: 255 ���� Ŭ����.
        //�浹�� ���ӿ�����Ʈ�� �̸��� Sphere�� ��� ���������� ���Ѵ�.
        if(coll.gameObject.name == "Sphere")
            mat.color = new Color(0, 0, 0);
    }



    private void OnCollisionStay(Collision collision)
    {

    }



    //OnCollisionExit:������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    private void OnCollisionExit(Collision collision)
    {

    }
}
