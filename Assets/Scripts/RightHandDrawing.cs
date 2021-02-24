using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class RightHandDrawing : MonoBehaviour
{
    public SteamVR_Action_Boolean RightTrigger;
    public SteamVR_Input_Sources handType;

    public static bool line_starting_point_status = true;
    public static bool line_end_point_status = false;

    public static Vector3 line_starting_position;
    public static Vector3 line_end_position;

    public static bool right_trigger_status = false;

    void Start()
    {
        RightTrigger.AddOnStateDownListener(TriggerDown, handType);
        RightTrigger.AddOnStateUpListener(TriggerUp, handType);

    }
    
    void OnTriggerEnter(Collider other)
    {
        //To catch the starting point
        if (other.gameObject.name.Contains("Point") && right_trigger_status)
        {
            
            line_starting_position = other.gameObject.transform.position;
            line_starting_point_status = true;

        }
        //To catch the ending point
        if (other.gameObject.name.Contains("Point") && line_starting_point_status)
        {
            line_end_position = other.gameObject.transform.position;
            line_end_point_status = true;

        }

    }

    void OnTriggerStay(Collider other)
    {
        //To catch the starting point
        if (other.gameObject.name.Contains("Point") && right_trigger_status)
        {
            line_starting_position = other.gameObject.transform.position;
            line_starting_point_status = true;
        }
    }
    
    
    public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        right_trigger_status = false;
        //Debug.Log("Right Trigger UP");

    }
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        right_trigger_status = true;
        //Debug.Log("Right Trigger Down");
    }

}
