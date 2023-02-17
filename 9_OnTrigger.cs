using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h,0,v);
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    //�ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
    //void OnTriggerEnter(Collider other);
    //void OnTriggerStay(Collider other);
    //void OnTriggerExit(Collider other);

    //TriggerStay: �ݶ��̴��� ��� �浹�ϰ� ���� �� ȣ��.
   


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("hi");
        if(other.gameObject.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
