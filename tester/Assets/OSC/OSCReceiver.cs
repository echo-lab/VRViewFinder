using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class OSCReceiver : MonoBehaviour
{

    public OSC osc;
    public GameObject CameraRig;
    public GameObject cube;
    public Vector3 originalCam;
    

    // Use this for initialization
    void Start()
    {
        osc = GameObject.Find("OSC").GetComponent<OSC>();
        osc.SetAddressHandler("/CubeXYZ", OnReceiveXYZ);
        osc.SetAddressHandler("/CubeX", OnReceiveX);
        osc.SetAddressHandler("/CubeY", OnReceiveY);
        osc.SetAddressHandler("/CubeZ", OnReceiveZ);
        //CameraRig.GetComponent<SteamVR_PlayArea>().GetBounds(SteamVR_PlayArea.Size.Calibrated, ref rect)
        //Vector3[] vertices = CameraRig.GetComponent<SteamVR_PlayArea>().vertices;
        //Instantiate(cube, vertices[1], Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnReceiveXYZ(OscMessage message)
    {
        float x = message.GetFloat(0);
        float y = message.GetFloat(1);
        float z = message.GetFloat(2);
        
        transform.position = originalCam + new Vector3(x, y, z);
        Debug.Log(message);
    }

    void OnReceiveX(OscMessage message)
    {
        float x = message.GetFloat(0);

        Vector3 position = transform.position;

        position.x = x;

        transform.position = originalCam + position;
        Debug.Log(x);
    }

    void OnReceiveY(OscMessage message)
    {
        float y = message.GetFloat(0);

        Vector3 position = transform.position;

        position.y = y;

        transform.position = originalCam + position;
        Debug.Log(y);
    }

    void OnReceiveZ(OscMessage message)
    {
        float z = message.GetFloat(0);

        Vector3 position = transform.position;

        position.z = z;

        transform.position = originalCam + position;
        Debug.Log(z);
    }


}
