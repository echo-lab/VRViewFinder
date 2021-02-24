using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPosition : MonoBehaviour
{
    public GameObject camera_tf;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
    }
}
