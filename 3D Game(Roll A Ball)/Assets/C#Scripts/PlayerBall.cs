using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    Rigidbody rigid;
    public float jumppower;
    bool isJump;
    public int itemCount = 0;
    AudioSource audio;
    public GameManagerLogic manager;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        isJump = false;
        audio = GetComponent<AudioSource>();
    }
    

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumppower , 0), ForceMode.Impulse);
        }
    }


    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h,0,v),ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" )
        {
            isJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Capsule")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
        else if(other.tag == "Finish")
        {
            if(itemCount == manager.TotalItemCount)
            {
                //Game Clear!
                SceneManager.LoadScene("Example1_"+(manager.stage+1).ToString());

            }
            else
            {
                //LoadScene():주어진 장면을 불러오는 함수
                SceneManager.LoadScene("Example1_" + manager.stage.ToString());
                //Restart...
            }
        }
        /*
        if (other.name == "Player")
        {
            PlayerBall player = other.GetComponent<PlayerBall>();
            player.itemCount++;
            //SetActive(bool):오브젝트 활성화 함수
            gameObject.SetActive(false);
            audio.Play();
            other.gameObject.SetActive(false);
        }
        */
    }
}
