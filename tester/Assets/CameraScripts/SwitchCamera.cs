using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public KeyCode CameraNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(CameraNumber))
        {
            GameObject[] cameras = GameObject.FindGameObjectsWithTag("Camera");
            for (int i = 0; i < cameras.Length; i++)
            {
                cameras[i].GetComponent<Camera>().depth = -1;
            }
            GetComponent<Camera>().depth = 1;
        }
    }
}
