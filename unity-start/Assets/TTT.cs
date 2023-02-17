using UnityEngine;

public class TTT : MonoBehaviour
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
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    //콜라이더 충돌로 발생하는 이벤트
    //void OnTriggerEnter(Collider other);
    //void OnTriggerStay(Collider other);
    //void OnTriggerExit(Collider other);

  
    //TriggerStay: 콜라이더가 계속 충돌하고 있을 때 호출.
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "cube")
            rigid.AddForce(Vector3.up*30, ForceMode.Impulse);
    }
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
