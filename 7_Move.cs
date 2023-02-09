using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //1.MoveTowards: Constant speed movement------>MoveTowards(current position, target position, speed)
        Vector3 target = new Vector3(8, 1.5f, 0);
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);


        //2.SmootDamp------>SmoothDamp(current position, target position, reference speed, speed)
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo ,1f);


        //3.Lerp:linear interpolation------->Lerp(current position, target position, speed) Lerp's max speed is 1
        transform.position =
            Vector3.Lerp(transform.position, target, 1f);


        //4.Slerp: spherical linear interpolation(moves like a circle)
        transform.position =
            Vector3.Slerp(transform.position, target, 1f);
    }
}
