using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LeftHandEraser : MonoBehaviour
{
    public SteamVR_Action_Boolean LeftTrigger;
    public SteamVR_Input_Sources handType;

    private bool left_trigger_status = false;

    void Start()
    {
        LeftTrigger.AddOnStateDownListener(TriggerDown, handType);
        LeftTrigger.AddOnStateUpListener(TriggerUp, handType);

    }
    
    void OnTriggerEnter(Collider other)
    {
        //To erase the objet
        if (other.gameObject.name.Contains("Cylinder") && left_trigger_status)
        {
            Destroy(other.gameObject);
            Debug.Log("destroyed");
        }

    }

    private void OnTriggerStay(Collider other)
    {

        //To erase the objet
        if (other.gameObject.name.Contains("Cylinder") && left_trigger_status)
        {
            Destroy(other.gameObject);
            Debug.Log("destroyed");
        }
    }
    
    public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        left_trigger_status = false;
        //Debug.Log("Left Trigger Up");

    }
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        left_trigger_status = true;
        //Debug.Log("Left Trigger Down");
    }
}
