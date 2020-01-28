using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class moveRig : MonoBehaviour
{
    public SteamVR_Action_Vector2 joystickAction;
    public SteamVR_Input_Sources moveHand;
    public float speed = 0.1f;

    public GameObject originalCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 joystickV = joystickAction.GetAxis(moveHand);
        if(joystickV != Vector2.zero)
        {
            //Debug.Log(joystickV);
            transform.position = new Vector3(transform.position.x + (speed * joystickV.x), transform.position.y, transform.position.z + (speed * joystickV.y));

            originalCam.transform.position = new Vector3(originalCam.transform.position.x + (speed * joystickV.x), originalCam.transform.position.y, originalCam.transform.position.z + (speed * joystickV.y));

        }
    }
}
