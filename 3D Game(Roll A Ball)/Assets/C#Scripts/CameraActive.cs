using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActive : MonoBehaviour
{

    Transform playerTransform;
    Vector3 Offset;

    void Awake()
    {
        //FindGameObjectWithTag(): �־��� �±׷� ������Ʈ �˻�
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
