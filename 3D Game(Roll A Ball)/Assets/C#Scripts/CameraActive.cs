using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{

    Transform playerTransform;
    Vector3 Offset;

    void Awake()
    {
        //FindGameObjectWithTag(): 주어진 태그로 오브젝트 검색
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
