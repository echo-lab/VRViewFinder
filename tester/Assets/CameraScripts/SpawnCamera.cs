using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCamera : MonoBehaviour
{
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(Camera, new Vector3(0, 1, -5), Quaternion.identity);
            GameObject[] cameras = GameObject.FindGameObjectsWithTag("Camera");
            int len = cameras.Length - 1;
            KeyCode camKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), "Keypad" + len.ToString());
            Debug.Log(camKeyCode);
            Camera.GetComponent<SwitchCamera>().CameraNumber = camKeyCode;
        }
    }
}
